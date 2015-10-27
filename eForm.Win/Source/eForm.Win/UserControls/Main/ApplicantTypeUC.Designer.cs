namespace eForm.Win.UserControls
{
    partial class ApplicantTypeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel8 = new System.Windows.Forms.Panel();
            this.titleBarUC1 = new eForm.Win.UserControls.TitleBarUC();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtnMalaysian = new eForm.Win.UserControls.SelectionButtonUC();
            this.sbtnNonMalaysian = new eForm.Win.UserControls.SelectionButtonUC();
            this.sBtnOku = new eForm.Win.UserControls.SelectionButtonUC();
            this.sbtnTentera = new eForm.Win.UserControls.SelectionButtonUC();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.titleBarUC1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(981, 60);
            this.panel8.TabIndex = 15;
            // 
            // titleBarUC1
            // 
            this.titleBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.titleBarUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarUC1.Location = new System.Drawing.Point(0, 0);
            this.titleBarUC1.Name = "titleBarUC1";
            this.titleBarUC1.Size = new System.Drawing.Size(981, 60);
            this.titleBarUC1.TabIndex = 0;
            this.titleBarUC1.Title = "Applicant Type";
            this.titleBarUC1.ButtonClick += new System.EventHandler<eForm.Win.ButtonClickEventArgs>(this.titleBarUC1_ButtonClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(981, 649);
            this.panel9.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtnTentera);
            this.panel1.Controls.Add(this.sBtnOku);
            this.panel1.Controls.Add(this.sbtnNonMalaysian);
            this.panel1.Controls.Add(this.sbtnMalaysian);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 649);
            this.panel1.TabIndex = 1;
            // 
            // sbtnMalaysian
            // 
            this.sbtnMalaysian.Code = null;
            this.sbtnMalaysian.Location = new System.Drawing.Point(39, 50);
            this.sbtnMalaysian.Name = "sbtnMalaysian";
            this.sbtnMalaysian.Size = new System.Drawing.Size(100, 100);
            this.sbtnMalaysian.TabIndex = 0;
            this.sbtnMalaysian.Title = "Malaysian";
            this.sbtnMalaysian.ButtonClick += new System.EventHandler<System.EventArgs>(this.sbtnMalaysian_ButtonClick);
            // 
            // sbtnNonMalaysian
            // 
            this.sbtnNonMalaysian.Code = null;
            this.sbtnNonMalaysian.Location = new System.Drawing.Point(184, 50);
            this.sbtnNonMalaysian.Name = "sbtnNonMalaysian";
            this.sbtnNonMalaysian.Size = new System.Drawing.Size(100, 100);
            this.sbtnNonMalaysian.TabIndex = 1;
            this.sbtnNonMalaysian.Title = "Non Malaysian";
            this.sbtnNonMalaysian.ButtonClick += new System.EventHandler<System.EventArgs>(this.sbtnNonMalaysian_ButtonClick);
            // 
            // sBtnOku
            // 
            this.sBtnOku.Code = null;
            this.sBtnOku.Location = new System.Drawing.Point(320, 50);
            this.sBtnOku.Name = "sBtnOku";
            this.sBtnOku.Size = new System.Drawing.Size(100, 100);
            this.sBtnOku.TabIndex = 2;
            this.sBtnOku.Title = "OKU";
            this.sBtnOku.ButtonClick += new System.EventHandler<System.EventArgs>(this.sBtnOku_ButtonClick);
            // 
            // sbtnTentera
            // 
            this.sbtnTentera.Code = null;
            this.sbtnTentera.Location = new System.Drawing.Point(456, 50);
            this.sbtnTentera.Name = "sbtnTentera";
            this.sbtnTentera.Size = new System.Drawing.Size(100, 100);
            this.sbtnTentera.TabIndex = 3;
            this.sbtnTentera.Title = "Tentera";
            this.sbtnTentera.ButtonClick += new System.EventHandler<System.EventArgs>(this.sbtnTentera_ButtonClick);
            // 
            // ApplicantTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Name = "ApplicantTypeUC";
            this.Size = new System.Drawing.Size(981, 709);
            this.Load += new System.EventHandler(this.ProductGroupUC_Load);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private TitleBarUC titleBarUC1;
        private System.Windows.Forms.Panel panel1;
        private SelectionButtonUC sbtnMalaysian;
        private SelectionButtonUC sbtnTentera;
        private SelectionButtonUC sBtnOku;
        private SelectionButtonUC sbtnNonMalaysian;
    }
}
