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
    public partial class BaseUserControl : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        Main2Form _mf;

        public Main2Form MF
        {
            get { return _mf; }
            set { _mf = value; }
        }

        
        public BaseUserControl()
        {
            InitializeComponent();
        }

        public void SendButtonClick(ButtonClickEventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }
    }
}
