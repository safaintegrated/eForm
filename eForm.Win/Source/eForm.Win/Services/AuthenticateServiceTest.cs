using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Services
{
    public class AuthenticateServiceTest : IAuthenticateService
    {
        public List<string> _userList;

        public AuthenticateServiceTest()
        {
            _userList = new List<string>();
            _userList.Add("111111");
            _userList.Add("222222");
            _userList.Add("333333");
        }

        public bool Authenticate(string userId, string password)
        {
            if (userId == password)
                return true;
            return false;
        }


        public void AddNewUserId(string userId)
        {
            _userList.Add(userId);
        }

        public List<string> FindAllUserId()
        {
            return _userList;
        }
    }
}
