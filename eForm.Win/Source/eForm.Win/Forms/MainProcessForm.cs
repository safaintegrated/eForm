using eForm.Data;
using eForm.Win.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class MainProcessForm : Form
    {
        public ProfileInfo UserProfile { get; set; }
        //public ProfileInfo ProfileInfo { get; set; }
        public IAuthenticateService AuthSvc { get; set; }
        private Dictionary<FormType, Form> _formList;
        private Form _currentForm;
        private FormType _currentFormType;
        public SoftwareType SoftwareType {get;set;}

        public MyKadService MyKad { get; set; }

        public MainProcessForm()
        {
            InitializeComponent();
            InitializeService();
            InitalizeSoftwareType();
            MyKad = new MyKadService();
        }

        private void InitalizeSoftwareType()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "eForm");

            if (!Directory.Exists(userFilePath))
                Directory.CreateDirectory(userFilePath);

            string softwareType = Path.Combine(userFilePath, "SoftwareType.txt");

            if (!File.Exists(softwareType))
                File.WriteAllText(softwareType, "TMPOINT");

            if (File.ReadAllText(softwareType).ToUpper() == "TMPOINT")
                SoftwareType = SoftwareType.TmPoint;
            else
                SoftwareType = SoftwareType.Agent;
        }


        private void InitializeForms()
        {
            _formList = new Dictionary<FormType, Form>();
            _formList.Add(FormType.LoginForm, new LoginForm(this));
            _formList.Add(FormType.LoginFormAgent, new LoginFormAgent(this));
            //_formList.Add(FormType.MainForm, new MainForm(this));
            _formList.Add(FormType.MainForm, new Main2Form(this));
            _formList.Add(FormType.DeviceRegistrationForm, new DeviceRegistrationForm(this));
            _formList.Add(FormType.LocalAuthSetupForm, new LocalAuthSetupForm(this));
            _formList.Add(FormType.TermAndConditionForm, new TermAndConditionForm(this));
        }

        private void InitializeService()
        {
            AuthSvc = new AuthenticateServiceTest();
        }

        private void MainProcessForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            InitializeForms();
            if (SoftwareType == SoftwareType.TmPoint)
                ShowForm(FormType.LoginForm);
            else
                ShowForm(FormType.LoginFormAgent);
        }

        public void ShowForm(FormType formType)
        {
            if (_currentForm != null)
                _currentForm.Hide();


            _currentFormType = formType;
            _currentForm = _formList[formType];
            _currentForm.FormClosed += _currentForm_FormClosed;

            _currentForm.Show();
        }

        void _currentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (_currentFormType)
            {
                case FormType.LoginFormAgent:
                case FormType.LoginForm:
                case FormType.MainForm:
                    //MessageBox.Show("MainProcessForm Closing");
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void MainProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MainProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var f in _formList.Keys)
            {
                if (_formList[f] != null)
                _formList[f].Dispose();
            }

        }
    }

    public enum FormType
    {
        LoginForm,
        MainForm,
        TermAndConditionForm,
        DeviceRegistrationForm,
        LocalAuthSetupForm,
        LoginFormAgent,
    }
}
