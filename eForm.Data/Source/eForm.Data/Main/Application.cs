using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Data
{

    public class Application : BaseData
    {
        public string ApplicationId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public EndUserTypeEnum EndUserTypeEnum { get; set; }
        public ProductTypeEnum ProductTypeEnum { get; set; }
        public ApplicantTypeEnum ApplicantTypeEnum { get; set; }
        public ApplicationTypeEnum ApplicationTypeEnum { get; set; }
        public virtual List<Service> Services { get; set; }
        public virtual ProfileInfo Applicant { get; set; }
        public virtual ProfileInfo Agent { get; set; }
        public ApplicationState ApplicationState { get; set; }
        
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
            Services = new List<Service>();
            ApplicationState = Data.ApplicationState.Incomplete;

            ApplicationId = DateTime.Now.ToString("yyMMddHHmmssnfmy xmnbzmz");
        }
    }









}
