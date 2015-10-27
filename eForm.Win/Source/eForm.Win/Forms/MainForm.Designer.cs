namespace eForm.Win.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.naviBar1 = new Guifreaks.NavigationBar.NaviBar(this.components);
            this.naviBand4 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand3 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand1 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviGroup1 = new Guifreaks.NavigationBar.NaviGroup(this.components);
            this.naviBand2 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand5 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.naviGroup2 = new Guifreaks.NavigationBar.NaviGroup(this.components);
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnTermination = new System.Windows.Forms.Button();
            this.businessApplicationUC1 = new eForm.Win.UserControls.BusinessApplicationUC();
            this.residentialApplicationUC1 = new eForm.Win.UserControls.ResidentialApplicationUC();
            this.residentialTerminationUC1 = new eForm.Win.UserControls.ResidentialTerminationUC();
            this.btnResidentialRegistration = new System.Windows.Forms.Button();
            this.btnResidentialTermination = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).BeginInit();
            this.naviBar1.SuspendLayout();
            this.naviBand4.ClientArea.SuspendLayout();
            this.naviBand4.SuspendLayout();
            this.naviBand3.ClientArea.SuspendLayout();
            this.naviBand3.SuspendLayout();
            this.naviBand1.ClientArea.SuspendLayout();
            this.naviBand1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup1)).BeginInit();
            this.naviBand2.SuspendLayout();
            this.naviBand5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup2)).BeginInit();
            this.naviGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviBar1
            // 
            this.naviBar1.ActiveBand = this.naviBand3;
            this.naviBar1.Controls.Add(this.naviBand3);
            this.naviBar1.Controls.Add(this.naviBand4);
            this.naviBar1.Controls.Add(this.naviBand1);
            this.naviBar1.Controls.Add(this.naviBand2);
            this.naviBar1.Controls.Add(this.naviBand5);
            this.naviBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.naviBar1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviBar1.Location = new System.Drawing.Point(0, 0);
            this.naviBar1.Name = "naviBar1";
            this.naviBar1.Size = new System.Drawing.Size(226, 423);
            this.naviBar1.TabIndex = 0;
            this.naviBar1.Text = "naviBar1";
            this.naviBar1.VisibleLargeButtons = 5;
            // 
            // naviBand4
            // 
            // 
            // naviBand4.ClientArea
            // 
            this.naviBand4.ClientArea.Controls.Add(this.btnTermination);
            this.naviBand4.ClientArea.Controls.Add(this.btnRegistration);
            this.naviBand4.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand4.ClientArea.Name = "ClientArea";
            this.naviBand4.ClientArea.Size = new System.Drawing.Size(224, 196);
            this.naviBand4.ClientArea.TabIndex = 0;
            this.naviBand4.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviBand4.Location = new System.Drawing.Point(1, 27);
            this.naviBand4.Name = "naviBand4";
            this.naviBand4.Size = new System.Drawing.Size(224, 196);
            this.naviBand4.SmallImage = global::eForm.Win.Properties.Resources.servers1;
            this.naviBand4.TabIndex = 9;
            this.naviBand4.Text = "Business Forms";
            // 
            // naviBand3
            // 
            // 
            // naviBand3.ClientArea
            // 
            this.naviBand3.ClientArea.Controls.Add(this.btnResidentialTermination);
            this.naviBand3.ClientArea.Controls.Add(this.btnResidentialRegistration);
            this.naviBand3.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand3.ClientArea.Name = "ClientArea";
            this.naviBand3.ClientArea.Size = new System.Drawing.Size(224, 196);
            this.naviBand3.ClientArea.TabIndex = 0;
            this.naviBand3.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviBand3.Location = new System.Drawing.Point(1, 27);
            this.naviBand3.Name = "naviBand3";
            this.naviBand3.Size = new System.Drawing.Size(224, 196);
            this.naviBand3.SmallImage = global::eForm.Win.Properties.Resources.screen80;
            this.naviBand3.TabIndex = 7;
            this.naviBand3.Text = "Residential Forms";
            // 
            // naviBand1
            // 
            // 
            // naviBand1.ClientArea
            // 
            this.naviBand1.ClientArea.Controls.Add(this.naviGroup1);
            this.naviBand1.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand1.ClientArea.Name = "ClientArea";
            this.naviBand1.ClientArea.Size = new System.Drawing.Size(224, 196);
            this.naviBand1.ClientArea.TabIndex = 0;
            this.naviBand1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviBand1.Location = new System.Drawing.Point(1, 27);
            this.naviBand1.Name = "naviBand1";
            this.naviBand1.Size = new System.Drawing.Size(224, 196);
            this.naviBand1.SmallImage = global::eForm.Win.Properties.Resources.touch_screen_phone1;
            this.naviBand1.TabIndex = 3;
            this.naviBand1.Text = "Notification & Alerts";
            // 
            // naviGroup1
            // 
            this.naviGroup1.Caption = null;
            this.naviGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviGroup1.Expanded = false;
            this.naviGroup1.HeaderContextMenuStrip = null;
            this.naviGroup1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviGroup1.Location = new System.Drawing.Point(0, 0);
            this.naviGroup1.Name = "naviGroup1";
            this.naviGroup1.Padding = new System.Windows.Forms.Padding(1, 22, 1, 1);
            this.naviGroup1.Size = new System.Drawing.Size(224, 196);
            this.naviGroup1.TabIndex = 0;
            this.naviGroup1.Text = "naviGroup1";
            // 
            // naviBand2
            // 
            // 
            // naviBand2.ClientArea
            // 
            this.naviBand2.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand2.ClientArea.Name = "ClientArea";
            this.naviBand2.ClientArea.Size = new System.Drawing.Size(224, 196);
            this.naviBand2.ClientArea.TabIndex = 0;
            this.naviBand2.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviBand2.Location = new System.Drawing.Point(1, 27);
            this.naviBand2.Name = "naviBand2";
            this.naviBand2.Size = new System.Drawing.Size(224, 196);
            this.naviBand2.SmallImage = global::eForm.Win.Properties.Resources.lightbulb24;
            this.naviBand2.TabIndex = 5;
            this.naviBand2.Text = "MyKad Verification";
            // 
            // naviBand5
            // 
            // 
            // naviBand5.ClientArea
            // 
            this.naviBand5.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand5.ClientArea.Name = "ClientArea";
            this.naviBand5.ClientArea.Size = new System.Drawing.Size(224, 196);
            this.naviBand5.ClientArea.TabIndex = 0;
            this.naviBand5.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviBand5.Location = new System.Drawing.Point(1, 27);
            this.naviBand5.Name = "naviBand5";
            this.naviBand5.Size = new System.Drawing.Size(224, 196);
            this.naviBand5.SmallImage = global::eForm.Win.Properties.Resources.smartphone54;
            this.naviBand5.TabIndex = 11;
            this.naviBand5.Text = "My Profile";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "29 Aug 2015, 10:45 AM";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "Synchronizing";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Synchronize";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton2.Text = "Logout";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel2.Text = "Fakhrul Azran";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.naviGroup2);
            this.panel1.Controls.Add(this.naviBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 423);
            this.panel1.TabIndex = 5;
            // 
            // naviGroup2
            // 
            this.naviGroup2.Caption = "";
            this.naviGroup2.Controls.Add(this.businessApplicationUC1);
            this.naviGroup2.Controls.Add(this.residentialApplicationUC1);
            this.naviGroup2.Controls.Add(this.residentialTerminationUC1);
            this.naviGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviGroup2.Expanded = false;
            this.naviGroup2.HeaderContextMenuStrip = null;
            this.naviGroup2.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Black;
            this.naviGroup2.Location = new System.Drawing.Point(226, 0);
            this.naviGroup2.Name = "naviGroup2";
            this.naviGroup2.Padding = new System.Windows.Forms.Padding(1, 22, 1, 1);
            this.naviGroup2.Size = new System.Drawing.Size(505, 423);
            this.naviGroup2.TabIndex = 1;
            this.naviGroup2.Text = "naviGroup2";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistration.Location = new System.Drawing.Point(0, 0);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(224, 23);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTermination
            // 
            this.btnTermination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTermination.Location = new System.Drawing.Point(0, 23);
            this.btnTermination.Name = "btnTermination";
            this.btnTermination.Size = new System.Drawing.Size(224, 23);
            this.btnTermination.TabIndex = 1;
            this.btnTermination.Text = "Termination";
            this.btnTermination.UseVisualStyleBackColor = true;
            this.btnTermination.Click += new System.EventHandler(this.button2_Click);
            // 
            // businessApplicationUC1
            // 
            this.businessApplicationUC1.Location = new System.Drawing.Point(74, 148);
            this.businessApplicationUC1.Name = "businessApplicationUC1";
            this.businessApplicationUC1.Size = new System.Drawing.Size(1096, 2515);
            this.businessApplicationUC1.TabIndex = 2;
            // 
            // residentialApplicationUC1
            // 
            this.residentialApplicationUC1.Location = new System.Drawing.Point(170, 118);
            this.residentialApplicationUC1.Name = "residentialApplicationUC1";
            this.residentialApplicationUC1.Size = new System.Drawing.Size(1007, 1965);
            this.residentialApplicationUC1.TabIndex = 1;
            // 
            // residentialTerminationUC1
            // 
            this.residentialTerminationUC1.Location = new System.Drawing.Point(266, 58);
            this.residentialTerminationUC1.Name = "residentialTerminationUC1";
            this.residentialTerminationUC1.Size = new System.Drawing.Size(1107, 340);
            this.residentialTerminationUC1.TabIndex = 0;
            // 
            // btnResidentialRegistration
            // 
            this.btnResidentialRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResidentialRegistration.Location = new System.Drawing.Point(0, 0);
            this.btnResidentialRegistration.Name = "btnResidentialRegistration";
            this.btnResidentialRegistration.Size = new System.Drawing.Size(224, 23);
            this.btnResidentialRegistration.TabIndex = 0;
            this.btnResidentialRegistration.Text = "Registration";
            this.btnResidentialRegistration.UseVisualStyleBackColor = true;
            this.btnResidentialRegistration.Click += new System.EventHandler(this.btnResidentialRegistration_Click);
            // 
            // btnResidentialTermination
            // 
            this.btnResidentialTermination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResidentialTermination.Location = new System.Drawing.Point(0, 23);
            this.btnResidentialTermination.Name = "btnResidentialTermination";
            this.btnResidentialTermination.Size = new System.Drawing.Size(224, 23);
            this.btnResidentialTermination.TabIndex = 1;
            this.btnResidentialTermination.Text = "Termination";
            this.btnResidentialTermination.UseVisualStyleBackColor = true;
            this.btnResidentialTermination.Click += new System.EventHandler(this.btnResidentialTermination_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).EndInit();
            this.naviBar1.ResumeLayout(false);
            this.naviBand4.ClientArea.ResumeLayout(false);
            this.naviBand4.ResumeLayout(false);
            this.naviBand3.ClientArea.ResumeLayout(false);
            this.naviBand3.ResumeLayout(false);
            this.naviBand1.ClientArea.ResumeLayout(false);
            this.naviBand1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup1)).EndInit();
            this.naviBand2.ResumeLayout(false);
            this.naviBand5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup2)).EndInit();
            this.naviGroup2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guifreaks.NavigationBar.NaviBar naviBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private Guifreaks.NavigationBar.NaviBand naviBand1;
        private Guifreaks.NavigationBar.NaviBand naviBand2;
        private Guifreaks.NavigationBar.NaviBand naviBand3;
        private Guifreaks.NavigationBar.NaviBand naviBand4;
        private Guifreaks.NavigationBar.NaviBand naviBand5;
        private Guifreaks.NavigationBar.NaviGroup naviGroup1;
        private Guifreaks.NavigationBar.NaviGroup naviGroup2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private UserControls.BusinessApplicationUC businessApplicationUC1;
        private UserControls.ResidentialApplicationUC residentialApplicationUC1;
        private UserControls.ResidentialTerminationUC residentialTerminationUC1;
        private System.Windows.Forms.Button btnTermination;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnResidentialTermination;
        private System.Windows.Forms.Button btnResidentialRegistration;

    }
}