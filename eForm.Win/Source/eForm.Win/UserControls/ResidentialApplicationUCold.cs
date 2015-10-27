using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eForm.Win.Forms;

namespace eForm.Win
{
    public partial class ResidentialApplicationUCold : UserControl
    {
        public ResidentialApplicationUCold()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MyKadVerifcationForm f = new MyKadVerifcationForm();
            f.ShowDialog();
            if (f.ProfileInfo == null)
                return;

            if (!f.ProfileInfo.IsVerified)
                return;

            txtFullName.Text = f.ProfileInfo.FullName;
            txtMyKad.Text = f.ProfileInfo.IcNo;
            //txtDob.Text = f.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");
            txtGender.Text = f.ProfileInfo.Gender;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Submitted");
            btnSave.Enabled = false;
        }
    }
}
