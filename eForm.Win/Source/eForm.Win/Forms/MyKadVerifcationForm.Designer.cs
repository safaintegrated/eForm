namespace eForm.Win.Forms
{
    partial class MyKadVerifcationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtMyKad = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 50);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verify Dev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(576, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(414, 10);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(495, 10);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 68);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(121, 120);
            this.txtDob.Name = "txtDob";
            this.txtDob.ReadOnly = true;
            this.txtDob.Size = new System.Drawing.Size(216, 20);
            this.txtDob.TabIndex = 3;
            // 
            // txtMyKad
            // 
            this.txtMyKad.Location = new System.Drawing.Point(121, 94);
            this.txtMyKad.Name = "txtMyKad";
            this.txtMyKad.ReadOnly = true;
            this.txtMyKad.Size = new System.Drawing.Size(216, 20);
            this.txtMyKad.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(121, 146);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(216, 20);
            this.txtGender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postcode";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(378, 327);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(318, 38);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "UNVERIFIED";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MyKad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackgroundImage = global::eForm.Win.Properties.Resources.empty_profile;
            this.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPhoto.Location = new System.Drawing.Point(378, 39);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(318, 279);
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(333, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Citizenship";
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.Location = new System.Drawing.Point(121, 172);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.ReadOnly = true;
            this.txtCitizenship.Size = new System.Drawing.Size(216, 20);
            this.txtCitizenship.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(121, 220);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(216, 20);
            this.txtAddress1.TabIndex = 13;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(121, 246);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(216, 20);
            this.txtAddress2.TabIndex = 15;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(121, 272);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.ReadOnly = true;
            this.txtAddress3.Size = new System.Drawing.Size(216, 20);
            this.txtAddress3.TabIndex = 16;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(121, 298);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(216, 20);
            this.txtPostcode.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(121, 324);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(216, 20);
            this.txtCity.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(121, 350);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(216, 20);
            this.txtState.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "State";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Temporary for Dev";
            // 
            // MyKadVerifcationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 462);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCitizenship);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMyKad);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.panel1);
            this.Name = "MyKadVerifcationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyKadVerifcationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtMyKad;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCitizenship;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}