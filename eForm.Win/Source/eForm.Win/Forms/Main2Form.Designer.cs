namespace eForm.Win.Forms
{
    partial class Main2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.incompleteApplicationUC1 = new eForm.Win.UserControls.IncompleteApplicationUC();
            this.latestApplicationUC1 = new eForm.Win.UserControls.LatestApplicationUC();
            this.productGroupUC1 = new eForm.Win.UserControls.ProductGroupUC();
            this.dashboardUC1 = new eForm.Win.UserControls.DashboardUC();
            this.termAndConditionUC1 = new eForm.Win.UserControls.TermAndConditionUC();
            this.documentUploadUC1 = new eForm.Win.UserControls.DocumentUploadUC();
            this.serviceDetailsUC1 = new eForm.Win.UserControls.ServiceDetailsUC();
            this.installationAndBillingUC1 = new eForm.Win.UserControls.InstallationAndBillingUC();
            this.applicantDetailsUC1 = new eForm.Win.UserControls.ApplicantDetailsUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.incompleteApplicationUC1);
            this.panel1.Controls.Add(this.latestApplicationUC1);
            this.panel1.Controls.Add(this.productGroupUC1);
            this.panel1.Controls.Add(this.dashboardUC1);
            this.panel1.Controls.Add(this.termAndConditionUC1);
            this.panel1.Controls.Add(this.documentUploadUC1);
            this.panel1.Controls.Add(this.serviceDetailsUC1);
            this.panel1.Controls.Add(this.installationAndBillingUC1);
            this.panel1.Controls.Add(this.applicantDetailsUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 658);
            this.panel1.TabIndex = 9;
            // 
            // incompleteApplicationUC1
            // 
            this.incompleteApplicationUC1.Location = new System.Drawing.Point(12, 24);
            this.incompleteApplicationUC1.Name = "incompleteApplicationUC1";
            this.incompleteApplicationUC1.Size = new System.Drawing.Size(902, 729);
            this.incompleteApplicationUC1.TabIndex = 10;
            // 
            // latestApplicationUC1
            // 
            this.latestApplicationUC1.Location = new System.Drawing.Point(78, 90);
            this.latestApplicationUC1.Name = "latestApplicationUC1";
            this.latestApplicationUC1.Size = new System.Drawing.Size(902, 729);
            this.latestApplicationUC1.TabIndex = 9;
            // 
            // productGroupUC1
            // 
            this.productGroupUC1.Location = new System.Drawing.Point(521, 34);
            this.productGroupUC1.MF = null;
            this.productGroupUC1.Name = "productGroupUC1";
            this.productGroupUC1.Size = new System.Drawing.Size(766, 560);
            this.productGroupUC1.TabIndex = 8;
            // 
            // dashboardUC1
            // 
            this.dashboardUC1.BackColor = System.Drawing.Color.White;
            this.dashboardUC1.Location = new System.Drawing.Point(637, 3);
            this.dashboardUC1.MF = null;
            this.dashboardUC1.Name = "dashboardUC1";
            this.dashboardUC1.Size = new System.Drawing.Size(902, 729);
            this.dashboardUC1.TabIndex = 7;
            // 
            // termAndConditionUC1
            // 
            this.termAndConditionUC1.Location = new System.Drawing.Point(296, 113);
            this.termAndConditionUC1.Name = "termAndConditionUC1";
            this.termAndConditionUC1.Size = new System.Drawing.Size(891, 555);
            this.termAndConditionUC1.TabIndex = 6;
            // 
            // documentUploadUC1
            // 
            this.documentUploadUC1.Location = new System.Drawing.Point(434, 73);
            this.documentUploadUC1.Name = "documentUploadUC1";
            this.documentUploadUC1.Size = new System.Drawing.Size(937, 506);
            this.documentUploadUC1.TabIndex = 5;
            // 
            // serviceDetailsUC1
            // 
            this.serviceDetailsUC1.Location = new System.Drawing.Point(166, 184);
            this.serviceDetailsUC1.Name = "serviceDetailsUC1";
            this.serviceDetailsUC1.Size = new System.Drawing.Size(1098, 587);
            this.serviceDetailsUC1.TabIndex = 4;
            // 
            // installationAndBillingUC1
            // 
            this.installationAndBillingUC1.Location = new System.Drawing.Point(57, 285);
            this.installationAndBillingUC1.Name = "installationAndBillingUC1";
            this.installationAndBillingUC1.Size = new System.Drawing.Size(1087, 763);
            this.installationAndBillingUC1.TabIndex = 3;
            // 
            // applicantDetailsUC1
            // 
            this.applicantDetailsUC1.Location = new System.Drawing.Point(276, 184);
            this.applicantDetailsUC1.Name = "applicantDetailsUC1";
            this.applicantDetailsUC1.Size = new System.Drawing.Size(988, 444);
            this.applicantDetailsUC1.TabIndex = 2;
 
            // 
            // Main2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
           this.Name = "Main2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM eForm";
            this.Load += new System.EventHandler(this.Main2Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControls.ApplicantDetailsUC applicantDetailsUC1;
        private UserControls.InstallationAndBillingUC installationAndBillingUC1;
        private UserControls.ServiceDetailsUC serviceDetailsUC1;
        private UserControls.DocumentUploadUC documentUploadUC1;
        private UserControls.TermAndConditionUC termAndConditionUC1;
        private UserControls.DashboardUC dashboardUC1;
        private UserControls.IncompleteApplicationUC incompleteApplicationUC1;
        private UserControls.LatestApplicationUC latestApplicationUC1;
        private UserControls.ProductGroupUC productGroupUC1;
    }
}