using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace eForm.Data.SqlServer
{
    //public class eFormContextInitializer : DropCreateDatabaseIfModelChanges<eFormContext>
    public class eFormContextInitializer : DropCreateDatabaseAlways<eFormSqlServerContext>
    {
        protected override void Seed(eFormSqlServerContext context)
        {
            var pf = new Data.ProfileInfo { FullName = "Abu" };
            context.ProfileInfos.Add(pf);
            var su = new SystemUser { UserName = "123", Password = "213" };
            su.ProfileId = pf.Id;
            su.ProfileInfo = pf;
            context.SystemUsers.Add(su);

            //End User Types
            context.EndUserTypes.Add(new EndUserType { Code = "RSD", Name = "Residential" });
            context.EndUserTypes.Add(new EndUserType { Code = "BNS", Name = "Business" });

            //Product Type
            context.ProductTypes.Add(new ProductType { Code="UNF", Name = "Unifi" });
            context.ProductTypes.Add(new ProductType { Code = "STM", Name = "Streamyx" });

            //Application Type
            context.ApplicationTypes.Add(new ApplicationType { Code="UNF-NEW", Name = "New Registration", ProductCode="UNF" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "UNF-ADD", Name = "Existing / Additional Service", ProductCode = "UNF" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "UNF-UDG", Name = "Upgrade / Downgrade", ProductCode = "UNF" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "UNF-REL", Name = "Rellocation", ProductCode = "UNF" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "UNF-TER", Name = "Termination", ProductCode = "UNF" });

            context.ApplicationTypes.Add(new ApplicationType { Code = "STM-NEW", Name = "New Registration", ProductCode = "STM" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "STM-ADD", Name = "Existing / Additional Service", ProductCode = "STM" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "STM-UDG", Name = "Upgrade / Downgrade", ProductCode = "STM" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "STM-REL", Name = "Rellocation", ProductCode = "STM" });
            context.ApplicationTypes.Add(new ApplicationType { Code = "STM-TER", Name = "Termination", ProductCode = "STM" });

            context.SaveChanges("system");
            base.Seed(context);
        }
    }
}
