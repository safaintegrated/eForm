using System.Collections.Generic;

namespace eForm.Data.Membership
{
    public class Role: BaseEntity
    {
        public string Name { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }
        
        public virtual ICollection<Privilege> Privileges { get; set; } 
    }
}
