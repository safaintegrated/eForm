using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
//using System.Environmentt;

namespace eForm.Win.Forms
{
    public partial class DeviceRegistrationForm : Form
    {
        MainProcessForm _mp;
        public DeviceRegistrationForm(MainProcessForm mp)
        {
            _mp = mp;
            InitializeComponent();
        }

        private void DeviceRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void DeviceRegistrationForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            btnSubmit.Enabled = true;

            //txtUserId.Text = _mp.ProfileInfo.UserId;
            //txtFullName.Text = _mp.ProfileInfo.FullName;

            txtMyKadFullName.Text = _mp.UserProfile.FullName;
            txtMyKad.Text = _mp.UserProfile.IcNo;
            //txtDob.Text = _mp.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");
            txtGender.Text = _mp.UserProfile.Gender;

            UpdateMachineInfo();
        }

        private void UpdateMachineInfo()
        {
            txtOSVersion.Text = Environment.OSVersion.ToString();
            txtCpuId.Text = GetCPUID();
            txtMACAddress.Text = GetMacAddress(); ;
        }

        private string GetCPUID()
        {
            String cpuid = "";
            try
            {
                ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
                ManagementObjectCollection mbsList = mbs.Get();

                foreach (ManagementObject mo in mbsList)
                {
                    cpuid = mo["ProcessorID"].ToString();
                }
                return cpuid;
            }
            catch (Exception) { return cpuid; }
        }

        private string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }

        private void DeviceRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (_mp.SoftwareType == SoftwareType.TmPoint)
                _mp.ShowForm(FormType.LoginForm);
            else
                _mp.ShowForm(FormType.LoginFormAgent);

        }

        private void btnMyKad_Click(object sender, EventArgs e)
        {
            //MyKadVerifcationForm f = new MyKadVerifcationForm();
            //f.ShowDialog();
            //if (f.ProfileInfo == null)
            //    return;

            //if (!f.ProfileInfo.IsVerified)
            //    return;

            txtMyKadFullName.Text = _mp.UserProfile.FullName;
            txtMyKad.Text = _mp.UserProfile.IcNo;
           // txtDob.Text = _mp.ProfileInfo.DateOfBirth.ToString("dd/MM/yyyy");
            txtGender.Text = _mp.UserProfile.Gender;

            btnSubmit.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DeviceRegistrationProcessingForm lapf = new DeviceRegistrationProcessingForm(_mp);
            lapf.ShowDialog();

            if (string.IsNullOrEmpty(lapf.UserId))
            {
                MessageBox.Show("Registration Failed");
                return;
            }

            _mp.AuthSvc.AddNewUserId(lapf.UserId);

            MessageBox.Show("Registration Sucessful.\nYour User Id is:\n\n" + lapf.UserId);

            Close();
            //_mp.ShowForm(FormType.DeviceRegistrationForm);

        }
    }
}
