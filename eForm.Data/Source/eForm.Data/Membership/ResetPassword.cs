using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Data.Membership
{
    public class ResetPassword: BaseEntity
    {

        public string Code { get; set; }

        public DateTime ExpiryDate { get; set; }

        //foreign key
        public int LoginId { get; set; }

        //relationships
        public virtual Login Login { get; set; }

    }
}
