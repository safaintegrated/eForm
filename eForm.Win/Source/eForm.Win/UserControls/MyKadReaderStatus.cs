using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Management;

namespace eForm.Win.UserControls
{
    public partial class MyKadReaderStatus : UserControl
    {
        private ManagementEventWatcher _watcherAttach;
        private ManagementEventWatcher _watcherRemove;

        public string DeviceId
        {
            get
            {
                return "USB\\VID_079B&PID_0047";
            }
        }

        public MyKadReaderStatus()
        {
            InitializeComponent();

            //SetStatus(ReaderStatus.Remove);
            Init();
            var insertQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");

            _watcherAttach = new ManagementEventWatcher(insertQuery);
            _watcherAttach.EventArrived += new EventArrivedEventHandler(WatcherAttachOnEventArrived);
            _watcherAttach.Start();

            var removeQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            _watcherRemove = new ManagementEventWatcher(removeQuery);
            _watcherRemove.EventArrived += new EventArrivedEventHandler(WatcherRemoveOnEventArrived);
            _watcherRemove.Start();

        }

        private void WatcherRemoveOnEventArrived(object sender, EventArrivedEventArgs e)
        {
            try
            {
                var scope = new ManagementScope("root\\CIMV2");
                var query = new ObjectQuery("Select * From Win32_PnPEntity");
                scope.Options.EnablePrivileges = true;
                var mySearcher = new ManagementObjectSearcher(scope, query);
                bool found = false;
                foreach (var o in mySearcher.Get())
                {
                    var mobj = (ManagementObject)o;
                    if (mobj == null) continue;

                    //get honeywell scanners
                    if (mobj["DeviceID"] == null)
                        continue;

                    if (mobj["DeviceID"].ToString().Contains(DeviceId))
                    {
                        found = true;
                    }

                }

                if (!found)
                    SetStatus(ReaderStatus.Remove);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Stop();
            base.Dispose(disposing);
        }

        public void Dispose()
        {

        }

        private void WatcherAttachOnEventArrived(object sender, EventArrivedEventArgs e)
        {
            try
            {
                var availableDeviceId = new List<string>();
                //Search for port                                
                var scope = new ManagementScope("root\\CIMV2");
                var query = new ObjectQuery("Select * From Win32_PnPEntity");
                scope.Options.EnablePrivileges = true;
                var mySearcher = new ManagementObjectSearcher(scope, query);
                foreach (var o in mySearcher.Get())
                {
                    var mobj = (ManagementObject)o;
                    if (mobj == null) continue;

                    //get honeywell scanners
                    if (mobj["DeviceID"] == null) continue;

                    if (mobj["DeviceID"].ToString().Contains(DeviceId))
                    {
                        SetStatus(ReaderStatus.Attached);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void Stop()
        {
            if (_watcherAttach != null)
            {
                _watcherAttach.EventArrived -= WatcherAttachOnEventArrived;
                _watcherAttach.Stop();
                _watcherAttach.Dispose();
            }

            if (_watcherAttach != null)
            {
                _watcherRemove.EventArrived -= WatcherRemoveOnEventArrived;
                _watcherRemove.Stop();
                _watcherRemove.Dispose();
            }

           // ResetStatus();
        }


        private void Init()
        {
            try
            {
                //first time search
                //Search for port                                
                var scope = new ManagementScope("root\\CIMV2");
                var query = new ObjectQuery("Select * From Win32_PnPEntity");
                scope.Options.EnablePrivileges = true;
                var mySearcher = new ManagementObjectSearcher(scope, query);
                bool found = false;
                foreach (var o in mySearcher.Get())
                {
                    var mobj = (ManagementObject)o;
                    if (mobj == null) continue;

                    //get honeywell scanners
                    if (mobj["DeviceID"] == null)
                        continue;

                    if (mobj["DeviceID"].ToString().Contains(DeviceId))
                    {
                        found = true;
                    }
                }


                if (!found)
                    SetStatus(ReaderStatus.Remove);
                else
                    SetStatus(ReaderStatus.Attached);

 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private delegate void SetStatusDel(ReaderStatus rdr);
        private void SetStatus(ReaderStatus rdr)
        {
            if(InvokeRequired)
            {
                try
                {
                    Invoke(new SetStatusDel(SetStatus), rdr);
                }
                catch (Exception ex)
                {
                }
                return;
            }

            try
            {
                string iconName = "";
                switch (rdr)
                {
                    case ReaderStatus.Attached:
                        iconName = "switch_on";
                        break;
                    case ReaderStatus.Remove:
                        iconName = "switch_off";
                        break;
                    default:
                        break;
                }

                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(iconName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }

    public enum ReaderStatus
    {
        Attached,
        Remove,
    }
}
