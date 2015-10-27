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
    public partial class ApplicationGroup : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        public ApplicationGroup()
        {
            InitializeComponent();
        }

        public ControlCollection ApplicationControls
        {
            get { return flowLayoutPanel1.Controls; }
        }
        public string Title
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }
    }
}
