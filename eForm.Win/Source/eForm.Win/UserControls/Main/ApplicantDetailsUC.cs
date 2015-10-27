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
    public partial class ApplicantDetailsUC : BaseUserControl
    {

        public ApplicantDetailsUC()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
 
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            MyKadVerifcationForm f = new MyKadVerifcationForm();
            f.ShowDialog();
            if (f.ProfileInfo == null)
                return;

            if (!f.ProfileInfo.IsVerified)
                return;

            txtNameOfApplicant.Text = f.ProfileInfo.FullName;
            txtMyKad.Text = f.ProfileInfo.IcNo;
            txtDateOfBirth.Text = f.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");
            
            if (f.ProfileInfo.Gender.ToLower() == "male")
            {
                rbMale.Checked = true;
                //chkMale.Checked = true;
                //chkFemale.Checked = false;
            }
            else
            {
                rbFemale.Checked = true;
                //chkFemale.Checked = true;
                //chkMale.Checked = false;
            }
            //groupBox1.Enabled = true;
            //groupBox2.Enabled = true;
            //groupBox3.Enabled = true;

            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendButtonClick(new ButtonClickEventArgs( ButtonType.ApplicationDetailCompleted ));
        }

        //private void SendButtonClick(ButtonClickEventArgs e)
        //{
        //    if (ButtonClick != null)
        //        ButtonClick(this, e);
        //}

        private void titleBarUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            SendButtonClick(e);
        }

        private void rbMalaysian_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void UpdateControl()
        {
            //if(rbMalaysian.Checked)
            //{
            //    txtDateOfBirth.ReadOnly = true;
            //    txtNameOfApplicant.ReadOnly = true;
            //    txtPassportNo.Enabled = false;
            //    lblPassportNo.Enabled = false;

            //    txtMyKad.Enabled = true;
            //    lblMyKad.Enabled = true;

            //    btnNew.Enabled = true;
               
            //}
            //else
            //{

            //    txtDateOfBirth.ReadOnly = false;
            //    txtNameOfApplicant.ReadOnly = false;
            //    txtPassportNo.Enabled = true;
            //    lblPassportNo.Enabled = true;

            //    txtMyKad.Enabled = false;
            //    lblMyKad.Enabled = false;
            //    btnNew.Enabled = false;
            //    btnNext.Enabled = true;
            //}
        }

        private void rbNonMalaysian_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplicantDetailsUC_VisibleChanged(object sender, EventArgs e)
        {
            //if (!Visible)
            //    return;

            //switch (MF.Trans.ApplicantTypeEnum)
            //{
            //    case eForm.Data.ApplicantTypeEnum.Malaysian:
            //        rbMalaysian.Checked = true;
            //        break;
            //    case eForm.Data.ApplicantTypeEnum.NonMalaysian:
            //        rbNonMalaysian.Checked = true;
            //        break;
            //    case eForm.Data.ApplicantTypeEnum.Oku:
            //        rbOku.Checked = true;
            //        break;
            //    case eForm.Data.ApplicantTypeEnum.Tentera:
            //        rbTentera.Checked = true;
            //        break;
            //    default:
            //        break;
            //}

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMalaysian_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click_2(object sender, EventArgs e)
        {
            MyKadVerifcationForm f = new MyKadVerifcationForm();
            f.ShowDialog();
            if (f.ProfileInfo == null)
                return;

            if (!f.ProfileInfo.IsVerified)
                return;

            txtNameOfApplicant.Text = f.ProfileInfo.FullName;
            txtMyKad.Text = f.ProfileInfo.IcNo;
            txtDateOfBirth.Text = f.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");

            if (f.ProfileInfo.Gender.ToLower() == "male")
            {
                rbMale.Checked = true;
                //chkMale.Checked = true;
                //chkFemale.Checked = false;
            }
            else
            {
                rbFemale.Checked = true;
                //chkFemale.Checked = true;
                //chkMale.Checked = false;
            }

            MF.Application.Applicant = f.ProfileInfo;
            //groupBox1.Enabled = true;
            //groupBox2.Enabled = true;
            //groupBox3.Enabled = true;

            btnNext.Enabled = true;
        }

    }
}
