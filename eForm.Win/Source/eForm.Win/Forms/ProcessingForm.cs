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
    public partial class ProcessingForm : Form
    {
        private string _userId;
        private string _password;
        MainProcessForm _mp;

        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Message
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public ProcessingForm()
            :this(null, "","")
        {

        }

        public ProcessingForm(MainProcessForm mp, string userId, string password)
        {
            _mp = mp;
            _userId = userId;
            _password = password;

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProfileInfo = null;
            this.Close();
        }

        public ProfileInfo ProfileInfo { get; set; }

        private void LocalAuthProcessingForm_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Auhtenticate);
        }

        private void Auhtenticate(object state)
        {
            Thread.Sleep(500);
            if (_userId != _password)
                ProfileInfo = null;

            ProfileInfo = new ProfileInfo
            {
                FullName = "Fakhrul Azran Nawi",
                UserId = "fan2014"
            };

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
    }
}
