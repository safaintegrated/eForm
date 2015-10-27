using eForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{
    public class ApplicationTypeModel : BaseModel<ApplicationTypeModel>
    {
        public static IEnumerable<ApplicationType> FindAll()
        {
            return Db.ApplicationTypes.AsEnumerable();
        }
        public static void Add(ApplicationType o, string user)
        {
            Db.ApplicationTypes.Add(o);
            Db.SaveChanges(user);
        }

        //Update record
        public static void Update(ApplicationType o, string user)
        {
            var result = from r in Db.ApplicationTypes where r.Id == o.Id select r;
            Db.SaveChanges(user);

        }
        //Delete record
        public static void Delete(ApplicationType o, string user)
        {
            var result = from r in Db.ApplicationTypes where r.Id == o.Id select r;
            Db.ApplicationTypes.Remove(result.FirstOrDefault());
            Db.SaveChanges(user);

        }


        public static IEnumerable<ApplicationType> FindAllByProductCode(string code)
        {
            return Db.ApplicationTypes.AsEnumerable().Where(c => c.ProductCode == code);
        }
    }
}
