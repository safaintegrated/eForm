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
    public partial class SelectionButtonUC : UserControl
    {
        public event EventHandler<EventArgs> ButtonClick;
        public SelectionButtonUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, e);
        }

        public string Title
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }
        }

        public string Code
        {
            get
            {
                return (string)button1.Tag;
            }
            set
            {
                button1.Tag = value;
            }
        }
    }
}
