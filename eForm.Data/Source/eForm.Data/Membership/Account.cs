using System.Collections.Generic;

namespace eForm.Data.Membership
{
    public class Account: BaseEntity
    {
        //profile
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        
        public string MyKad { get; set; }

        
        //relationship
        public virtual ICollection<Login> Logins { get; set; }

        public virtual ICollection<Role> Roles { get; set; } 
    }
}
