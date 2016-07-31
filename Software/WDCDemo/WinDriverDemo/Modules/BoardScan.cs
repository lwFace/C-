using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using WDCLibrary;

using DWORD = System.UInt32;
using BOOL = System.Boolean;
using WDC_DRV_OPEN_OPTIONS = System.UInt32; 

namespace WinDriverDemo.Modules
{
    public partial class BoardScan : DevExpress.XtraEditors.XtraUserControl
    {
        public HR_DeviceList _deviceList;
        public HR_Device _selectDevice;
        public DataTable _deviceTable = new DataTable();
        public BoardScan()
        {
            InitializeComponent();
            try
            {
                this.Dock = DockStyle.Fill;
                this.Hide();
                this.Name = "Scan";
                _deviceList = Program._mainFrm._deviceList;
                _deviceTable.Clear();
                _deviceTable.Columns.Add("Vendor ID", typeof(string));
                _deviceTable.Columns.Add("Device ID", typeof(string));
                _deviceTable.Columns.Add("Location", typeof(string));
                this.cardList.DataSource = _deviceTable;
                this.gridView1.IndicatorWidth = 30;//设置显示行号的列宽
                this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(gridView1_CustomDrawRowIndicator);
                DWORD dwStatus = _deviceList.Init();
                if (dwStatus != 0)
                {
                    MessageBox.Show("Initialize driver lib failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }           
                  
        }
        /// <summary>
        /// 扫描PCI设备
        /// </summary>
        /// <param name="vendorId"></param>
        /// <param name="deviceId"></param>
        void ScanDevice(uint vendorId,uint deviceId)
        {
            _deviceList.Clear();
            _deviceTable.Clear();
            DWORD dwStatus = _deviceList.Populate(vendorId, deviceId);
            if (dwStatus != 0)
            {
                MessageBox.Show("Scan device failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (HR_Device dev in _deviceList)
            {
                string location = string.Format("Bus:0x{0:X} Function:0x{1:X} Slot:0x{2:X}", dev.slot.dwBus, dev.slot.dwFunction, dev.slot.dwSlot);
                _deviceTable.Rows.Add(new object[] { "0x" + Convert.ToString(dev.id.dwVendorId, 16), "0x" + Convert.ToString(dev.id.dwDeviceId, 16), location });
            }
            //this.cardList.Update();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                ScanDevice(Convert.ToUInt32(this.editVendor.EditValue.ToString(),16), Convert.ToUInt32(this.editDeviceId.EditValue.ToString(),16)); 
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //MessageBox.Show("Please input the correct vendor id and device id.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 为gridControl首列添加标号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           // MessageBox.Show(System.String.Format("{0}",e.RowHandle) ) ;
            _selectDevice =
                   _deviceList.Get(e.RowHandle);
            Program._mainFrm.SetFormText(this._selectDevice.ToString(false));
            if (_selectDevice.Handle == IntPtr.Zero)
            {
                Program._mainFrm.enableBtnOpen(true);                
            }
            else
            {
                Program._mainFrm.enableBtnOpen(false);
            }
        }
    }
}
