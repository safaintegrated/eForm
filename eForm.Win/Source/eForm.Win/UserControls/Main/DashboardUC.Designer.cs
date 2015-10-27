namespace eForm.Win.UserControls
{
    partial class DashboardUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.latestRegistrationUC1 = new eForm.Win.UserControls.LatestRegistrationUC();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.salesSummaryUC1 = new eForm.Win.UserControls.SalesSummaryUC();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbtnSync = new eForm.Win.UserControls.SelectionButtonUC();
            this.sbtnStart = new eForm.Win.UserControls.SelectionButtonUC();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBarUC1 = new eForm.Win.UserControls.TitleBarUC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.latestRegistrationUC1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserFullName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 669);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // latestRegistrationUC1
            // 
            this.latestRegistrationUC1.BackColor = System.Drawing.Color.White;
            this.latestRegistrationUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latestRegistrationUC1.Location = new System.Drawing.Point(3, 352);
            this.latestRegistrationUC1.Name = "latestRegistrationUC1";
            this.latestRegistrationUC1.Size = new System.Drawing.Size(1069, 314);
            this.latestRegistrationUC1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.Controls.Add(this.salesSummaryUC1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1069, 313);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // salesSummaryUC1
            // 
            this.salesSummaryUC1.BackColor = System.Drawing.Color.White;
            this.salesSummaryUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesSummaryUC1.Location = new System.Drawing.Point(3, 3);
            this.salesSummaryUC1.Name = "salesSummaryUC1";
            this.salesSummaryUC1.Size = new System.Drawing.Size(943, 307);
            this.salesSummaryUC1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbtnSync);
            this.flowLayoutPanel1.Controls.Add(this.sbtnStart);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(952, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 307);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // cbtnSync
            // 
            this.cbtnSync.Code = null;
            this.cbtnSync.Location = new System.Drawing.Point(3, 3);
            this.cbtnSync.Name = "cbtnSync";
            this.cbtnSync.Size = new System.Drawing.Size(100, 100);
            this.cbtnSync.TabIndex = 0;
            this.cbtnSync.Title = "Synchronize";
            this.cbtnSync.ButtonClick += new System.EventHandler<System.EventArgs>(this.cbtnSync_ButtonClick);
            // 
            // sbtnStart
            // 
            this.sbtnStart.Code = null;
            this.sbtnStart.Location = new System.Drawing.Point(3, 109);
            this.sbtnStart.Name = "sbtnStart";
            this.sbtnStart.Size = new System.Drawing.Size(100, 100);
            this.sbtnStart.TabIndex = 1;
            this.sbtnStart.Title = "Start";
            this.sbtnStart.ButtonClick += new System.EventHandler<System.EventArgs>(this.sbtnStart_ButtonClick);
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUserFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.Location = new System.Drawing.Point(3, 0);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(441, 30);
            this.lblUserFullName.TabIndex = 4;
            this.lblUserFullName.Text = "Ahmad Abu Bin Bakar";
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleBarUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 60);
            this.panel1.TabIndex = 15;
            // 
            // titleBarUC1
            // 
            this.titleBarUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.titleBarUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarUC1.Location = new System.Drawing.Point(0, 0);
            this.titleBarUC1.Name = "titleBarUC1";
            this.titleBarUC1.Size = new System.Drawing.Size(1075, 60);
            this.titleBarUC1.TabIndex = 0;
            this.titleBarUC1.Title = "Dashboard";
            this.titleBarUC1.Load += new System.EventHandler(this.titleBarUC1_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 669);
            this.panel2.TabIndex = 16;
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(1075, 729);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TitleBarUC titleBarUC1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LatestRegistrationUC latestRegistrationUC1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private SalesSummaryUC salesSummaryUC1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SelectionButtonUC cbtnSync;
        private SelectionButtonUC sbtnStart;
        private System.Windows.Forms.Label lblUserFullName;
    }
}
