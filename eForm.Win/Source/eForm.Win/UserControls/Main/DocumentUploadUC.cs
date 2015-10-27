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
    public partial class DocumentUploadUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;

        public DocumentUploadUC()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var r = ofd.ShowDialog();

            if(!string.IsNullOrEmpty(ofd.FileName))
            {
                textBox1.Text = ofd.FileName;
                btnNext.Enabled = true;
            }
        }

        private void SendButtonClick(ButtonClickEventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }

        private void titleBarUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            SendButtonClick(e);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                MessageBox.Show("File Uploaded");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendButtonClick(new ButtonClickEventArgs(ButtonType.DocumentUploadCompleted));

        }

    }
}
