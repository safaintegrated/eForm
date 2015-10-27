using eForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace eForm.Win.Forms
{
    public partial class DeviceRegistrationProcessingForm : Form
    {
        MainProcessForm _mp;

        public DeviceRegistrationProcessingForm(MainProcessForm mp)
        {
            _mp = mp;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserId = "";
            this.Close();
        }

        private void LocalAuthProcessingForm_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Auhtenticate);
        }

        private void Auhtenticate(object state)
        {
            Thread.Sleep(3000);

            Random rd = new Random();
            int id = rd.Next(0, 9999);
            UserId = id.ToString("D6");
            CloseForm();
        }

        private delegate void CloseFormDel();
        private void CloseForm()
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new CloseFormDel(CloseForm));
                }
                catch (Exception ex)
                {

                }
                return;
            }

            this.Close();
        }

        public string UserId { get; set; }
    }
}
