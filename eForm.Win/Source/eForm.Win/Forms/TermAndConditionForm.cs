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
    public partial class TermAndConditionForm : Form
    {
        MainProcessForm _mp;
        public bool IsContinue { get; set; }
        
        public TermAndConditionForm(MainProcessForm mp)
        {
            _mp = mp;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsContinue = false;

            if (_mp.SoftwareType == SoftwareType.TmPoint)
                _mp.ShowForm(FormType.LoginForm);
            else
                _mp.ShowForm(FormType.LoginFormAgent);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!chkIsAgree.Checked)
            {
                MessageBox.Show("Please tick the Term & Condition agreement");
                return;
            }

            IsContinue = true;
            _mp.ShowForm(FormType.LocalAuthSetupForm);
        }

        private void TermAndConditionForm_Load(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = true;
            webBrowser1.Navigate("https://www.tm.com.my/Home/Broadband/unifi/terms/Pages/TermsConditionsOffice.aspx");
        }

        private void chkIsAgree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "Navigating";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = e.Url.ToString() + " loaded";
        }

        private void TermAndConditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (_mp.SoftwareType == SoftwareType.TmPoint)
                _mp.ShowForm(FormType.LoginForm);
            else
                _mp.ShowForm(FormType.LoginFormAgent);
        }

        private void TermAndConditionForm_VisibleChanged(object sender, EventArgs e)
        {
            chkIsAgree.Checked = false;
        }
    }
}
