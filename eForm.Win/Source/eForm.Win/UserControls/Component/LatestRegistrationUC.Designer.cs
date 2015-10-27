namespace eForm.Win.UserControls
{
    partial class LatestRegistrationUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.recentApplicationUC1 = new eForm.Win.UserControls.RecentApplicationUC();
            this.incompletApplicationUC1 = new eForm.Win.UserControls.IncompletApplicationUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(739, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Previous Application";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 240);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.recentApplicationUC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.incompletApplicationUC1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 240);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // recentApplicationUC1
            // 
            this.recentApplicationUC1.BackColor = System.Drawing.Color.White;
            this.recentApplicationUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentApplicationUC1.Location = new System.Drawing.Point(3, 3);
            this.recentApplicationUC1.Name = "recentApplicationUC1";
            this.recentApplicationUC1.Size = new System.Drawing.Size(363, 234);
            this.recentApplicationUC1.TabIndex = 0;
            this.recentApplicationUC1.ButtonClick += new System.EventHandler<eForm.Win.ButtonClickEventArgs>(this.recentApplicationUC1_ButtonClick);
            // 
            // incompletApplicationUC1
            // 
            this.incompletApplicationUC1.BackColor = System.Drawing.Color.White;
            this.incompletApplicationUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incompletApplicationUC1.Location = new System.Drawing.Point(372, 3);
            this.incompletApplicationUC1.Name = "incompletApplicationUC1";
            this.incompletApplicationUC1.Size = new System.Drawing.Size(364, 234);
            this.incompletApplicationUC1.TabIndex = 1;
            this.incompletApplicationUC1.ButtonClick += new System.EventHandler<eForm.Win.ButtonClickEventArgs>(this.incompletApplicationUC1_ButtonClick);
            // 
            // LatestRegistrationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LatestRegistrationUC";
            this.Size = new System.Drawing.Size(739, 280);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RecentApplicationUC recentApplicationUC1;
        private IncompletApplicationUC incompletApplicationUC1;
    }
}
