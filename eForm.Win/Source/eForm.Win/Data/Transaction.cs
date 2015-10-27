using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Data
{

    public class Application : BaseData
    {
        public DateTime RegistrationDate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public EndUserTypeEnum EndUserTypeEnum { get; set; }
        public ProductTypeEnum ProductTypeEnum { get; set; }
        public ApplicantTypeEnum ApplicantTypeEnum { get; set; }
        public ApplicationTypeEnum ApplicationTypeEnum { get; set; }
       // public List<Service> Services { get; set; }
        //public string RegistrationType { get; set; }
        //public string ProcessType { get; set; }
        public ProfileInfo Applicant { get; set; }
        public ProfileInfo Agent { get; set; }

        public Application()
        {
            Applicant = new ProfileInfo();
            Agent = new ProfileInfo();
            RegistrationDate = DateTime.Now;
            StartDateTime = DateTime.Now;
            EndDateTime = DateTime.Now;
            EndUserTypeEnum = Data.EndUserTypeEnum.Residential;
            ProductTypeEnum = Data.ProductTypeEnum.Unifi;
            ApplicantTypeEnum = Data.ApplicantTypeEnum.Malaysian;
            ApplicationTypeEnum = Data.ApplicationTypeEnum.NewRegistration;

        }
    }

    public enum EndUserTypeEnum
    {
        Residential,
        Business
    }

    public enum ProductTypeEnum
    {
        Unifi,
        Streamyx
    }

    public enum ApplicantTypeEnum
    {
        Malaysian,
        NonMalaysian,
        Oku,
        Tentera
    }

    public enum ApplicationTypeEnum
    {
        NewRegistration,
        Termination
    }
}
