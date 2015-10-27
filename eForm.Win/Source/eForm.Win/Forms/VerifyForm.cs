using BiometricNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class VerifyForm : Form
    {
        IBiometricNET IBNET = new IBiometricNET();
        int iReturn;
        string strRcvPath1 = null;
        string strRcvPath2 = null;
        private string _workDirectory;
        private string _verifyStatus;

        public VerifyForm(string path1, string path2)
        {
            InitializeComponent();
            strRcvPath1 = path1;
            strRcvPath2 = path2;

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "eForm");

            if (!Directory.Exists(userFilePath))
                Directory.CreateDirectory(userFilePath);

            _workDirectory = userFilePath;

            //_workDirectory = IniFile.IniReadValue("device.ini", "Reader", "Directory", "C:\\FpVerify");
            _verifyStatus = "verify.txt";

        }

        private void VerifyForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            File.WriteAllText(Path.Combine(_workDirectory, _verifyStatus), "");

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(Path.Combine(_workDirectory, _verifyStatus), "");

                txtStat.Text = "";
                verify();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 300)
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
                File.WriteAllText(Path.Combine(_workDirectory, _verifyStatus), "SUCCESS");

                Thread.Sleep(1000);
                Close();
            }
            else
            {
                txtStat.ForeColor = Color.Red;
                txtStat.Text = "Thumb verified fail. Try Again.";
                txtStat.Refresh();
                File.WriteAllText(Path.Combine(_workDirectory, _verifyStatus), "FAILED");


                Thread.Sleep(1000);
                btnScan_Click(this, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                IBNET.Disconnect();

            }
            catch 
            {
            }
            this.Close();
        }
    }
}
