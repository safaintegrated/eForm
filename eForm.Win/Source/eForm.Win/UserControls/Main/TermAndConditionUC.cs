using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eForm.Win.Forms;

namespace eForm.Win.UserControls
{
    public partial class TermAndConditionUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        
        public TermAndConditionUC()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MyKadVerifcationForm f = new MyKadVerifcationForm();
            f.ShowDialog();
            if (f.ProfileInfo == null)
                return;

            if (!f.ProfileInfo.IsVerified)
                return;

            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendButtonClick(new ButtonClickEventArgs(ButtonType.SaveTrans));
        }

        private void titleBarUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            SendButtonClick(e);
        }

        private void SendButtonClick(ButtonClickEventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }
    }
}
