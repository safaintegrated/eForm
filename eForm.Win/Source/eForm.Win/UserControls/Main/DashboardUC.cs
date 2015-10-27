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
    public partial class DashboardUC : UserControl
    {
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        private Main2Form _mf;

        public DashboardUC()
        {
            InitializeComponent();
        }

        public Main2Form MF
        {
            get { return _mf; }
            set { _mf = value; }

        }
        //private void InitializeDynamicComponent()
        //{
        //    var uts = Models.EndUserTypeModel.FindAll();
        //    foreach (var ut in uts)
        //    {
        //        SelectionButtonUC bt = new SelectionButtonUC();
        //        bt.Name = "btn" + ut.Code;
        //        //bt.Size = new System.Drawing.Size(91, 88);
        //        bt.Tag = ut.Code;
        //        bt.Title = ut.Name;
        //        //bt.UseVisualStyleBackColor = true;
        //        bt.ButtonClick += bt_ButtonClick;
        //        flpEndUserType.Controls.Add(bt);

        //        //SelectionButtonUC bt = new SelectionButtonUC();
        //        //bt.Name = "btn" + at.Code;
        //        //// bt.Size = new System.Drawing.Size(91, 88);
        //        //bt.Code = at.Code;
        //        //bt.Title = at.Name;
        //        ////bt.UseVisualStyleBackColor = true;
        //        //bt.ButtonClick += bt_Click;
        //        //uc.ApplicationControls.Add(bt);


        //    }
        //}

        //void bt_ButtonClick(object sender, EventArgs e)
        //{
        //    Button bt = sender as Button;
        //    if (bt == null)
        //        return;
        //    if (ButtonClick == null)
        //        return;
        //    _mf.Trans = new Data.Transaction();
        //    _mf.Trans.EndUserTypeEnum = (string)bt.Tag;
        //    ButtonClick(sender, new ButtonClickEventArgs(ButtonType.Start));
        //}

        //private void bt_Click(object sender, EventArgs e)
        //{
        //    Button bt = sender as Button;
        //    if (bt == null)
        //        return;
        //    if (ButtonClick == null)
        //        return;
        //    _mf.Trans = new Data.Transaction();
        //    _mf.Trans.EndUserTypeCode = (string)bt.Tag;
        //    ButtonClick(sender, new ButtonClickEventArgs(ButtonType.EndUserType));

        //}

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResidential_Click(object sender, EventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, new ButtonClickEventArgs(ButtonType.Start));

            //if (ButtonResidentialClick != null)
            //    ButtonResidentialClick(this, e);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, new ButtonClickEventArgs(ButtonType.Start));
            //if (ButtonBusinessClick != null)
            //    ButtonBusinessClick(this, e);
        }

        private void salesSummaryUC1_Load(object sender, EventArgs e)
        {

        }

        private void titleBarUC1_Load(object sender, EventArgs e)
        {

        }

        private void latestRegistrationUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            if (ButtonClick == null)
                return;
            ButtonClick(sender, e);

        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
           if (MF.UserProfile == null)
                lblUserFullName.Text = "";
            else
                lblUserFullName.Text = MF.UserProfile.FullName;
        }

        private void cbtnSync_ButtonClick(object sender, EventArgs e)
        {
            ButtonClick(sender, new ButtonClickEventArgs(ButtonType.Syncrhonize));
        }

        private void sbtnStart_ButtonClick(object sender, EventArgs e)
        {
            //if (ButtonClick == null)
            //    return;
            ButtonClick(sender, new ButtonClickEventArgs(ButtonType.Start));

        }
    }
}
