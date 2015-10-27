using eForm.Win.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{
    public class SystemUserModel : BaseModel<SystemUserModel>
    {
        public static IEnumerable<SystemUser> FindAll()
        {
            //using (eFormContext db = new eFormContext())
            //{
            //    return db.SystemUsers.ToList();
            //} 
            
            return Db.SystemUsers.AsEnumerable();
        }
        public static void Add(SystemUser o, string user)
        {
            Db.SystemUsers.Add(o);
            Db.SaveChanges(user);
        }

        //Update record
        public static void Update(SystemUser o, string user)
        {
            var result = from r in Db.SystemUsers where r.Id == o.Id select r;
            Db.SaveChanges(user);

        }
        //Delete record
        public static void Delete(SystemUser o, string user)
        {
            var result = from r in Db.SystemUsers where r.Id == o.Id select r;
            Db.SystemUsers.Remove(result.FirstOrDefault());
            Db.SaveChanges(user);

        }

    }
}
