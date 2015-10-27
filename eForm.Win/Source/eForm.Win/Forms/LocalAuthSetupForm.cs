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
    public partial class LocalAuthSetupForm : Form
    {
        MainProcessForm _mp;
        public LocalAuthSetupForm(MainProcessForm mp)
        {
            _mp = mp;
            InitializeComponent();
        }

    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mp.ShowForm(FormType.LoginForm);
        }

        private void LocalAuthSetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _mp.ShowForm(FormType.LoginForm);

        }

        private void LocalAuthSetupForm_VisibleChanged(object sender, EventArgs e)
        {
            txtMyKadFullName.Text = "";
            txtMyKad.Text = "";
            txtDob.Text = "";
            txtGender.Text = "";
        }

        private void btnMyKad_Click(object sender, EventArgs e)
        {
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

            txtMyKadFullName.Text = f.ProfileInfo.FullName;
            txtMyKad.Text = f.ProfileInfo.IcNo;
           // txtDob.Text = f.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");
            txtGender.Text = f.ProfileInfo.Gender;

            //btnContinue.Enabled = true;
            //LocalAuthProcessingForm lapf = new LocalAuthProcessingForm(_mp, f.ProfileInfo);
            //lapf.ShowDialog();

            if (f.ProfileInfo == null)
            {
                MessageBox.Show("Auhtentication Failed");
                return;
            }

            _mp.UserProfile = f.ProfileInfo;
            _mp.ShowForm(FormType.DeviceRegistrationForm);

        }
    }
}
