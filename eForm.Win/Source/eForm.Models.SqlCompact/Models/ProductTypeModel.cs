using eForm.Win.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{
    public class ProductTypeModel : BaseModel<ProductTypeModel>
    {
        public static IEnumerable<ProductType> FindAll()
        {
            return Db.ProductTypes.AsEnumerable();
        }
        public static void Add(ProductType o, string user)
        {
            Db.ProductTypes.Add(o);
            Db.SaveChanges(user);
        }

        //Update record
        public static void Update(ProductType o, string user)
        {
            var result = from r in Db.ProductTypes where r.Id == o.Id select r;
            Db.SaveChanges(user);

        }
        //Delete record
        public static void Delete(ProductType o, string user)
        {
            var result = from r in Db.ProductTypes where r.Id == o.Id select r;
            Db.ProductTypes.Remove(result.FirstOrDefault());
            Db.SaveChanges(user);

        }

    }
}
