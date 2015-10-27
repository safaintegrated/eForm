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
    public partial class MainForm : Form
    {
        MainProcessForm _mf;
        public MainForm(MainProcessForm mf)
        {
            _mf = mf;
            InitializeComponent();

            residentialTerminationUC1.Dock = DockStyle.Fill;
            residentialApplicationUC1.Dock = DockStyle.Fill;
            businessApplicationUC1.Dock = DockStyle.Fill;
        }

        private void nbtnResidentialTermination_Click(object sender, EventArgs e)
        {
       }

        private void nbtnResidentialRegistration_Click(object sender, EventArgs e)
        {
          //residentialTerminationUC1.Hide();
            //residentialApplicationUC1.Show();
        }

        private void nbtnBusinessTermination_Click(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Hide();

        }

        private void nbtnBusinessRegistration_Click(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Hide();
        }

        private void naviButton1_Activated(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Show();


        }

        private void naviButton2_Activated(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Hide();
        }

        private void btnResidentialRegistration_Click(object sender, EventArgs e)
        {
            residentialTerminationUC1.Hide();
            residentialApplicationUC1.Show();
            businessApplicationUC1.Hide();
   
        }

        private void btnResidentialTermination_Click(object sender, EventArgs e)
        {
            residentialTerminationUC1.Show();
            residentialApplicationUC1.Hide();
            businessApplicationUC1.Hide();
   
        }


 
    }
}
