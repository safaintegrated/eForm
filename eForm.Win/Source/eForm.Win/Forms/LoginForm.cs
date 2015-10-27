using eForm.Data.SqlServerCompact;
using eForm.Services;
using eForm.Win.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class LoginForm : Form
    {
        MainProcessForm _mp;
        ISystemUserService _systemUserSvc;
        IProfileInfoService _profileSvc;

        public LoginForm(MainProcessForm mp)
        {
            _mp = mp;
            InitializeComponent();

            _systemUserSvc = new SystemUserService(new eFormSqlCeContext());
            _profileSvc = new ProfileInfoService(new eFormSqlCeContext());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //var dr = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr != System.Windows.Forms.DialogResult.Yes)
            //    return;

            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbUserId.Text))
            {
                MessageBox.Show("Please select a User id", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please key in Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool isConnected = ConnectionService.CheckForInternetConnection();
            DeviceRegistrationProcessingForm lapf = new DeviceRegistrationProcessingForm(_mp);
            lapf.ShowDialog();

            if (isConnected)
            {
                bool result = _mp.AuthSvc.Authenticate(cbUserId.Text, txtPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Login failed. Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var user = _systemUserSvc.GetByUserId(cbUserId.Text);
                if (user == null)
                {
                    MessageBox.Show("Login failed. Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _mp.UserProfile = user.ProfileInfo;
            }
            else
            {
                if (MessageBox.Show("There is no connection with the server.\nClick Yes to continue with Offline verification.", "No Connection", MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }

                MyKadVerifcationForm f = new MyKadVerifcationForm();
                f.ShowDialog();
                if (f.ProfileInfo == null)
                {
                    MessageBox.Show("Verification Failed");
                    return;
                }
                if (!f.ProfileInfo.IsVerified)
                {
                    MessageBox.Show("Verification Failed");
                    return;
                }
                _mp.UserProfile = f.ProfileInfo;

            }

            _mp.ShowForm(FormType.MainForm);
            this.Hide();
        }

        private void btnCreateId_Click(object sender, EventArgs e)
        {
            _mp.ShowForm(FormType.TermAndConditionForm);
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            e.Cancel = false;
        }

        private void cbUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = cbUserId.Text;

            if (cbUserId.Text == "" || txtPassword.Text == "")
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbUserId.Text == "" || txtPassword.Text == "")
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;

        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            cbUserId.Items.Clear();
            var users = _systemUserSvc.FindAll();
            foreach (var u in users)
            {
                cbUserId.Items.Add(u.UserName);
            }

            cbUserId.SelectedIndex = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebApiTestForm f = new WebApiTestForm();
            f.Show();
        }
    }
}
