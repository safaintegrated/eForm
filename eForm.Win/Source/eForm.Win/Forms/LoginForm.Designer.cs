namespace eForm.Win.Forms
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateId = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cbUserId = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(175, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "eForm v 0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(69, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateId
            // 
            this.btnCreateId.Location = new System.Drawing.Point(12, 5);
            this.btnCreateId.Name = "btnCreateId";
            this.btnCreateId.Size = new System.Drawing.Size(75, 23);
            this.btnCreateId.TabIndex = 4;
            this.btnCreateId.Text = "Activation";
            this.btnCreateId.UseVisualStyleBackColor = true;
            this.btnCreateId.Click += new System.EventHandler(this.btnCreateId_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(262, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(394, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "System";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(443, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(29, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Help";
            // 
            // cbUserId
            // 
            this.cbUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserId.FormattingEnabled = true;
            this.cbUserId.Items.AddRange(new object[] {
            "000001",
            "000002",
            "000003"});
            this.cbUserId.Location = new System.Drawing.Point(192, 217);
            this.cbUserId.Name = "cbUserId";
            this.cbUserId.Size = new System.Drawing.Size(156, 21);
            this.cbUserId.TabIndex = 8;
            this.cbUserId.SelectedIndexChanged += new System.EventHandler(this.cbUserId_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 244);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Note:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "If you are a first time user, please poceed with the registration by click the Ac" +
    "tivation button";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::eForm.Win.Properties.Resources.logo_tm;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(133, 60);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(215, 120);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCreateId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 40);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(247, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 40);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Test Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbUserId);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM eForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateId;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ComboBox cbUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}