using eForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
//using System.Transactions;

namespace eForm.Services
{
    public class SystemUserService : ISystemUserService
    {
        private UnitOfWork _unitOfWork;

        public SystemUserService(DbContext db)
        {
            //_db = db;
            _unitOfWork = new UnitOfWork(db);
        }

        public Data.SystemUser GetById(string id)
        {
            return _unitOfWork.SystemUserRepo.GetByID(id);
        }

        public IList<Data.SystemUser> FindAll()
        {
            return _unitOfWork.SystemUserRepo.GetAll().ToList();
        }

        public string Create(Data.SystemUser o)
        {
         //   using (var scope = new TransactionScope())
            {

                _unitOfWork.SystemUserRepo.Insert(o);
                _unitOfWork.Save();
            //    scope.Complete();
                return o.Id;
            }


            _unitOfWork.SystemUserRepo.Insert(o);
        }



        public bool Update(Data.SystemUser o)
        {
            var success = false;
            if (o != null)
            {
           //     using (var scope = new TransactionScope())
                {
                    var product = _unitOfWork.SystemUserRepo.GetByID(o.Id);
                    if (product != null)
                    {
                        //product = productEntity.ProductName;
                        _unitOfWork.SystemUserRepo.Update(product);
                        _unitOfWork.Save();
               //         scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        public bool Delete(string id)
        {
            var success = false;
            if (!string.IsNullOrEmpty(id))
            {
              //  using (var scope = new TransactionScope())
                {
                    var product = _unitOfWork.SystemUserRepo.GetByID(id);
                    if (product != null)
                    {

                        _unitOfWork.SystemUserRepo.Delete(product);
                        _unitOfWork.Save();
                  //      scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        public Data.SystemUser GetByUserId(string userId)
        {
            return _unitOfWork.SystemUserRepo.GetFirst(c=> c.UserName == userId);
        }
    }
}
