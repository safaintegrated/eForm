using System.Collections.Generic;

namespace eForm.Data.Membership
{
    public class Privilege: BaseEntity
    {
        public string Code { get; set; }

        public string Description { get; set; }


        //relationships
        public virtual ICollection<Role> Roles { get; set; } 
    }
}
