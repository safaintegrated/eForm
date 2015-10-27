using System.Collections.Generic;
using eForm.Data.Membership;

namespace eForm.Data.Device
{
    public class Machine: BaseEntity
    {
        public string Name { get; set; }

        public string MacAddress { get; set; }

        //foreign key
        public int AccountId { get; set; }


        //relationship
        public virtual Account Account { get; set; }

        public virtual ICollection<Device> Readers { get; set; } 
    }
}
