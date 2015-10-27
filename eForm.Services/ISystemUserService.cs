using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Services
{
    public interface ISystemUserService : IService<Data.SystemUser>
    {
        Data.SystemUser GetByUserId(string p);
    }
}
