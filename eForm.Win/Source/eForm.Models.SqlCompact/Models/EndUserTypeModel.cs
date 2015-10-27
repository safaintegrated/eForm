using eForm.Win.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{
    public class EndUserTypeModel : BaseModel<EndUserTypeModel>
    {
        public static IEnumerable<EndUserType> FindAll()
        {
            return Db.EndUserTypes.AsEnumerable();
        }
        public static void Add(EndUserType o, string user)
        {
            Db.EndUserTypes.Add(o);
            Db.SaveChanges(user);
        }

        //Update record
        public static void Update(EndUserType o, string user)
        {
            var result = from r in Db.EndUserTypes where r.Id == o.Id select r;
            Db.SaveChanges(user);

        }
        //Delete record
        public static void Delete(EndUserType o, string user)
        {
            var result = from r in Db.EndUserTypes where r.Id == o.Id select r;
            Db.EndUserTypes.Remove(result.FirstOrDefault());
            Db.SaveChanges(user);

        }

    }
}
