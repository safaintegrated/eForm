namespace eForm.Win.UserControls
{
    partial class SalesSummaryUC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.endUserTypeSegment1 = new eForm.Win.UserControls.EndUserTypeSegment();
            this.registrationToday1 = new eForm.Win.UserControls.RegistrationToday();
            this.productSalesSegment1 = new eForm.Win.UserControls.ProductSalesSegment();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 320);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.endUserTypeSegment1);
            this.panel3.Controls.Add(this.registrationToday1);
            this.panel3.Controls.Add(this.productSalesSegment1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 280);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // endUserTypeSegment1
            // 
            this.endUserTypeSegment1.Location = new System.Drawing.Point(519, 6);
            this.endUserTypeSegment1.Name = "endUserTypeSegment1";
            this.endUserTypeSegment1.Size = new System.Drawing.Size(250, 250);
            this.endUserTypeSegment1.TabIndex = 17;
            // 
            // registrationToday1
            // 
            this.registrationToday1.BackColor = System.Drawing.Color.White;
            this.registrationToday1.Location = new System.Drawing.Point(7, 6);
            this.registrationToday1.Name = "registrationToday1";
            this.registrationToday1.Size = new System.Drawing.Size(250, 250);
            this.registrationToday1.TabIndex = 16;
            // 
            // productSalesSegment1
            // 
            this.productSalesSegment1.Location = new System.Drawing.Point(263, 6);
            this.productSalesSegment1.Name = "productSalesSegment1";
            this.productSalesSegment1.Size = new System.Drawing.Size(250, 250);
            this.productSalesSegment1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 40);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Summary";
            // 
            // SalesSummaryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "SalesSummaryUC";
            this.Size = new System.Drawing.Size(779, 320);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private EndUserTypeSegment endUserTypeSegment1;
        private RegistrationToday registrationToday1;
        private ProductSalesSegment productSalesSegment1;
    }
}
