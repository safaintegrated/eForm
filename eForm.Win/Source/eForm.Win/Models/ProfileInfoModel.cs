using eForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{
    public class ProfileInfoModel : BaseModel<ProfileInfoModel>
    {
        public static IEnumerable<ProfileInfo> FindAll()
        {
            return Db.ProfileInfos.AsEnumerable();
        }
        public static void Add(ProfileInfo o, string user)
        {
            Db.ProfileInfos.Add(o);
            Db.SaveChanges(user);
        }

        //Update record
        public static void Update(ProfileInfo o, string user)
        {
            var result = from r in Db.ProfileInfos where r.Id == o.Id select r;
            Db.SaveChanges(user);

        }
        //Delete record
        public static void Delete(ProfileInfo o, string user)
        {
            var result = from r in Db.ProfileInfos where r.Id == o.Id select r;
            Db.ProfileInfos.Remove(result.FirstOrDefault());
            Db.SaveChanges(user);

        }

    }
}
