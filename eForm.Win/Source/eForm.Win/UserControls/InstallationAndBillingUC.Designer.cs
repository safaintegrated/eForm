namespace eForm.Win.UserControls
{
    partial class InstallationAndBillingUC
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
            this.titleBarUC1 = new eForm.Win.UserControls.TitleBarUC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbBilling = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtBillingAddress2 = new System.Windows.Forms.TextBox();
            this.txtBillingAddress1 = new System.Windows.Forms.TextBox();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.chkInstallationAddress = new System.Windows.Forms.CheckBox();
            this.chkSignUpAutoPay = new System.Windows.Forms.CheckBox();
            this.chkPaperBill = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.lblBillingMedia = new System.Windows.Forms.Label();
            this.lblOnlineBilling = new System.Windows.Forms.Label();
            this.gbInstallation = new System.Windows.Forms.GroupBox();
            this.lbDetails = new System.Windows.Forms.ListBox();
            this.lblFeeCharged = new System.Windows.Forms.Label();
            this.lblPriceDisplayed = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkPM3 = new System.Windows.Forms.CheckBox();
            this.chkAM3 = new System.Windows.Forms.CheckBox();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.dpPreferred3 = new System.Windows.Forms.DateTimePicker();
            this.lblNo3 = new System.Windows.Forms.Label();
            this.chkPM2 = new System.Windows.Forms.CheckBox();
            this.chkAM2 = new System.Windows.Forms.CheckBox();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.dpPreferred2 = new System.Windows.Forms.DateTimePicker();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.chkPM1 = new System.Windows.Forms.CheckBox();
            this.chkAM1 = new System.Windows.Forms.CheckBox();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.dpPreferred1 = new System.Windows.Forms.DateTimePicker();
            this.lblNo1 = new System.Windows.Forms.Label();
            this.lblRelocationDate = new System.Windows.Forms.Label();
            this.lblPreferedInstallation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.lblInstallationAddress = new System.Windows.Forms.Label();
            this.chkHighRise = new System.Windows.Forms.CheckBox();
            this.chkLanded = new System.Windows.Forms.CheckBox();
            this.lblPropertyType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbBilling.SuspendLayout();
            this.gbInstallation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleBarUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 50);
            this.panel1.TabIndex = 17;
            // 
            // titleBarUC1
            // 
            this.titleBarUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBarUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarUC1.Location = new System.Drawing.Point(0, 0);
            this.titleBarUC1.Name = "titleBarUC1";
            this.titleBarUC1.Size = new System.Drawing.Size(1087, 50);
            this.titleBarUC1.TabIndex = 0;
            this.titleBarUC1.Title = "Installation & Billing";
            this.titleBarUC1.ButtonClick += new System.EventHandler<eForm.Win.ButtonClickEventArgs>(this.titleBarUC1_ButtonClick);
            this.titleBarUC1.Load += new System.EventHandler(this.titleBarUC1_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 50);
            this.panel2.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(794, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 50);
            this.panel5.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(193, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbBilling);
            this.panel3.Controls.Add(this.gbInstallation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 521);
            this.panel3.TabIndex = 19;
            // 
            // gbBilling
            // 
            this.gbBilling.Controls.Add(this.textBox4);
            this.gbBilling.Controls.Add(this.lblPostalCode);
            this.gbBilling.Controls.Add(this.txtBillingAddress2);
            this.gbBilling.Controls.Add(this.txtBillingAddress1);
            this.gbBilling.Controls.Add(this.lblBillingAddress);
            this.gbBilling.Controls.Add(this.chkInstallationAddress);
            this.gbBilling.Controls.Add(this.chkSignUpAutoPay);
            this.gbBilling.Controls.Add(this.chkPaperBill);
            this.gbBilling.Controls.Add(this.chkEmail);
            this.gbBilling.Controls.Add(this.lblBillingMedia);
            this.gbBilling.Controls.Add(this.lblOnlineBilling);
            this.gbBilling.Location = new System.Drawing.Point(3, 280);
            this.gbBilling.Name = "gbBilling";
            this.gbBilling.Size = new System.Drawing.Size(972, 191);
            this.gbBilling.TabIndex = 6;
            this.gbBilling.TabStop = false;
            this.gbBilling.Text = "SECTION 4 : BILLING";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(723, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 20);
            this.textBox4.TabIndex = 12;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(657, 133);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(68, 13);
            this.lblPostalCode.TabIndex = 11;
            this.lblPostalCode.Text = "Postal Code*";
            // 
            // txtBillingAddress2
            // 
            this.txtBillingAddress2.Location = new System.Drawing.Point(106, 133);
            this.txtBillingAddress2.Name = "txtBillingAddress2";
            this.txtBillingAddress2.Size = new System.Drawing.Size(513, 20);
            this.txtBillingAddress2.TabIndex = 8;
            // 
            // txtBillingAddress1
            // 
            this.txtBillingAddress1.Location = new System.Drawing.Point(106, 107);
            this.txtBillingAddress1.Name = "txtBillingAddress1";
            this.txtBillingAddress1.Size = new System.Drawing.Size(843, 20);
            this.txtBillingAddress1.TabIndex = 7;
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.Location = new System.Drawing.Point(8, 84);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(79, 13);
            this.lblBillingAddress.TabIndex = 6;
            this.lblBillingAddress.Text = "Billing Address*";
            // 
            // chkInstallationAddress
            // 
            this.chkInstallationAddress.AutoSize = true;
            this.chkInstallationAddress.Location = new System.Drawing.Point(106, 84);
            this.chkInstallationAddress.Name = "chkInstallationAddress";
            this.chkInstallationAddress.Size = new System.Drawing.Size(220, 17);
            this.chkInstallationAddress.TabIndex = 5;
            this.chkInstallationAddress.Text = "Please tick if same as installation address";
            this.chkInstallationAddress.UseVisualStyleBackColor = true;
            // 
            // chkSignUpAutoPay
            // 
            this.chkSignUpAutoPay.AutoSize = true;
            this.chkSignUpAutoPay.Location = new System.Drawing.Point(106, 61);
            this.chkSignUpAutoPay.Name = "chkSignUpAutoPay";
            this.chkSignUpAutoPay.Size = new System.Drawing.Size(752, 17);
            this.chkSignUpAutoPay.TabIndex = 4;
            this.chkSignUpAutoPay.Text = "Please tick if you would like to sign up for TM Autopay service (Get a rebate of " +
    "RM 2 every month. No more late payments. Skip the drive, skip the queue!)";
            this.chkSignUpAutoPay.UseVisualStyleBackColor = true;
            // 
            // chkPaperBill
            // 
            this.chkPaperBill.AutoSize = true;
            this.chkPaperBill.Location = new System.Drawing.Point(441, 38);
            this.chkPaperBill.Name = "chkPaperBill";
            this.chkPaperBill.Size = new System.Drawing.Size(70, 17);
            this.chkPaperBill.TabIndex = 3;
            this.chkPaperBill.Text = "Paper Bill";
            this.chkPaperBill.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(224, 38);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(156, 17);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "e-mail (Lets save our earth!)";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // lblBillingMedia
            // 
            this.lblBillingMedia.AutoSize = true;
            this.lblBillingMedia.Location = new System.Drawing.Point(8, 38);
            this.lblBillingMedia.Name = "lblBillingMedia";
            this.lblBillingMedia.Size = new System.Drawing.Size(214, 13);
            this.lblBillingMedia.TabIndex = 1;
            this.lblBillingMedia.Text = "For other billing media, please choose one : ";
            // 
            // lblOnlineBilling
            // 
            this.lblOnlineBilling.AutoSize = true;
            this.lblOnlineBilling.Location = new System.Drawing.Point(8, 20);
            this.lblOnlineBilling.Name = "lblOnlineBilling";
            this.lblOnlineBilling.Size = new System.Drawing.Size(279, 13);
            this.lblOnlineBilling.TabIndex = 0;
            this.lblOnlineBilling.Text = "Online billing is available at Online Customer Centre portal.";
            // 
            // gbInstallation
            // 
            this.gbInstallation.Controls.Add(this.lbDetails);
            this.gbInstallation.Controls.Add(this.lblFeeCharged);
            this.gbInstallation.Controls.Add(this.lblPriceDisplayed);
            this.gbInstallation.Controls.Add(this.linkLabel1);
            this.gbInstallation.Controls.Add(this.chkPM3);
            this.gbInstallation.Controls.Add(this.chkAM3);
            this.gbInstallation.Controls.Add(this.lblTime3);
            this.gbInstallation.Controls.Add(this.dpPreferred3);
            this.gbInstallation.Controls.Add(this.lblNo3);
            this.gbInstallation.Controls.Add(this.chkPM2);
            this.gbInstallation.Controls.Add(this.chkAM2);
            this.gbInstallation.Controls.Add(this.lblTime2);
            this.gbInstallation.Controls.Add(this.dpPreferred2);
            this.gbInstallation.Controls.Add(this.lblNo2);
            this.gbInstallation.Controls.Add(this.chkPM1);
            this.gbInstallation.Controls.Add(this.chkAM1);
            this.gbInstallation.Controls.Add(this.lblTime1);
            this.gbInstallation.Controls.Add(this.dpPreferred1);
            this.gbInstallation.Controls.Add(this.lblNo1);
            this.gbInstallation.Controls.Add(this.lblRelocationDate);
            this.gbInstallation.Controls.Add(this.lblPreferedInstallation);
            this.gbInstallation.Controls.Add(this.textBox1);
            this.gbInstallation.Controls.Add(this.lblPostcode);
            this.gbInstallation.Controls.Add(this.txtState);
            this.gbInstallation.Controls.Add(this.lblState);
            this.gbInstallation.Controls.Add(this.txtAdd3);
            this.gbInstallation.Controls.Add(this.txtAdd2);
            this.gbInstallation.Controls.Add(this.txtAdd1);
            this.gbInstallation.Controls.Add(this.lblInstallationAddress);
            this.gbInstallation.Controls.Add(this.chkHighRise);
            this.gbInstallation.Controls.Add(this.chkLanded);
            this.gbInstallation.Controls.Add(this.lblPropertyType);
            this.gbInstallation.Location = new System.Drawing.Point(3, 6);
            this.gbInstallation.Name = "gbInstallation";
            this.gbInstallation.Size = new System.Drawing.Size(969, 268);
            this.gbInstallation.TabIndex = 5;
            this.gbInstallation.TabStop = false;
            this.gbInstallation.Text = "SECTION 3 : INSTALLATION / RELOCATION";
            // 
            // lbDetails
            // 
            this.lbDetails.FormattingEnabled = true;
            this.lbDetails.Items.AddRange(new object[] {
            "Fixed Line Installation Fees = RM 53.00    Fixed Line Installation Fees = RM 53.0" +
                "0",
            "Streamyx Installation = RM 93.28              Streamyx Activation Fees = RM 79.50" +
                "",
            "UniFi Installation Fees = RM 212.00          Unifi Relocation Fees = RM 318.00"});
            this.lbDetails.Location = new System.Drawing.Point(557, 179);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(392, 43);
            this.lbDetails.TabIndex = 39;
            // 
            // lblFeeCharged
            // 
            this.lblFeeCharged.AutoSize = true;
            this.lblFeeCharged.Location = new System.Drawing.Point(776, 233);
            this.lblFeeCharged.Name = "lblFeeCharged";
            this.lblFeeCharged.Size = new System.Drawing.Size(179, 13);
            this.lblFeeCharged.TabIndex = 38;
            this.lblFeeCharged.Text = "*Note : Fee will be charged in the bill";
            // 
            // lblPriceDisplayed
            // 
            this.lblPriceDisplayed.AutoSize = true;
            this.lblPriceDisplayed.Location = new System.Drawing.Point(564, 233);
            this.lblPriceDisplayed.Name = "lblPriceDisplayed";
            this.lblPriceDisplayed.Size = new System.Drawing.Size(173, 13);
            this.lblPriceDisplayed.TabIndex = 37;
            this.lblPriceDisplayed.Text = "*Price displayed is inclusive of GST";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(575, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 36;
            // 
            // chkPM3
            // 
            this.chkPM3.AutoSize = true;
            this.chkPM3.Location = new System.Drawing.Point(482, 233);
            this.chkPM3.Name = "chkPM3";
            this.chkPM3.Size = new System.Drawing.Size(42, 17);
            this.chkPM3.TabIndex = 27;
            this.chkPM3.Text = "PM";
            this.chkPM3.UseVisualStyleBackColor = true;
            // 
            // chkAM3
            // 
            this.chkAM3.AutoSize = true;
            this.chkAM3.Location = new System.Drawing.Point(429, 233);
            this.chkAM3.Name = "chkAM3";
            this.chkAM3.Size = new System.Drawing.Size(42, 17);
            this.chkAM3.TabIndex = 26;
            this.chkAM3.Text = "AM";
            this.chkAM3.UseVisualStyleBackColor = true;
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Location = new System.Drawing.Point(388, 235);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(33, 13);
            this.lblTime3.TabIndex = 25;
            this.lblTime3.Text = "Time:";
            // 
            // dpPreferred3
            // 
            this.dpPreferred3.Location = new System.Drawing.Point(166, 233);
            this.dpPreferred3.Name = "dpPreferred3";
            this.dpPreferred3.Size = new System.Drawing.Size(200, 20);
            this.dpPreferred3.TabIndex = 24;
            // 
            // lblNo3
            // 
            this.lblNo3.AutoSize = true;
            this.lblNo3.Location = new System.Drawing.Point(143, 235);
            this.lblNo3.Name = "lblNo3";
            this.lblNo3.Size = new System.Drawing.Size(16, 13);
            this.lblNo3.TabIndex = 23;
            this.lblNo3.Text = "3.";
            // 
            // chkPM2
            // 
            this.chkPM2.AutoSize = true;
            this.chkPM2.Location = new System.Drawing.Point(482, 207);
            this.chkPM2.Name = "chkPM2";
            this.chkPM2.Size = new System.Drawing.Size(42, 17);
            this.chkPM2.TabIndex = 22;
            this.chkPM2.Text = "PM";
            this.chkPM2.UseVisualStyleBackColor = true;
            // 
            // chkAM2
            // 
            this.chkAM2.AutoSize = true;
            this.chkAM2.Location = new System.Drawing.Point(429, 207);
            this.chkAM2.Name = "chkAM2";
            this.chkAM2.Size = new System.Drawing.Size(42, 17);
            this.chkAM2.TabIndex = 21;
            this.chkAM2.Text = "AM";
            this.chkAM2.UseVisualStyleBackColor = true;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(388, 209);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(33, 13);
            this.lblTime2.TabIndex = 20;
            this.lblTime2.Text = "Time:";
            // 
            // dpPreferred2
            // 
            this.dpPreferred2.Location = new System.Drawing.Point(166, 207);
            this.dpPreferred2.Name = "dpPreferred2";
            this.dpPreferred2.Size = new System.Drawing.Size(200, 20);
            this.dpPreferred2.TabIndex = 19;
            // 
            // lblNo2
            // 
            this.lblNo2.AutoSize = true;
            this.lblNo2.Location = new System.Drawing.Point(143, 209);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(16, 13);
            this.lblNo2.TabIndex = 18;
            this.lblNo2.Text = "2.";
            // 
            // chkPM1
            // 
            this.chkPM1.AutoSize = true;
            this.chkPM1.Location = new System.Drawing.Point(482, 181);
            this.chkPM1.Name = "chkPM1";
            this.chkPM1.Size = new System.Drawing.Size(42, 17);
            this.chkPM1.TabIndex = 17;
            this.chkPM1.Text = "PM";
            this.chkPM1.UseVisualStyleBackColor = true;
            // 
            // chkAM1
            // 
            this.chkAM1.AutoSize = true;
            this.chkAM1.Location = new System.Drawing.Point(429, 181);
            this.chkAM1.Name = "chkAM1";
            this.chkAM1.Size = new System.Drawing.Size(42, 17);
            this.chkAM1.TabIndex = 16;
            this.chkAM1.Text = "AM";
            this.chkAM1.UseVisualStyleBackColor = true;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(388, 183);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(33, 13);
            this.lblTime1.TabIndex = 15;
            this.lblTime1.Text = "Time:";
            // 
            // dpPreferred1
            // 
            this.dpPreferred1.Location = new System.Drawing.Point(166, 181);
            this.dpPreferred1.Name = "dpPreferred1";
            this.dpPreferred1.Size = new System.Drawing.Size(200, 20);
            this.dpPreferred1.TabIndex = 14;
            // 
            // lblNo1
            // 
            this.lblNo1.AutoSize = true;
            this.lblNo1.Location = new System.Drawing.Point(143, 183);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(16, 13);
            this.lblNo1.TabIndex = 13;
            this.lblNo1.Text = "1.";
            // 
            // lblRelocationDate
            // 
            this.lblRelocationDate.AutoSize = true;
            this.lblRelocationDate.Location = new System.Drawing.Point(18, 196);
            this.lblRelocationDate.Name = "lblRelocationDate";
            this.lblRelocationDate.Size = new System.Drawing.Size(91, 13);
            this.lblRelocationDate.TabIndex = 12;
            this.lblRelocationDate.Text = "Relocation Date *";
            // 
            // lblPreferedInstallation
            // 
            this.lblPreferedInstallation.AutoSize = true;
            this.lblPreferedInstallation.Location = new System.Drawing.Point(18, 183);
            this.lblPreferedInstallation.Name = "lblPreferedInstallation";
            this.lblPreferedInstallation.Size = new System.Drawing.Size(114, 13);
            this.lblPreferedInstallation.TabIndex = 11;
            this.lblPreferedInstallation.Text = "Preferred Installation / ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(715, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(649, 144);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(57, 13);
            this.lblPostcode.TabIndex = 9;
            this.lblPostcode.Text = "PostCode*";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(146, 144);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(485, 20);
            this.txtState.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(15, 151);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 13);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State*";
            // 
            // txtAdd3
            // 
            this.txtAdd3.Location = new System.Drawing.Point(146, 108);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(795, 20);
            this.txtAdd3.TabIndex = 6;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(146, 82);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(795, 20);
            this.txtAdd2.TabIndex = 5;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(146, 54);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(795, 20);
            this.txtAdd1.TabIndex = 4;
            // 
            // lblInstallationAddress
            // 
            this.lblInstallationAddress.AutoSize = true;
            this.lblInstallationAddress.Location = new System.Drawing.Point(14, 54);
            this.lblInstallationAddress.Name = "lblInstallationAddress";
            this.lblInstallationAddress.Size = new System.Drawing.Size(102, 13);
            this.lblInstallationAddress.TabIndex = 3;
            this.lblInstallationAddress.Text = "Installation Address*";
            // 
            // chkHighRise
            // 
            this.chkHighRise.AutoSize = true;
            this.chkHighRise.Location = new System.Drawing.Point(405, 25);
            this.chkHighRise.Name = "chkHighRise";
            this.chkHighRise.Size = new System.Drawing.Size(156, 17);
            this.chkHighRise.TabIndex = 2;
            this.chkHighRise.Text = "High-rise (5 storeys or more)";
            this.chkHighRise.UseVisualStyleBackColor = true;
            // 
            // chkLanded
            // 
            this.chkLanded.AutoSize = true;
            this.chkLanded.Location = new System.Drawing.Point(146, 24);
            this.chkLanded.Name = "chkLanded";
            this.chkLanded.Size = new System.Drawing.Size(220, 17);
            this.chkLanded.TabIndex = 1;
            this.chkLanded.Text = "Landed and High- rise less than 5 storeys";
            this.chkLanded.UseVisualStyleBackColor = true;
            // 
            // lblPropertyType
            // 
            this.lblPropertyType.AutoSize = true;
            this.lblPropertyType.Location = new System.Drawing.Point(15, 25);
            this.lblPropertyType.Name = "lblPropertyType";
            this.lblPropertyType.Size = new System.Drawing.Size(77, 13);
            this.lblPropertyType.TabIndex = 0;
            this.lblPropertyType.Text = "Property Type*";
            // 
            // InstallationAndBillingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InstallationAndBillingUC";
            this.Size = new System.Drawing.Size(1087, 621);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbBilling.ResumeLayout(false);
            this.gbBilling.PerformLayout();
            this.gbInstallation.ResumeLayout(false);
            this.gbInstallation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private TitleBarUC titleBarUC1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbBilling;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtBillingAddress2;
        private System.Windows.Forms.TextBox txtBillingAddress1;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.CheckBox chkInstallationAddress;
        private System.Windows.Forms.CheckBox chkSignUpAutoPay;
        private System.Windows.Forms.CheckBox chkPaperBill;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.Label lblBillingMedia;
        private System.Windows.Forms.Label lblOnlineBilling;
        private System.Windows.Forms.GroupBox gbInstallation;
        private System.Windows.Forms.ListBox lbDetails;
        private System.Windows.Forms.Label lblFeeCharged;
        private System.Windows.Forms.Label lblPriceDisplayed;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkPM3;
        private System.Windows.Forms.CheckBox chkAM3;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.DateTimePicker dpPreferred3;
        private System.Windows.Forms.Label lblNo3;
        private System.Windows.Forms.CheckBox chkPM2;
        private System.Windows.Forms.CheckBox chkAM2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.DateTimePicker dpPreferred2;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.CheckBox chkPM1;
        private System.Windows.Forms.CheckBox chkAM1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.DateTimePicker dpPreferred1;
        private System.Windows.Forms.Label lblNo1;
        private System.Windows.Forms.Label lblRelocationDate;
        private System.Windows.Forms.Label lblPreferedInstallation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label lblInstallationAddress;
        private System.Windows.Forms.CheckBox chkHighRise;
        private System.Windows.Forms.CheckBox chkLanded;
        private System.Windows.Forms.Label lblPropertyType;
    }
}
