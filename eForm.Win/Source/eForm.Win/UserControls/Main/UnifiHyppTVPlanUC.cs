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
    public partial class UnifiHyppTVPlanUC : BaseUserControl
    {

        public UnifiHyppTVPlanUC()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendButtonClick(new ButtonClickEventArgs(ButtonType.UnifiHyppTvCompleted));

        }


    }
}
