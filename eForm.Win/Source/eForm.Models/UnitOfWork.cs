using eForm.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace eForm.Models
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...

        private DbContext _context = null;
        private GenericRepository<ProfileInfo> _profileInfoRepo;
        private GenericRepository<Data.Application> _applicationRepository;
        private GenericRepository<Data.SystemUser> _systemUserRepo;
        #endregion

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        #region Public Repository Creation properties...

        /// <summary>
        /// Get/Set Property for product repository.
        /// </summary>
        public GenericRepository<SystemUser> SystemUserRepo
        {
            get
            {
                if (this._systemUserRepo == null)
                    this._systemUserRepo = new GenericRepository<SystemUser>(_context);
                return _systemUserRepo;
            }
        }

        /// <summary>
        /// Get/Set Property for user repository.
        /// </summary>
        public GenericRepository<Data.Application> ApplicationRepo
        {
            get
            {
                if (this._applicationRepository == null)
                    this._applicationRepository = new GenericRepository<Data.Application>(_context);
                return _applicationRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for token repository.
        /// </summary>
        public GenericRepository<ProfileInfo> ProfileInfoRepo
        {
            get
            {
                if (this._profileInfoRepo == null)
                    this._profileInfoRepo = new GenericRepository<ProfileInfo>(_context);
                return _profileInfoRepo;
            }
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
