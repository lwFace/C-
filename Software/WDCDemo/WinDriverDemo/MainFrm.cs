using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using WinDriverDemo.Modules;
using WinDriverDemo.About;
using WDCLibrary;

namespace WinDriverDemo
{
    public partial class MainFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BoardScan _scanFrm;
        private BoardConfig _configFrm;
        private RegTest _regTestFrm;
        public HR_DeviceList _deviceList;
        DevExpress.Utils.WaitDialogForm _waitForm;
        OptionsFrm _optionFrm;
        public MainFrm()
        {            
            _waitForm =new DevExpress.Utils.WaitDialogForm("Initialize components...(1/3)","Waiting...");//,new Size(200,120)
            _waitForm.Show();
            InitializeComponent();            
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            _waitForm.SetCaption("Initialize center panel...(2/3)");
           // System.Threading.Thread.Sleep(1000)
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinMenu, true);
            _deviceList = HR_DeviceList.TheDeviceList();
            this.Tag = _deviceList;           
            InitCenterPannel();
            DrvStatusUpdate();
            this.btnDeviceOpen.Enabled = false;
            //this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            _waitForm.SetCaption("Loading options...(3/3)");
            _optionFrm = new OptionsFrm();
            _waitForm.Close();
        }
        #region center pannel
        private void InitCenterPannel()
        {
            try
            {
                _scanFrm = new BoardScan();
                _configFrm = new BoardConfig();
                _regTestFrm = new RegTest();
                this.centerPannel.Controls.Add(_scanFrm);
                this.centerPannel.Controls.Add(_configFrm);
                this.centerPannel.Controls.Add(_regTestFrm);
            }
           catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void SwitchFrm(string name)
        {
            try
            {
                string frmName = null;
                switch (name)
                {
                    case "boardInitItem":
                        frmName = "Scan";
                        break;
                    case "boardConfigItem":
                        frmName = "Configuration";
                        _configFrm.UpdateComboBAR();
                        break;
                    case "regTestItem":
                        frmName = "RegTest";
                        _regTestFrm.SetDev(_scanFrm._selectDevice);
                        break;
                    default:
                        break;
                }
                if (frmName == null)
                {
                    MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (Control ctl in this.centerPannel.Controls)
                {
                    if (frmName == ctl.Name)
                    {
                        ctl.Dock = DockStyle.Fill;
                        ctl.Show();
                    }
                    else
                    {
                        ctl.Hide();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }            
        }
        #endregion
        #region Nav Bar Control
        private void dlgItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                string ls_form;
                ls_form = e.Link.Item.Name.Trim();
                SwitchFrm(ls_form);               
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
        }
        #endregion

        
        #region Menu
        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
        private void btnLoadLib_ItemClick(object sender, ItemClickEventArgs e)
        {
            try 
            {
                this._deviceList.Init();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            DrvStatusUpdate();
        }
        private void DrvStatusUpdate()
        {
            bool initFlag = this._deviceList.GetDrvStatus();
            if (initFlag)
            {
                this.drvStatus.Caption = "Driver library status: Loaded.";
            }
            else
            {
                this.drvStatus.Caption = "Driver library status: Disposed.";
            }
        }
        #endregion

        private void btnDispose_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
              this._deviceList.Dispose();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DrvStatusUpdate();
            
        }

        public void enableBtnOpen(bool flag)
        {
            this.btnDeviceOpen.Enabled = flag;
            if (!flag)
            {
                this.deviceStatus.Caption = "Device Status : Opened";
            }
            else 
            {
                this.deviceStatus.Caption = "Device Status : Closed";
            }
            
        }
        private void btnDeviceOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this._scanFrm._selectDevice.Open();
                this.btnDeviceOpen.Enabled = false;
                this.deviceStatus.Caption = "Device Status : Opened";                
            }
            catch (Exception exception)
            {
                this.deviceStatus.Caption = "Device Status : Closed";
               // SetFormText("No invalid device selected");
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        public void SetFormText(string appendName)
        {
            this.Text = String.Format("HiDriverTester({0})", appendName);
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            _regTestFrm.Hide();
            _scanFrm.Hide();
            _configFrm.Hide();
            //centerPannel.Hide();
        }

        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {            
            _optionFrm.Show();
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.Show();
        }

        
    }
}