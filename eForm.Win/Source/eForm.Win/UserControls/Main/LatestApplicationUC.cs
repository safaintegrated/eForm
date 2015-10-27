using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eForm.Win.UserControls
{
    public partial class LatestApplicationUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;

        public LatestApplicationUC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void LatestApplicationUC_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            RefreshTable();
        }

        private void RefreshTable()
        {
            listView1.Items.Clear();

            listView1.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), "BIZ5", "Fakhrul Azran", "0192563019" }));
            listView1.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), "VIP10", "Amir Yahaya", "0123456789" }));

        }
    }
}
