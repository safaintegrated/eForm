using eForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Services
{
    public interface IWebApiService
    {
        /// <summary>
        /// For TM Point
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Authenticate(string userId, string password);

        //AcivationInfo ActivateUser(ProfileInfo pf, MachineInfo mi, ReaderInfo ri);
    }

    public class AcivationInfo
    {
        public string UserId { get; set; }

    }
}
