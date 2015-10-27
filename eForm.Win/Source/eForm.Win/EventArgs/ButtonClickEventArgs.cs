using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win
{
    public class ButtonClickEventArgs : EventArgs
    {
        public ButtonType Type { get; set; }

        public ButtonClickEventArgs(ButtonType bt)
        {
            Type = bt;
        }
    }

    public enum ButtonType
    {
        DocumentUploadCompleted,
        Dashboard,
        Back,
        Forward,
        //UnifiRegistration,
        //UnifiAdditionalService,
        //UnifiUpgrade,
        //UnifiRelocation,
        //UnifiTermination,
        SaveTrans,
        Start,
        ApplicantType,
        RecentApplication,
        IncompleteApplication,
        MyPerformance,
        Syncrhonize,
        ApplicantTypeSelected,
        ApplicationDetailCompleted,
        BillingCompleted,
        ServicesCompleted,
        InstallationDetailCompleted,
        BillingDetailCompleted,
        UnifiOthersPlanCompleted,
        UnifiHyppTvCompleted,
        UnifiCallPlanCompleted,
        UnifiMainDetailsCompleted
    }
}
