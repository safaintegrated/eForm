using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace eForm.Win.Models
{

    public class BaseModel<T>
    {
        private static eFormContext _db;

        public static eFormContext Db
        {
            get
            {
                if (_db == null)
                {
                    //string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    //string userFilePath = Path.Combine(localAppData, "eFormDb");
                    //string _dbPath = Path.Combine(userFilePath, "DB\\eForm.Win.sdf");

                    _db = new eFormContext();
                } return _db;
            }

        }
    }
}
