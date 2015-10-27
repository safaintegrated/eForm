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
    public partial class InstallationAndBillingUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        public InstallationAndBillingUC()
        {
            InitializeComponent();
        }

        private void titleBarUC1_Load(object sender, EventArgs e)
        {

        }

        private void titleBarUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            SendButtonClick(e);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendButtonClick(new ButtonClickEventArgs(ButtonType.BillingCompleted));

        }

        private void SendButtonClick(ButtonClickEventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }
    }
}
