using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Data
{
    public class ProfileInfo : BaseData
    {

        public string FullName { get; set; }

        public string UserId { get; set; }

        public string IcNo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public bool IsVerified { get; set; }

        public ProfileInfo()
        {
            if (DateOfBirth == DateTime.MinValue)
                DateOfBirth = new DateTime(1753, 1, 1);
        }

        public  string Citizenship { get; set; }

        public  string Address1 { get; set; }

        public  string Address2 { get; set; }

        public  string Address3 { get; set; }

        public  string Postcode { get; set; }

        public  string City { get; set; }

        public  string State { get; set; }

        //public  System.Drawing.Image? Image { get; set; }

        public string PhoneNo { get; set; }
    }
}
