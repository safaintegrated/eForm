namespace eForm.Win.Forms
{
    partial class LoginFormAgent
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
            this.btnCreateId = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtMyKad = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReadNoReader = new System.Windows.Forms.Button();
            this.btnVerifyNoReader = new System.Windows.Forms.Button();
            this.myKadReaderStatus1 = new eForm.Win.UserControls.MyKadReaderStatus();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(808, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "eForm v 0.1 Agent";
            // 
            // btnCreateId
            // 
            this.btnCreateId.BackColor = System.Drawing.Color.White;
            this.btnCreateId.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateId.Location = new System.Drawing.Point(0, 0);
            this.btnCreateId.Name = "btnCreateId";
            this.btnCreateId.Size = new System.Drawing.Size(130, 60);
            this.btnCreateId.TabIndex = 4;
            this.btnCreateId.Text = "Activation";
            this.btnCreateId.UseVisualStyleBackColor = false;
            this.btnCreateId.Click += new System.EventHandler(this.btnCreateId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Note:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 646);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(556, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "If you are a first time user, please poceed with the registration by click the Ac" +
    "tivation button";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(332, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCreateId);
            this.panel1.Location = new System.Drawing.Point(0, 669);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 60);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRead);
            this.panel3.Controls.Add(this.btnVerify);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(546, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 60);
            this.panel3.TabIndex = 3;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.White;
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRead.Location = new System.Drawing.Point(72, 0);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(130, 60);
            this.btnRead.TabIndex = 20;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.White;
            this.btnVerify.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(202, 0);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(130, 60);
            this.btnVerify.TabIndex = 18;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "MyKad";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(341, 408);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(253, 39);
            this.txtStatus.TabIndex = 16;
            this.txtStatus.Text = "UNVERIFIED";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMyKad
            // 
            this.txtMyKad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyKad.Location = new System.Drawing.Point(341, 340);
            this.txtMyKad.Name = "txtMyKad";
            this.txtMyKad.ReadOnly = true;
            this.txtMyKad.Size = new System.Drawing.Size(253, 32);
            this.txtMyKad.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(341, 293);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(253, 32);
            this.txtName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackgroundImage = global::eForm.Win.Properties.Resources.empty_profile;
            this.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPhoto.Location = new System.Drawing.Point(618, 293);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(142, 154);
            this.pbPhoto.TabIndex = 12;
            this.pbPhoto.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::eForm.Win.Properties.Resources.logo_tm;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(376, 118);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(225, 146);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 60);
            this.panel2.TabIndex = 23;
            // 
            // btnReadNoReader
            // 
            this.btnReadNoReader.Location = new System.Drawing.Point(0, 66);
            this.btnReadNoReader.Name = "btnReadNoReader";
            this.btnReadNoReader.Size = new System.Drawing.Size(53, 23);
            this.btnReadNoReader.TabIndex = 24;
            this.btnReadNoReader.Text = "Read";
            this.btnReadNoReader.UseVisualStyleBackColor = true;
            this.btnReadNoReader.Click += new System.EventHandler(this.btnReadNoReader_Click);
            // 
            // btnVerifyNoReader
            // 
            this.btnVerifyNoReader.Location = new System.Drawing.Point(59, 66);
            this.btnVerifyNoReader.Name = "btnVerifyNoReader";
            this.btnVerifyNoReader.Size = new System.Drawing.Size(50, 23);
            this.btnVerifyNoReader.TabIndex = 25;
            this.btnVerifyNoReader.Text = "Verify";
            this.btnVerifyNoReader.UseVisualStyleBackColor = true;
            this.btnVerifyNoReader.Click += new System.EventHandler(this.btnVerifyNoReader_Click);
            // 
            // myKadReaderStatus1
            // 
            this.myKadReaderStatus1.Location = new System.Drawing.Point(950, 66);
            this.myKadReaderStatus1.Name = "myKadReaderStatus1";
            this.myKadReaderStatus1.Size = new System.Drawing.Size(58, 49);
            this.myKadReaderStatus1.TabIndex = 22;
            this.myKadReaderStatus1.Load += new System.EventHandler(this.myKadReaderStatus1_Load);
            // 
            // LoginFormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnReadNoReader);
            this.Controls.Add(this.btnVerifyNoReader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.myKadReaderStatus1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMyKad);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginFormAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM eForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtMyKad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnRead;
        private UserControls.MyKadReaderStatus myKadReaderStatus1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReadNoReader;
        private System.Windows.Forms.Button btnVerifyNoReader;
    }
}