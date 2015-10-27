using eForm.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
//using System.Data.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Deployment.Application;
using System.IO;

namespace eForm.Data.SqlServerCompact
{
    public class eFormSqlCeContext : DbContext
    {
        private string _dbPath;

        public eFormSqlCeContext()
            : base()
        {
            InitializeData();
            //var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;  

            var path = _dbPath;// Path.Combine(directory, @"ApplicationName\MyDatabase.sdf");
            string password = "qwe123";
            var connectionString = string.Format("Data Source={0}; Password={1}", path, password);
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0", "", connectionString);
            //Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.3.5", "", connectionString);
            Database.SetInitializer<eFormSqlCeContext>(new eFormContextInitializer());
        }

        private void InitializeData()
        {
            try
            {

                string dbSourceFile = "";
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    string dataPath = ApplicationDeployment.CurrentDeployment.DataDirectory;
                    dbSourceFile = Path.Combine(dataPath, "eForm.Win.sdf");
                }
                else
                {
                    string dataPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                    dbSourceFile = Path.Combine(dataPath, "eForm.Win.sdf");
                }

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userFilePath = Path.Combine(localAppData, "eForm");

                if (!Directory.Exists(userFilePath))
                    Directory.CreateDirectory(userFilePath);

                _dbPath = Path.Combine(userFilePath, "eForm.Win.sdf");

                //TODO: temporary delete it first for development
                if (File.Exists(_dbPath))
                    File.Delete(_dbPath);


                if (!File.Exists(_dbPath))
                {
                    File.Copy(dbSourceFile, _dbPath);
                }

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

            // MessageBox.Show("Check Database Exist :" + File.Exists(Constant.DatabasePath).ToString());
        }

        public eFormSqlCeContext(string _dbPath)
        {
            // TODO: Complete member initialization
            this._dbPath = _dbPath;
        }

        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<ProfileInfo> ProfileInfos { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

        public DbSet<EndUserType> EndUserTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ApplicationType> ApplicationTypes { get; set; }

        public int SaveChanges(string username)
        {
            var userName = string.IsNullOrEmpty(username) ? "amir@fa-bigdata.com" : username;

            // Get all Added/Deleted/Modified entities (not Unmodified or Detached)
            foreach (var entry in this.ChangeTracker.Entries().Where(p => p.State == EntityState.Added || p.State == EntityState.Deleted || p.State == EntityState.Modified))
            {
                // For each changed record, get the audit record entries and add them
                foreach (AuditLog x in GetAuditRecordsForChange(entry, userName))
                {
                    this.AuditLogs.Add(x);
                }

                var entity = entry.Entity as BaseData;
                if (entity != null)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedAt = DateTime.UtcNow;
                        entity.CreatedBy = userName;
                        entity.UpdatedAt = DateTime.UtcNow;
                        entity.UpdatedBy = userName;
                    }
                    else if (entry.State == EntityState.Modified || entry.State == EntityState.Deleted)
                    {
                        entity.UpdatedAt = DateTime.UtcNow;
                        entity.UpdatedBy = userName;
                    }
                }
            }


            // Call the original SaveChanges(), which will save both the changes made and the audit records
            return base.SaveChanges();
        }

        private List<AuditLog> GetAuditRecordsForChange(DbEntityEntry dbEntry, string username)
        {
            List<AuditLog> result = new List<AuditLog>();

            var changeTime = DateTime.UtcNow;

            // Get table name (if it has a Table attribute, use that, otherwise get the pluralized name)
            string tableName = GetTableName(dbEntry);

            string keyName = "Id";
            //string keyName = keyNames[0].Name; //dbEntry.Entity.GetType().GetProperties().Single(p => p.GetCustomAttributes(typeof(KeyAttribute), false).Count() > 0).Name;

            if (dbEntry.State == EntityState.Added)
            {
                // For Inserts, just add the whole record
                // If the entity implements IDescribableEntity, use the description from Describe(), otherwise use ToString()

                foreach (string propertyName in dbEntry.CurrentValues.PropertyNames)
                {
                    result.Add(new AuditLog()
                    {
                        Username = username,
                        EventDateUtc = changeTime,
                        EventType = AuditType.Insert, // Added
                        TableName = tableName,
                        RecordId = dbEntry.CurrentValues.GetValue<object>(keyName).ToString(),
                        ColumnName = propertyName,
                        NewValue =
                            dbEntry.CurrentValues.GetValue<object>(propertyName) == null
                                ? null
                                : dbEntry.CurrentValues.GetValue<object>(propertyName).ToString()
                    }
                        );
                }


            }
            else if (dbEntry.State == EntityState.Deleted)
            {
                // Same with deletes, do the whole record, and use either the description from Describe() or ToString()
                result.Add(new AuditLog()
                {
                    Username = username,
                    EventDateUtc = changeTime,
                    EventType = AuditType.Delete, // Deleted
                    TableName = tableName,
                    RecordId = dbEntry.OriginalValues.GetValue<object>(keyName).ToString(),
                    ColumnName = "*ALL",
                    NewValue =
                        (dbEntry.OriginalValues.ToObject() is IDescribableEntity)
                            ? (dbEntry.OriginalValues.ToObject() as IDescribableEntity).Describe()
                            : dbEntry.OriginalValues.ToObject().ToString()
                }
                    );
            }
            else if (dbEntry.State == EntityState.Modified)
            {
                foreach (string propertyName in dbEntry.OriginalValues.PropertyNames)
                {
                    // For updates, we only want to capture the columns that actually changed
                    if (!object.Equals(dbEntry.OriginalValues.GetValue<object>(propertyName), dbEntry.CurrentValues.GetValue<object>(propertyName)))
                    {
                        result.Add(new AuditLog()
                        {
                            Username = username,
                            EventDateUtc = changeTime,
                            EventType = AuditType.Update, // Modified
                            TableName = tableName,
                            RecordId = dbEntry.OriginalValues.GetValue<object>(keyName).ToString(),
                            ColumnName = propertyName,
                            OriginalValue =
                                dbEntry.OriginalValues.GetValue<object>(propertyName) == null
                                    ? null
                                    : dbEntry.OriginalValues.GetValue<object>(propertyName).ToString(),
                            NewValue =
                                dbEntry.CurrentValues.GetValue<object>(propertyName) == null
                                    ? null
                                    : dbEntry.CurrentValues.GetValue<object>(propertyName).ToString()
                        }
                            );
                    }

                }

            }
            // Otherwise, don't do anything, we don't care about Unchanged or Detached entities

            return result;
        }

        private string GetTableName(DbEntityEntry ent)
        {
            ObjectContext objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;
            Type entityType = ent.Entity.GetType();

            if (entityType.BaseType != null && entityType.Namespace == "System.Data.Entity.DynamicProxies")
                entityType = entityType.BaseType;

            string entityTypeName = entityType.Name;

            var container =
                objectContext.MetadataWorkspace.GetEntityContainer(objectContext.DefaultContainerName,System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
            string entitySetName = (from meta in container.BaseEntitySets
                                    where meta.ElementType.Name == entityTypeName
                                    select meta.Name).First();
            return entitySetName;
        }

    }
}
