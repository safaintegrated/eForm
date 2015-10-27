using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace eForm.Win.UserControls
{
    public partial class IncompletApplicationUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        System.Windows.Forms.Timer _timer;

        public IncompletApplicationUC()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = 1000;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (!Visible)
                return;
            int second = int.Parse(DateTime.Now.ToString("ss"));
            if((second%5) != 0)
                return;
            BlinkList();
        }

        private delegate void BlinkListDel();
        private void BlinkList()
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new BlinkListDel(BlinkList));
                }
                catch 
                {
                }
                return;
            }
            for(int i=0; i < 2; i++)
            {
                ChangeColor(Color.Orange);
                Thread.Sleep(100);
                ChangeColor(Color.White);
                Thread.Sleep(100);
            }
        }

        private void ChangeColor(Color color)
        {
            if (listView1.Items.Count == 0)
                return;

            for (int i = 0; i < listView1.Items.Count; i++ )
            {
                listView1.Items[i].UseItemStyleForSubItems = true; 
                listView1.Items[i].BackColor = color;
            }
            listView1.Refresh();
        }

        private void IncompletApplicationUC_VisibleChanged(object sender, EventArgs e)
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

        private void lnkShowMore_Click(object sender, EventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, new ButtonClickEventArgs(ButtonType.IncompleteApplication));
 
        }

        private void lnkShowMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
