using eForm.Data;
using eForm.Win.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class LoginFormAgent : Form
    {
        MainProcessForm _mp;

        public LoginFormAgent(MainProcessForm mp)
        {
            _mp = mp;
            InitializeComponent();
            txtStatus.Text = "UNVERIFIED";
            txtStatus.BackColor = Color.Red;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //var dr = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr != System.Windows.Forms.DialogResult.Yes)
            //    return;

            this.Close();
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(cbUserId.Text))
        //    {
        //        MessageBox.Show("Please select a User id", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }

        //    if (string.IsNullOrEmpty(txtPassword.Text))
        //    {
        //        MessageBox.Show("Please key in Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }

        //    bool isConnected = ConnectionService.CheckForInternetConnection();
        //    DeviceRegistrationProcessingForm lapf = new DeviceRegistrationProcessingForm(_mp);
        //    lapf.ShowDialog();

        //    if (isConnected)
        //    {
        //        bool result = _mp.AuthSvc.Authenticate(cbUserId.Text, txtPassword.Text);
        //        if (!result)
        //        {
        //            MessageBox.Show("Login failed. Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        if (MessageBox.Show("There is no connection with the server.\nClick Yes to continue with Offline verification.", "No Connection", MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
        //        {
        //            return;
        //        }

        //        MyKadVerifcationForm f = new MyKadVerifcationForm();
        //        f.ShowDialog();
        //        if (f.ProfileInfo == null)
        //        {
        //            MessageBox.Show("Verification Failed");
        //            return;
        //        }
        //        if (!f.ProfileInfo.IsVerified)
        //        {
        //            MessageBox.Show("Verification Failed");
        //            return;
        //        }

        //    }

        //    _mp.ShowForm(FormType.MainForm);
        //    this.Hide();
        //}

        private void btnCreateId_Click(object sender, EventArgs e)
        {
            _mp.ShowForm(FormType.TermAndConditionForm);
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            myKadReaderStatus1.Stop();
            e.Cancel = false;
        }

        private void cbUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtPassword.Text = cbUserId.Text;

            //if (cbUserId.Text == "" || txtPassword.Text == "")
            //    btnLogin.Enabled = false;
            //else
            //    btnLogin.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //if (cbUserId.Text == "" || txtPassword.Text == "")
            //    btnLogin.Enabled = false;
            //else
            //    btnLogin.Enabled = true;

        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            txtName.Text = "";
            txtMyKad.Text = "";
            btnVerify.Enabled = false;

           // RefreshReader();

            //string[] rdrs = _mp.MyKad.RefreshReaderList();
            _mp.MyKad.RefreshReaderList();
            //if (rdrs == null)
            //    return;
            ////comboBox1.Items.Clear();
            //for (int i = 0; i < rdrs.Count(); i++)
            //{
            //    if (!string.IsNullOrEmpty(rdrs[i]))
            //    {
            //        comboBox1.Items.Add(rdrs[i]);
            //        if (rdrs[i].Contains("CT01 2"))
            //            comboBox1.Text = rdrs[i];
            //    }
            //}
        }

        //private void RefreshReader()
        //{
        //    int ContextHandle = 0;
        //    uint readerCount = 0;
        //    byte[] pbyReaderNames = new byte[152];
        //    StringBuilder readerList = new StringBuilder();

        //    int status = MyKad_SDK.SCardEstablishContext(0, 0, 0, ref ContextHandle);
        //    if (status != 0)
        //        return;// FpReturn.ErrorSCardEstablishContext;

        //    status = MyKad_SDK.SCardListReaders(ContextHandle, null, pbyReaderNames, out readerCount);
        //    if (status != 0)
        //        return;// FpReturn.ErrorSCardListReaders;


        //    byte[] rdr = new byte[readerCount];
        //    status = MyKad_SDK.SCardListReaders(ContextHandle, null, rdr, out readerCount);
        //    if (status != 0)
        //        return;// FpReturn.ErrorSCardListReaders;
        //    string strRdrName = null;
        //    for (int i = 0; i < readerCount; i++)
        //    {
        //        strRdrName += Convert.ToChar(rdr[i]);

        //    }

        //    string[] RdrName = strRdrName.Split('\0');
        //    comboBox1.Items.Clear();
        //    for (int i = 0; i < RdrName.Count(); i++)
        //    {
        //        if (!string.IsNullOrEmpty(RdrName[i]))
        //        {
        //            comboBox1.Items.Add(RdrName[i]);
        //            if (RdrName[i].Contains("CT01 2"))
        //                comboBox1.Text = RdrName[i];
        //        }
        //    }
        //}

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationSlipForm rsf = new RegistrationSlipForm();
            rsf.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                btnVerify.Enabled = false;
                txtName.Text = "";
                txtMyKad.Text = "";

                ReadingMyKadForm rmf = new ReadingMyKadForm();
                rmf.Show();
                _mp.UserProfile = _mp.MyKad.ReadFromMyKad();
                rmf.Close();
                if (_mp.UserProfile == null)
                {
                    MessageBox.Show("Read failed. Please check your reader or card.");
                    return;
                }
                txtName.Text = _mp.UserProfile.FullName;
                txtMyKad.Text = _mp.UserProfile.IcNo;
                btnVerify_Click(this, e);
                btnVerify.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                MyKad_SDK.CBM_Init();
                int iReturn = -1;

                MyKad_SDK.CBM_RdrName[] dlgRdr = new MyKad_SDK.CBM_RdrName[100];
                iReturn = MyKad_SDK.CBM_Enumerate(dlgRdr);


                VerifyForm dlg = new VerifyForm(_mp.MyKad.GetThumb1Path(), _mp.MyKad.GetThumb2Path());
                dlg.ShowDialog();
                //frmVerify2 f = new frmVerify2(_mp.MyKad.GetThumb1Path(), _mp.MyKad.GetThumb2Path());
                //f.ShowDialog();

                if (File.ReadAllText(Path.Combine(_mp.MyKad.GetWorkDirectory(), _mp.MyKad.GetVerifyStatus())) == "SUCCESS")
                {
                    _mp.UserProfile.IsVerified = true;
                    txtStatus.Text = "VERIFIED";
                    txtStatus.BackColor = Color.Green;
                    txtStatus.Update();
                    Thread.Sleep(500);
                    _mp.ShowForm(FormType.MainForm);

                }
                else
                {
                    _mp.UserProfile.IsVerified = false;
                    MessageBox.Show("Verification failed. Please try again.");
                }
               // UpdateUI();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnRead_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void myKadReaderStatus1_Load(object sender, EventArgs e)
        {

        }

        private void btnReadNoReader_Click(object sender, EventArgs e)
        {
            txtName.Text = "Fakhrul";
            txtMyKad.Text = "123456-12-1234";

            _mp.UserProfile = new ProfileInfo()
            {
                 FullName = "Fakhrul",
                  IcNo = "123456-12-1234"
            };
            btnVerify.Enabled = true;

        }

        private void btnVerifyNoReader_Click(object sender, EventArgs e)
        {
            txtName.Text = "Fakhrul";
            txtMyKad.Text = "123456-12-1234";

            _mp.UserProfile = new ProfileInfo()
            {
                FullName = "Fakhrul",
                IcNo = "123456-12-1234"
            };
            txtStatus.Text = "VERIFIED";
            txtStatus.BackColor = Color.Green;
            txtStatus.Update();
            Thread.Sleep(500);
            _mp.ShowForm(FormType.MainForm);
 
        }
    }
}
