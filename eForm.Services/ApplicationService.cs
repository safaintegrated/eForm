using eForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
//using System.Transactions;

namespace eForm.Services
{
    public class ApplicationService : IApplicationService
    {
        //DbContext _db;
        //private GenericRepository<Application> _profileInfoRepo;
        private UnitOfWork _unitOfWork;

        public ApplicationService(DbContext db)
        {
            //_db = db;
            _unitOfWork = new UnitOfWork(db);
        }

        public Data.Application GetById(string id)
        {
            return _unitOfWork.ApplicationRepo.GetByID(id);
        }

        public IList<Data.Application> FindAll()
        {
            return _unitOfWork.ApplicationRepo.GetAll().ToList();
        }

        public string Create(Data.Application o)
        {
            //using (var scope = new TransactionScope())
            //{

                _unitOfWork.ApplicationRepo.Insert(o);
                _unitOfWork.Save();
            //    scope.Complete();
                return o.Id;
            //}


            //_unitOfWork.ApplicationRepo.Insert(o);
        }



        public bool Update(Data.Application o)
        {
            var success = false;
            if (o != null)
            {
                //using (var scope = new TransactionScope())
                //{
                    var product = _unitOfWork.ApplicationRepo.GetByID(o.Id);
                    if (product != null)
                    {
                        //product = productEntity.ProductName;
                        _unitOfWork.ApplicationRepo.Update(product);
                        _unitOfWork.Save();
                  //      scope.Complete();
                        success = true;
                    }
                //}
            }
            return success;
        }

        public bool Delete(string id)
        {
            var success = false;
            if (!string.IsNullOrEmpty(id))
            {
                //using (var scope = new TransactionScope())
                {
                    var product = _unitOfWork.ApplicationRepo.GetByID(id);
                    if (product != null)
                    {

                        _unitOfWork.ApplicationRepo.Delete(product);
                        _unitOfWork.Save();
              //          scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
