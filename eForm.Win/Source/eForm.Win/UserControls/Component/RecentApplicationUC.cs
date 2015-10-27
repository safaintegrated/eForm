using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eForm.Services;
using eForm.Data.SqlServerCompact;

namespace eForm.Win.UserControls
{
    public partial class RecentApplicationUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        IApplicationService _svc;

        public RecentApplicationUC()
        {
            InitializeComponent();
            _svc = new ApplicationService(new eFormSqlCeContext());
        }

        private void RecentApplicationUC_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            RefreshTable();
        }

        private void RefreshTable()
        {
            listView1.Items.Clear();

            var apps = _svc.FindAll();// Models.ApplicationModel.FindAll();
            foreach(var app in apps)
            {
                listView1.Items.Add(new ListViewItem(new string[] { 
                    app.EndDateTime.ToString(), 
                    app.ProductTypeEnum.ToString(),
                    app.Applicant.FullName,
                    app.Applicant.PhoneNo}));
            }
            //listView1.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), "BIZ5", "Fakhrul Azran", "0192563019" }));
            //listView1.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), "VIP10", "Amir Yahaya", "0123456789" }));

        }

        private void lnkShowMore_Click(object sender, EventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, new ButtonClickEventArgs(ButtonType.RecentApplication));
        }
    }
}
