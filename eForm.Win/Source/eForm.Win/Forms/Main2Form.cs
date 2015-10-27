using eForm.Data;
using eForm.Data.SqlServerCompact;
using eForm.Services;
using eForm.Win.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class Main2Form : Form
    {
        MainProcessForm _mf;
        IApplicationService _applicationSvc;
        Dictionary<UserControlType, UserControl> _d = new Dictionary<UserControlType, UserControl>();
        public Data.Application Application { get; set; }
        public ProfileInfo UserProfile
        {
            get { return _mf.UserProfile; }
        }

        public Main2Form(MainProcessForm mf)
        {
            _mf = mf;
            InitializeData();
            InitializeComponent();
            productGroupUC1.MF = this;
            dashboardUC1.MF = this;
            applicantDetailsUC1.MF = this;
            InitializeUc();

            _applicationSvc = new ApplicationService(new eFormSqlCeContext());
            ShowForm(UserControlType.Dashboard);

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }


        private void InitializeData()
        {
            try
            {

                string dbSourceFile = "";
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    string dataPath = ApplicationDeployment.CurrentDeployment.DataDirectory;
                    dbSourceFile = Path.Combine(dataPath, "eForm.Win.sdf");
                }
                else
                {
                    string dataPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                    dbSourceFile = Path.Combine(dataPath, "eForm.Win.sdf");
                }

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userFilePath = Path.Combine(localAppData, "eForm");

                if (!Directory.Exists(userFilePath))
                    Directory.CreateDirectory(userFilePath);

                Constant.DatabasePath = Path.Combine(userFilePath, "eForm.Win.sdf");

                //TODO: temporary delete it first for development
                if (File.Exists(Constant.DatabasePath))
                    File.Delete(Constant.DatabasePath);


                if (!File.Exists(Constant.DatabasePath))
                {
                    File.Copy(dbSourceFile, Constant.DatabasePath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // MessageBox.Show("Check Database Exist :" + File.Exists(Constant.DatabasePath).ToString());
        }

        private void InitializeUc()
        {
            dashboardUC1.Dock = DockStyle.Fill;
            dashboardUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.Dashboard, dashboardUC1);

            productGroupUC1.Dock = DockStyle.Fill;
            productGroupUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.ProductGroup, productGroupUC1);

            applicantDetailsUC1.Dock = DockStyle.Fill;
            applicantDetailsUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.ApplicantDetails, applicantDetailsUC1);


            installationAndBillingUC1.Dock = DockStyle.Fill;
            installationAndBillingUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.InstallationAndBilling, installationAndBillingUC1);

            serviceDetailsUC1.Dock = DockStyle.Fill;
            serviceDetailsUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.ServiceDetails, serviceDetailsUC1);

            documentUploadUC1.Dock = DockStyle.Fill;
            documentUploadUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.DocumentUpload, documentUploadUC1);

            termAndConditionUC1.Dock = DockStyle.Fill;
            termAndConditionUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.TermAndCondition, termAndConditionUC1);

            latestApplicationUC1.Dock = DockStyle.Fill;
            latestApplicationUC1.ButtonClick += OnButtonClick;
            _d.Add(UserControlType.RecentApplication, latestApplicationUC1);

            incompleteApplicationUC1.Dock = DockStyle.Fill;
            // incompleteApplicationUC1.ButtonClick;

            _d.Add(UserControlType.IncompleteApplication, incompleteApplicationUC1);

            ApplicantTypeUC atUC = new ApplicantTypeUC();
            UpdateUcProperty(atUC);
            _d.Add(UserControlType.ApplicantType, atUC);


            InstallationDetailsUC idUc = new InstallationDetailsUC();
            UpdateUcProperty(idUc);
            _d.Add(UserControlType.InstallationDetail, idUc);

            BillingDetailsUC bdUc = new BillingDetailsUC();
            UpdateUcProperty(bdUc);
            _d.Add(UserControlType.BillingDetail, bdUc);


            UnifiMainDetailsUC a = new UnifiMainDetailsUC();
            UpdateUcProperty(a);
            _d.Add(UserControlType.UnifiMainDetails, a);

            UnifiCallPlanUC b = new UnifiCallPlanUC();
            UpdateUcProperty(b);
            _d.Add(UserControlType.UnifiCallPlan, b);

            UnifiHyppTVPlanUC c = new UnifiHyppTVPlanUC();
            UpdateUcProperty(c);
            _d.Add(UserControlType.UnifiHyppTv, c);

            UnifiOtherslPlanUC d = new UnifiOtherslPlanUC();
            UpdateUcProperty(d);
            _d.Add(UserControlType.UnifiOthersPlan, d);

        }

        private void UpdateUcProperty(BaseUserControl atUC)
        {
            panel1.Controls.Add(atUC);
            atUC.Dock = DockStyle.Fill;
            atUC.ButtonClick += OnButtonClick;
            atUC.MF = this;
        }

        void latestApplicationUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {

        }

        void OnButtonClick(object sender, ButtonClickEventArgs e)
        {
            switch (e.Type)
            {
                case ButtonType.UnifiOthersPlanCompleted:
                    ShowForm(UserControlType.DocumentUpload);
                    break;
                case ButtonType.UnifiHyppTvCompleted:
                    ShowForm(UserControlType.UnifiOthersPlan);
                    break;
                case ButtonType.UnifiCallPlanCompleted:
                    ShowForm(UserControlType.UnifiHyppTv);
                    break;
                case ButtonType.UnifiMainDetailsCompleted:
                    ShowForm(UserControlType.UnifiCallPlan);
                    break;
                case ButtonType.DocumentUploadCompleted:
                    ShowForm(UserControlType.TermAndCondition);
                    break;
                case ButtonType.ServicesCompleted:
                    ShowForm(UserControlType.DocumentUpload);
                    break;
                case ButtonType.BillingCompleted:
                    switch (Application.ProductTypeEnum)
                    {
                        case ProductTypeEnum.Unifi:
                            ShowForm(UserControlType.UnifiMainDetails);
                            break;
                        case ProductTypeEnum.Streamyx:
                            ShowForm(UserControlType.ServiceDetails);
                            break;
                    }
                    break;
                case ButtonType.ApplicationDetailCompleted:
                    ShowForm(UserControlType.InstallationDetail);
                    break;
                case ButtonType.InstallationDetailCompleted:
                    ShowForm(UserControlType.BillingDetail);
                    break;
                case ButtonType.BillingDetailCompleted:
                    ShowForm(UserControlType.ServiceDetails);
                    break;
                case ButtonType.ApplicantTypeSelected:
                    {
                        switch (Application.ApplicantTypeEnum)
                        {
                            case ApplicantTypeEnum.Malaysian:
                                ShowForm(UserControlType.ApplicantDetails);
                                break;
                            case ApplicantTypeEnum.NonMalaysian:
                                ShowForm(UserControlType.ApplicantDetails);
                                break;
                            case ApplicantTypeEnum.Oku:
                                ShowForm(UserControlType.ApplicantDetails);
                                //MessageBox.Show("Test");
                                break;
                            case ApplicantTypeEnum.Tentera:
                                ShowForm(UserControlType.ApplicantDetails);
                                //MessageBox.Show("Test");
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case ButtonType.Syncrhonize:
                    ProcessingForm pf = new ProcessingForm();
                    pf.Title = "Synchronization";
                    pf.Message = "Synchronization is in progress...";
                    pf.ShowDialog();
                    break;
                case ButtonType.Dashboard:
                    ShowForm(UserControlType.Dashboard);
                    break;
                case ButtonType.SaveTrans:
                    {
                        try
                        {
                            
                            //Models.ApplicationModel.Add(Application, UserProfile.IcNo);
                            _applicationSvc.Create(Application);
                            MessageBox.Show("Registration Success!");
                            RegistrationSlipForm rsf = new RegistrationSlipForm();
                            rsf.Trans = Application;
                            rsf.Show();
                            ShowForm(UserControlType.Dashboard);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Registration Failed! " + ex.Message);
                        }
                    }
                    break;
                case ButtonType.Start:
                    Application = new Data.Application();
                    ShowForm(UserControlType.ProductGroup);
                    break;
                case ButtonType.ApplicantType:
                    ShowForm(UserControlType.ApplicantType);
                    break;
                case ButtonType.RecentApplication:
                    ShowForm(UserControlType.RecentApplication);
                    break;
                case ButtonType.IncompleteApplication:
                    ShowForm(UserControlType.IncompleteApplication);
                    break;
                case ButtonType.MyPerformance:
                    MyPerformanceForm mpf = new MyPerformanceForm();
                    mpf.Show();
                    break;
                default:
                    break;
            }
            //switch (e.Type)
            //{
            //    case ButtonType.RecentApplication:
            //        ShowForm(UserControlType.RecentApplication);
            //        break;
            //    case ButtonType.IncompleteApplication:
            //        ShowForm(UserControlType.IncompleteApplication);
            //        break;
            //    default:
            //        ShowForm(UserControlType.ProductGroup);
            //        break;
            //}
        }


        //void dashboardUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{
        //    switch (e.Type)
        //    {
        //        case ButtonType.RecentApplication:
        //            ShowForm(UserControlType.RecentApplication);
        //            break;
        //        case ButtonType.IncompleteApplication:
        //            ShowForm(UserControlType.IncompleteApplication);
        //            break;
        //        default:
        //            ShowForm(UserControlType.ProductGroup);
        //            break;
        //    }
        //}

        //void termAndConditionUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{
        //    switch (e.Type)
        //    {
        //        case ButtonType.Dashboard:
        //            ShowForm(UserControlType.Dashboard);
        //            break;
        //        case ButtonType.Back:
        //            ShowForm(UserControlType.DocumentUpload);
        //            break;
        //        case ButtonType.Forward:
        //            break;
        //        case ButtonType.UnifiRegistration:
        //            break;
        //        case ButtonType.UnifiAdditionalService:
        //            break;
        //        case ButtonType.UnifiUpgrade:
        //            break;
        //        case ButtonType.UnifiRelocation:
        //            break;
        //        case ButtonType.UnifiTermination:
        //            break;
        //        case ButtonType.SaveTrans:
        //            {
        //                RegistrationSlipForm rsf = new RegistrationSlipForm();
        //                rsf.Trans = Trans;
        //                rsf.Show();
        //            }
        //            ShowForm(UserControlType.Dashboard);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //void documentUploadUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{
        //    switch (e.Type)
        //    {
        //        case ButtonType.Dashboard:
        //            break;
        //        case ButtonType.Back:
        //            ShowForm(UserControlType.ServiceDetails);
        //            break;
        //        case ButtonType.Forward:
        //            ShowForm(UserControlType.TermAndCondition);
        //            break;
        //        //case ButtonType.UnifiRegistration:
        //        //    break;
        //        //case ButtonType.UnifiAdditionalService:
        //        //    break;
        //        //case ButtonType.UnifiUpgrade:
        //        //    break;
        //        //case ButtonType.UnifiRelocation:
        //        //    break;
        //        //case ButtonType.UnifiTermination:
        //        //    break;
        //        default:
        //            break;
        //    }
        //}

        //void serviceDetailsUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{
        //    switch (e.Type)
        //    {
        //        case ButtonType.Dashboard:
        //            break;
        //        case ButtonType.Back:
        //            ShowForm(UserControlType.InstallationAndBilling);
        //            break;
        //        case ButtonType.Forward:
        //            ShowForm(UserControlType.DocumentUpload);
        //            break;
        //        case ButtonType.UnifiRegistration:
        //            break;
        //        case ButtonType.UnifiAdditionalService:
        //            break;
        //        case ButtonType.UnifiUpgrade:
        //            break;
        //        case ButtonType.UnifiRelocation:
        //            break;
        //        case ButtonType.UnifiTermination:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //void installationAndBillingUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{
        //    switch (e.Type)
        //    {
        //        case ButtonType.Dashboard:
        //            break;
        //        case ButtonType.Back:
        //            break;
        //        case ButtonType.Forward:
        //            ShowForm(UserControlType.ServiceDetails);
        //            break;
        //        case ButtonType.UnifiRegistration:
        //            break;
        //        case ButtonType.UnifiAdditionalService:
        //            break;
        //        case ButtonType.UnifiUpgrade:
        //            break;
        //        case ButtonType.UnifiRelocation:
        //            break;
        //        case ButtonType.UnifiTermination:
        //            break;
        //        default:
        //            break;
        //    }

        //}

        //void applicantDetailsUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{
        //    switch (e.Type)
        //    {
        //        case ButtonType.Dashboard:
        //            ShowForm(UserControlType.Dashboard);
        //            break;
        //        case ButtonType.Back:
        //            break;
        //        case ButtonType.Forward:

        //            ShowForm(UserControlType.InstallationAndBilling);
        //            break;
        //        case ButtonType.UnifiRegistration:
        //            break;
        //        case ButtonType.UnifiAdditionalService:
        //            break;
        //        case ButtonType.UnifiUpgrade:
        //            break;
        //        case ButtonType.UnifiRelocation:
        //            break;
        //        case ButtonType.UnifiTermination:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //void productGroupUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        //{

        //    switch (e.Type)
        //    {
        //        case ButtonType.ApplicationType:
        //            ShowForm(UserControlType.ApplicantDetails);
        //            break;
        //        case ButtonType.Dashboard:
        //            ShowForm(UserControlType.Dashboard);
        //            break;
        //        case ButtonType.Back:
        //            break;
        //        case ButtonType.Forward:
        //            break;
        //        //case ButtonType.UnifiRegistration:
        //        //    Trans.ProductCode = "UNIFI";
        //        //    Trans.ProcessType = "UnifiRegistration";
        //        //    ShowForm(UserControlType.ApplicantDetails);
        //        //    break;
        //        //case ButtonType.UnifiAdditionalService:
        //        //    Trans.ProductCode = "UNIFI";
        //        //    Trans.ProcessType = "UnifiAdditionalService";
        //        //    ShowForm(UserControlType.ApplicantDetails);
        //        //    break;
        //        //case ButtonType.UnifiUpgrade:
        //        //    Trans.ProductCode = "UNIFI";
        //        //    Trans.ProcessType = "UnifiUpgrade";
        //        //    ShowForm(UserControlType.ApplicantDetails);
        //        //    break;
        //        //case ButtonType.UnifiRelocation:
        //        //    Trans.ProductCode = "UNIFI";
        //        //    Trans.ProcessType = "UnifiRelocation";
        //        //    ShowForm(UserControlType.ApplicantDetails);
        //        //    break;
        //        //case ButtonType.UnifiTermination:
        //        //    Trans.ProductCode = "UNIFI";
        //        //    Trans.ProcessType = "UnifiTermination";
        //        //    ShowForm(UserControlType.ApplicantDetails);
        //        //    break;
        //        default:
        //            break;
        //    }
        //}

        //void dashboardUC1_ButtonResidentialClick(object sender, EventArgs e)
        //{
        //    Trans = new Transaction();
        //    Trans.RegistrationType = "RESIDENTIAL";
        //    ShowForm(UserControlType.ProductGroup);
        //}

        //void dashboardUC1_ButtonBusinessClick(object sender, EventArgs e)
        //{
        //    Trans = new Transaction();
        //    Trans.RegistrationType = "BUSINESS";
        //    ShowForm(UserControlType.ProductGroup);
        //}

        private void Main2Form_Load(object sender, EventArgs e)
        {
            ShowForm(UserControlType.Dashboard);
        }

        private void ShowForm(UserControlType uct)
        {
            HideAll();
            _d[uct].Show();
        }

        private void HideAll()
        {
            foreach (var uct in _d.Keys)
            {
                _d[uct].Hide();
            }
        }
    }

    public enum UserControlType
    {
        Dashboard,
        ProductGroup,
        ApplicantDetails,
        InstallationAndBilling,
        ServiceDetails,
        DocumentUpload,
        TermAndCondition,
        RecentApplication,
        IncompleteApplication,
        ApplicantType,
        InstallationDetail,
        BillingDetail,
        UnifiMainDetails,
        UnifiCallPlan,
        UnifiOthersPlan,
        UnifiHyppTv,
    }
}
