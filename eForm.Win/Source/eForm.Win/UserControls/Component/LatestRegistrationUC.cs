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
    public partial class LatestRegistrationUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        
        public LatestRegistrationUC()
        {
            InitializeComponent();
        }

        private void recentApplicationUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, e);
        }

        private void incompletApplicationUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, e);
        }
    }
}
