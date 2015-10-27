using System.Collections.Generic;

namespace eForm.Data
{
    public class ProductGroup: BaseEntity
    {
        public string Name { get; set; }

        //relationship
        public virtual ICollection<Product> Products { get; set; } 
    }
}
