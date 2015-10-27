using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Services
{
    public interface IAuthenticateService
    {
        bool Authenticate(string userId, string password);

        void AddNewUserId(string userId);

        List<string> FindAllUserId();
    }
}
