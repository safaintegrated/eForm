using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eForm.Win.Forms;
using eForm.Data;

namespace eForm.Win.UserControls
{
    public partial class ApplicantTypeUC : BaseUserControl
    {
        //public event EventHandler<ButtonClickEventArgs> ButtonClick;
        //Main2Form _mf;
        public ApplicantTypeUC()
        {
            InitializeComponent();
        }

        //public ProductGroupUC()
        //{
        //    _mf = mf;
        //    InitializeComponent();
        //    InitializeDynamicComponent();
        //}

        //public Main2Form MF
        //{
        //    get { return _mf; }
        //    set { _mf = value; }
        //}


        //private void InitializeDynamicComponent()
        //{
        //    var pts = Models.ProductTypeModel.FindAll();
        //    foreach (var pt in pts)
        //    {
        //        ApplicationGroup uc = new ApplicationGroup();
        //        uc.Name = "ag" + pt.Code;
        //        uc.Dock = DockStyle.Top;
        //        uc.Tag = pt.Code;
        //        uc.Title = pt.Name;
        //        uc.ButtonClick += uc_ButtonClick;
        //        panel1.Controls.Add(uc);
        //        var ats = Models.ApplicationTypeModel.FindAllByProductCode(pt.Code);
                
        //        foreach(var at in ats)
        //        {
        //            SelectionButtonUC bt = new SelectionButtonUC();
        //            bt.Name = "btn" + at.Code;
        //           // bt.Size = new System.Drawing.Size(91, 88);
        //            bt.Code = at.Code;
        //            bt.Title = at.Name;
        //            //bt.UseVisualStyleBackColor = true;
        //            bt.ButtonClick += bt_Click;
        //            uc.ApplicationControls.Add(bt);
        //            //flpEndUserType.Controls.Add(bt);
        //        }

        //    }
        //}

        //private void bt_Click(object sender, EventArgs e)
        //{
        //    Button bt = sender as Button;
        //    if (bt == null)
        //        return;
        //    if (ButtonClick == null)
        //        return;

        //    _mf.Trans.ProductCode = ((string)bt.Tag).Split('-')[0];
        //    _mf.Trans.ApplicationTypeCode = ((string)bt.Tag).Split('-')[1];

        //    ButtonClick(sender, new ButtonClickEventArgs(ButtonType.ApplicationType));

        //}

        void uc_ButtonClick(object sender, ButtonClickEventArgs e)
        {

        }

        private void titleBarUC1_Click(object sender, EventArgs e)
        {
        }

        private void titleBarUC1_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            SendButtonClick(e);
        }

     

        private void ProductGroupUC_Load(object sender, EventArgs e)
        {
        //    try
        //    {
        //        InitializeDynamicComponent();

        //    }
        //    catch (Exception ex)
        //    {

        //    }
 
        }

        private void sbtnResidentialUnifiNewReg_ButtonClick(object sender, EventArgs e)
        {
            if (MF.Application == null)
                return;
            MF.Application.EndUserTypeEnum = EndUserTypeEnum.Residential;
            MF.Application.ProductTypeEnum = ProductTypeEnum.Unifi;
            MF.Application.ApplicationTypeEnum = ApplicationTypeEnum.NewRegistration;

            SendButtonClick(new ButtonClickEventArgs(ButtonType.ApplicantType));
  
        }

        private void sbtnMalaysian_ButtonClick(object sender, EventArgs e)
        {
            MF.Application.ApplicantTypeEnum = ApplicantTypeEnum.Malaysian;
            SendButtonClick(new ButtonClickEventArgs(ButtonType.ApplicantTypeSelected));
        }

        private void sbtnNonMalaysian_ButtonClick(object sender, EventArgs e)
        {
            MF.Application.ApplicantTypeEnum = ApplicantTypeEnum.Malaysian;
            SendButtonClick(new ButtonClickEventArgs(ButtonType.ApplicantTypeSelected));
        }

        private void sBtnOku_ButtonClick(object sender, EventArgs e)
        {
            MF.Application.ApplicantTypeEnum = ApplicantTypeEnum.Malaysian;
            SendButtonClick(new ButtonClickEventArgs(ButtonType.ApplicantTypeSelected));
        }

        private void sbtnTentera_ButtonClick(object sender, EventArgs e)
        {
            MF.Application.ApplicantTypeEnum = ApplicantTypeEnum.Malaysian;
            SendButtonClick(new ButtonClickEventArgs(ButtonType.ApplicantTypeSelected));
            
        }

        //private void sbtnResidentialUnifiNewReg_Load(object sender, EventArgs e)
        //{
        //    if (_mf.Trans == null)
        //        return;
        //    _mf.Trans.EndUserTypeEnum = EndUserTypeEnum.Residential;
        //    _mf.Trans.ProductTypeEnum = ProductTypeEnum.Unifi;
        //    _mf.Trans.ApplicationTypeEnum = ApplicationTypeEnum.NewRegistration; 

        //    SendButtonClick(new ButtonClickEventArgs(ButtonType.ApplicantType));
            
        //    //SendButtonClick(new ButtonClickEventArgs(ButtonType.UnifiTermination));
        //}
    }
}
