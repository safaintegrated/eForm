using Microsoft.Reporting.WinForms;
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
    public partial class RegistrationSlipForm : Form
    {
        public RegistrationSlipForm()
        {
            InitializeComponent();
        }

        public Data.Application Trans { get; set; }
        public Data.ProfileInfo ProfileInfo { get; set; }

        private void RegistrationSlipForm_Load(object sender, EventArgs e)
        {
            TransactionBindingSource.Add(new Data.Application { RegistrationDate = DateTime.Now });
            this.reportViewer1.RefreshReport();
  
            reportViewer1.RefreshReport(); // refresh report
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
