using eForm.Data;
using eForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Transactions;

namespace eForm.Services
{
    public class ProfileInfoService : IProfileInfoService
    {
        //DbContext _db;
        //private GenericRepository<ProfileInfo> _profileInfoRepo;
        private UnitOfWork _unitOfWork;

        public ProfileInfoService(DbContext db)
        {
            //_db = db;
            _unitOfWork = new UnitOfWork(db);
        }

        public Data.ProfileInfo GetById(string id)
        {
            return _unitOfWork.ProfileInfoRepo.GetByID(id);
        }

        public IList<Data.ProfileInfo> FindAll()
        {
            return _unitOfWork.ProfileInfoRepo.GetAll().ToList();
        }

        public string Create(Data.ProfileInfo o)
        {
           // using (var scope = new TransactionScope())
            {

                _unitOfWork.ProfileInfoRepo.Insert(o);
                _unitOfWork.Save();
             //   scope.Complete();
                return o.Id;
            }


            _unitOfWork.ProfileInfoRepo.Insert(o);
        }



        public bool Update(ProfileInfo o)
        {
            var success = false;
            if (o != null)
            {
                //using (var scope = new TransactionScope())
                {
                    var product = _unitOfWork.ProfileInfoRepo.GetByID(o.Id);
                    if (product != null)
                    {
                        //product = productEntity.ProductName;
                        _unitOfWork.ProfileInfoRepo.Update(product);
                        _unitOfWork.Save();
                       // scope.Complete();
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
               // using (var scope = new TransactionScope())
                {
                    var product = _unitOfWork.ProfileInfoRepo.GetByID(id);
                    if (product != null)
                    {

                        _unitOfWork.ProfileInfoRepo.Delete(product);
                        _unitOfWork.Save();
                    //    scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
