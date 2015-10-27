using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class ApplicationUpdateForm : Form
    {
        public ApplicationUpdateForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        private void CheckForUpdates()
        {
            if (!ApplicationDeployment.IsNetworkDeployed)
            {
                MessageBox.Show("This application is not running in ClickOnce infra. \nNo update is available.");
                return;
            }

            ApplicationDeployment currentDeploy = ApplicationDeployment.CurrentDeployment;

            if (currentDeploy.CheckForUpdate())
            {

                //TODO: ensure all the data is syncronized before update
                //TODO: use different thread for update
                //currentDeploy.Update();

                currentDeploy.CheckForUpdateCompleted += currentDeploy_CheckForUpdateCompleted;
                currentDeploy.CheckForUpdateProgressChanged += currentDeploy_CheckForUpdateProgressChanged;
                currentDeploy.UpdateCompleted += currentDeploy_UpdateCompleted;

                DialogResult dr = MessageBox.Show("Update downloaded, restart application?", "Application Update", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void currentDeploy_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Update downloaded, restart application?", "Application Update", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        private void currentDeploy_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("-------------");
            listBox1.Items.Add("Deployment State: " + e.State.ToString());
            listBox1.Items.Add("Deployment progress: " +
            e.ProgressPercentage.ToString() + "%");
            listBox1.Items.Add("Bytes received: " + e.BytesCompleted.ToString());
            listBox1.Items.Add("Bytes to go: " +
            (e.BytesTotal - e.BytesCompleted).ToString());
            listBox1.Items.Add("-------------");
        }

        private void currentDeploy_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {
            if (e.UpdateAvailable)
            {
                ApplicationDeployment current = ApplicationDeployment.CurrentDeployment;
                current.UpdateAsync();
            }
        }

        private void btnCheckForUpdate_Click(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                // Get a reference to the current deployment
                ApplicationDeployment current =
                ApplicationDeployment.CurrentDeployment;
                UpdateCheckInfo uci = current.CheckForDetailedUpdate();
                if (uci.UpdateAvailable)
                {
                    //updateCheckInfoBindingSource.DataSource = uci;
                }
                else
                {
                    //updateAvailableCheckBox.Checked = false;
                }
            }
        }

    }
}
