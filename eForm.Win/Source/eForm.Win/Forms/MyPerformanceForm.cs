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
    public partial class MyPerformanceForm : Form
    {
        public MyPerformanceForm()
        {
            InitializeComponent();
        }

        private void MyPerformanceForm_Load(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = true;
            webBrowser1.Navigate("https://www.tm.com.my/Home/Broadband/unifi/terms/Pages/TermsConditionsOffice.aspx");
        }
    }
}
