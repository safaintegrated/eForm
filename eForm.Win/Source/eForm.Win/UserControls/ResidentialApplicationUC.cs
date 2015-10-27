using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eForm.Win.Forms;

namespace eForm.Win.UserControls
{
    public partial class ResidentialApplicationUC : UserControl
    {
        public ResidentialApplicationUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblFixedLineRelocation_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblFixedLineInstallation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOwnerShipMyKad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMyKadCurrentOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMyKadCurrentOwner_Click(object sender, EventArgs e)
        {

        }

        private void gbChangeOwnership_Enter(object sender, EventArgs e)
        {

        }

        private void lblNameCurrentOwner_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentOwner_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
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

            txtNameOfApplicant.Text = f.ProfileInfo.FullName;
            txtMyKad.Text = f.ProfileInfo.IcNo;
           // txtDateOfBirth.Text = f.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");
            if (f.ProfileInfo.Gender.ToLower() == "male")
            {
                chkMale.Checked = true;
                chkFemale.Checked = false  ;
            }
            else
            {
                chkFemale.Checked = true;
                chkMale.Checked = false;
            }
            //groupBox1.Enabled = true;
            //groupBox2.Enabled = true;
            //groupBox3.Enabled = true;

            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Submitted");
            btnSave.Enabled = false;

        }
    }
}
