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
    public partial class BottomBarUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;

        public BottomBarUC()
        {
            InitializeComponent();
        }

        public string Title { get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SendClick(new ButtonClickEventArgs(ButtonType.Dashboard));
        }

        private void SendClick(ButtonClickEventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SendClick(new ButtonClickEventArgs(ButtonType.MyPerformance));
        }

    }
}
