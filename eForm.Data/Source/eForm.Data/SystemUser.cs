using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Data
{
    public class SystemUser : BaseData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ProfileId { get; set; }
        public virtual ProfileInfo ProfileInfo { get; set; }
    }
}
