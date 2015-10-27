namespace eForm.Win.Forms
{
    partial class DeviceRegistrationForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMACAddress = new System.Windows.Forms.TextBox();
            this.txtCpuId = new System.Windows.Forms.TextBox();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMyKad = new System.Windows.Forms.TextBox();
            this.txtMyKadFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TM eForm Connect Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Device Registration and Auhtorization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Operation System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Processor Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMACAddress);
            this.groupBox2.Controls.Add(this.txtCpuId);
            this.groupBox2.Controls.Add(this.txtOSVersion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine Information";
            // 
            // txtMACAddress
            // 
            this.txtMACAddress.Location = new System.Drawing.Point(125, 77);
            this.txtMACAddress.Name = "txtMACAddress";
            this.txtMACAddress.ReadOnly = true;
            this.txtMACAddress.Size = new System.Drawing.Size(297, 20);
            this.txtMACAddress.TabIndex = 4;
            // 
            // txtCpuId
            // 
            this.txtCpuId.Location = new System.Drawing.Point(125, 51);
            this.txtCpuId.Name = "txtCpuId";
            this.txtCpuId.ReadOnly = true;
            this.txtCpuId.Size = new System.Drawing.Size(297, 20);
            this.txtCpuId.TabIndex = 3;
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.Location = new System.Drawing.Point(125, 25);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.ReadOnly = true;
            this.txtOSVersion.Size = new System.Drawing.Size(297, 20);
            this.txtOSVersion.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "MAC Address";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtGender);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDob);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtMyKad);
            this.groupBox3.Controls.Add(this.txtMyKadFullName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verification";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(125, 97);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(297, 20);
            this.txtGender.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Date of Birth";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(125, 71);
            this.txtDob.Name = "txtDob";
            this.txtDob.ReadOnly = true;
            this.txtDob.Size = new System.Drawing.Size(297, 20);
            this.txtDob.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "IC No";
            // 
            // txtMyKad
            // 
            this.txtMyKad.Location = new System.Drawing.Point(125, 45);
            this.txtMyKad.Name = "txtMyKad";
            this.txtMyKad.ReadOnly = true;
            this.txtMyKad.Size = new System.Drawing.Size(297, 20);
            this.txtMyKad.TabIndex = 5;
            // 
            // txtMyKadFullName
            // 
            this.txtMyKadFullName.Location = new System.Drawing.Point(125, 19);
            this.txtMyKadFullName.Name = "txtMyKadFullName";
            this.txtMyKadFullName.ReadOnly = true;
            this.txtMyKadFullName.Size = new System.Drawing.Size(297, 20);
            this.txtMyKadFullName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Full Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 36);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(-6, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 36);
            this.panel3.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(322, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Activate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DeviceRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeviceRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM eFormonnect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.DeviceRegistrationForm_Load);
            this.VisibleChanged += new System.EventHandler(this.DeviceRegistrationForm_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMACAddress;
        private System.Windows.Forms.TextBox txtCpuId;
        private System.Windows.Forms.TextBox txtOSVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMyKad;
        private System.Windows.Forms.TextBox txtMyKadFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDob;
    }
}