using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using BiometricNET;
namespace eForm.Win.Forms
{
	/// <summary>
	/// Summary description for Verify.
	/// </summary>
	public class frmVerify2 : System.Windows.Forms.Form
	{
        IBiometricNET IBNET = new IBiometricNET();
		private System.Windows.Forms.PictureBox picViewer;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.Button btnClose;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TextBox txtStat;
		private System.Windows.Forms.TextBox txtAMsg;
		private System.Windows.Forms.TextBox txtSMsg;
		private System.Windows.Forms.Timer timer1;

		//Public declaration
		int iReturn;
        string strRcvPath1 = null;
        string strRcvPath2 = null;

		public frmVerify2(string path1, string path2)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            strRcvPath1 = path1;
            strRcvPath2 = path2;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.picViewer = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAMsg = new System.Windows.Forms.TextBox();
            this.txtSMsg = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStat
            // 
            this.txtStat.BackColor = System.Drawing.Color.White;
            this.txtStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtStat.Location = new System.Drawing.Point(8, 312);
            this.txtStat.Multiline = true;
            this.txtStat.Name = "txtStat";
            this.txtStat.ReadOnly = true;
            this.txtStat.Size = new System.Drawing.Size(352, 48);
            this.txtStat.TabIndex = 1;
            this.txtStat.TabStop = false;
            this.txtStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStat.TextChanged += new System.EventHandler(this.txtStat_TextChanged);
            // 
            // picViewer
            // 
            this.picViewer.BackColor = System.Drawing.Color.White;
            this.picViewer.Location = new System.Drawing.Point(8, 8);
            this.picViewer.Name = "picViewer";
            this.picViewer.Size = new System.Drawing.Size(352, 296);
            this.picViewer.TabIndex = 2;
            this.picViewer.TabStop = false;
            this.picViewer.Click += new System.EventHandler(this.picViewer_Click);
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(8, 368);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(168, 48);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan Again";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(192, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAMsg
            // 
            this.txtAMsg.Location = new System.Drawing.Point(432, 16);
            this.txtAMsg.Name = "txtAMsg";
            this.txtAMsg.Size = new System.Drawing.Size(100, 20);
            this.txtAMsg.TabIndex = 5;
            this.txtAMsg.Text = "textBox2";
            this.txtAMsg.TextChanged += new System.EventHandler(this.txtAMsg_TextChanged);
            // 
            // txtSMsg
            // 
            this.txtSMsg.Location = new System.Drawing.Point(432, 40);
            this.txtSMsg.Name = "txtSMsg";
            this.txtSMsg.Size = new System.Drawing.Size(100, 20);
            this.txtSMsg.TabIndex = 6;
            this.txtSMsg.Text = "textBox2";
            this.txtSMsg.TextChanged += new System.EventHandler(this.txtSMsg_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmVerify
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(370, 424);
            this.ControlBox = false;
            this.Controls.Add(this.txtSMsg);
            this.Controls.Add(this.txtAMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picViewer);
            this.Controls.Add(this.txtStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verify";
            this.Load += new System.EventHandler(this.Verify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Verify_Load(object sender, System.EventArgs e)
		{
			timer1.Enabled = true;		
		}

		private void btnScan_Click(object sender, System.EventArgs e)
		{
			try
			{
				txtStat.Text = "";
                verify();
			}
			catch (Exception ex)
			{
				MessageBox.Show(null, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(timer1.Interval == 300)
			{
				timer1.Enabled = false;
                if (IBNET.Connect())
                {
                    setDialog();
                    setProperty();
                    btnScan_Click(sender, e);
                 }
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			try
			{
                IBNET.Disconnect();
				this.Close();	
			}
			catch (Exception ex)
			{
				MessageBox.Show(null, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

		}

        private void setDialog()
        {
            IntPtr ViewHdl = this.picViewer.Handle;
            IntPtr Msg1Hdl = this.txtAMsg.Handle;
            IntPtr Msg2Hdl = this.txtSMsg.Handle;

            IBiometricNET.P_CBM_DlgItem dlgCtrl = new IBiometricNET.P_CBM_DlgItem();

            dlgCtrl.hwndViewer = ViewHdl;
            dlgCtrl.hSyncMsg = Msg1Hdl;
            dlgCtrl.hStatusMsg = Msg2Hdl;

            bool l_ret_value = IBNET.SetDialog(ref dlgCtrl);

            if (l_ret_value)
            {                
            }
            else
            {
                MessageBox.Show("SetDialog Fail");
            }
        }

        private void setProperty()
        {
            IBiometricNET.CBM_Properties cbmProperty = new IBiometricNET.CBM_Properties();
            cbmProperty.iTemplateType = IBiometricNET.CBM_PK_MAT_NORM;
            bool l_ret_value = IBNET.SetProperty(ref cbmProperty);

            if (l_ret_value)
            {
            }
            else
            {
                MessageBox.Show("SetProperty Fail");
            }
        }

        private void verify()
        {
            if (!File.Exists(strRcvPath1) || !File.Exists(strRcvPath2))
            {
                MessageBox.Show("File not found!");
                return;
            }

            byte[] ThumbL = new byte[2048];
            byte[] ThumbR = new byte[2048];


            FileStream fs = File.OpenRead(strRcvPath1);              //+WQ 
            int nBytesReadThumbL = fs.Read(ThumbL, 0, ThumbL.Length);
            fs.Close();

            fs = File.OpenRead(strRcvPath2);                 
            int nBytesReadThumbR = fs.Read(ThumbR, 0, ThumbR.Length);
            fs.Close();

            //bool l_ret_value = IBNET.MorphoVerify(ThumbL, nBytesReadThumbL, ThumbR, nBytesReadThumbR);
            bool l_ret_value = IBNET.MorphoVerify(ThumbL, 512, ThumbR, 512);

            if (l_ret_value)
            {
                txtStat.ForeColor = Color.Blue;
                txtStat.Text = "Thumb verified successfully";  
            }
            else
            {
                txtStat.ForeColor = Color.Red;
                txtStat.Text = "Thumb verified fail ";  
            }
        }

        private void txtStat_TextChanged(object sender, EventArgs e)
        {

        }

        private void picViewer_Click(object sender, EventArgs e)
        {

        }

        private void txtAMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSMsg_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
