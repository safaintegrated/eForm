using eForm.Win.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class WebApiTestForm : Form
    {
        public WebApiTestForm()
        {
            InitializeComponent();
        }

        int name = 1;
        private void btnPushApplication_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Application p = new Data.Application();
                p.Applicant.FullName = "Ahmad " + name++.ToString();

                WebApiService was = new WebApiService();
                was.AddApplication(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGetAllApplication_Click(object sender, EventArgs e)
        {
            WebApiService was = new WebApiService();
            var apps = was.GetAllApplications();

            if (apps == null)
                MessageBox.Show("No record");
            else
                MessageBox.Show(apps.Count.ToString());
        }
    }
}
