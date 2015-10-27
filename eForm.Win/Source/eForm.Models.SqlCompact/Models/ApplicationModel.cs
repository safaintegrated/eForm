using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{

    public class ApplicationModel : BaseModel<ApplicationModel>
    {
        public static IEnumerable<Application> FindAll()
        {
            return Db.Applications.AsEnumerable();
        }
        public static void Add(Application o, string user)
        {
            Db.Applications.Add(o);
            Db.SaveChanges(user);
        }

        //Update record
        public static void Update(Application o, string user)
        {
            var result = from r in Db.Applications where r.Id == o.Id select r;
            Db.SaveChanges(user);

        }
        //Delete record
        public static void Delete(Application o, string user)
        {
            var result = from r in Db.Applications where r.Id == o.Id select r;
            Db.Applications.Remove(result.FirstOrDefault());
            Db.SaveChanges(user);

        }
    }
}
