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
using Jungo.wdapi_dotnet;

using WDC_DRV_OPEN_OPTIONS = System.UInt32;
using UINT64 = System.UInt64;
using DWORD = System.UInt32;
using UINT32 = System.UInt32;
using WORD = System.UInt16;
using BYTE = System.Byte;
using BOOL = System.Boolean;
namespace WinDriverDemo.Modules
{
    public enum TRANSFER_TYPE
    {
        BLOCK = 0,
        NONBLOCK = 1
    }
    public enum RW
    {
        READ = 0,
        WRITE = 1,
        READ_ALL = 2
    }
    public partial class RegTest : DevExpress.XtraEditors.XtraUserControl
    {
        private HR_Device m_device;
        private bool m_bAutoInc;
        private DWORD m_dwOffset = 0;
        private UINT32 m_dwBytes = 0;
        private TRANSFER_TYPE m_type;
        private WDC_ADDR_MODE m_mode;
        private DWORD m_dwBar;
        private RW m_direction;
        private byte[] m_bData;
        private WORD[] m_wData;
        private UINT32[] m_u32Data;
        private UINT64[] m_u64Data;
        private object[] m_obj;
        Exception m_excp;
        public RegTest()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Hide();
            this.Name = "RegTest";
            this.comboTransMode.Properties.Items.AddRange(new object[] { "8 bits", "16 bits", "32 bits", "64 bits" });
            this.comboTransType.Properties.Items.AddRange(new object[] { "block", "non-block" });
            this.comboTransMode.SelectedIndex = 0;
            this.comboTransType.SelectedIndex = 0;
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.checkEditAutoInc.Checked = true;
        }
        public void SetDev(HR_Device device)
        {
            m_device = device;
            this.comboBaseAddr.Properties.Items.Clear();
            if (m_device == null)
            {
                this.comboBaseAddr.Properties.Items.Add("----- -----");
                return;
            }
            if (m_device.Handle != IntPtr.Zero)
            {
                string[] sBars = m_device.AddrDescToString(false);
                for (int i = 0; i < sBars.Length; ++i)
                {
                    this.comboBaseAddr.Properties.Items.Add(sBars[i]);
                }
            }
            else
            {                
                this.comboBaseAddr.Properties.Items.Add("----- -----");
            }
            this.comboBaseAddr.SelectedIndex = 0;
        }
        #region 控件更新
        /// <summary>
        /// 获取控件的值
        /// </summary>
        private void UpdateActiveValue()
        {
            string str = "";
            m_dwBar = (DWORD)comboBaseAddr.SelectedIndex;
            int uiModeIndex = this.comboTransMode.SelectedIndex;
            //int cmboTransType = this.comboTransType.SelectedIndex;
            m_mode = (uiModeIndex == 0) ? WDC_ADDR_MODE.WDC_MODE_8 :
               (uiModeIndex == 1) ? WDC_ADDR_MODE.WDC_MODE_16 :
               (uiModeIndex == 2) ? WDC_ADDR_MODE.WDC_MODE_32 :
               WDC_ADDR_MODE.WDC_MODE_64;
            if (this.textNumBytes.Enabled == true)
            {
                m_excp = new Exception("Please enter the number of bytes. " +
                    "Entered value should be a hex number." +
                    Environment.NewLine + " (Maximum value: 0x" +
                    m_device.AddrDesc[m_dwBar].dwBytes.ToString("X") + ")");
                m_dwBytes = Convert.ToUInt32(this.textNumBytes.Text, 16);
                if (m_dwBytes > m_device.AddrDesc[m_dwBar].dwBytes)
                {
                    throw m_excp;
                }
            }
            else
            {
                m_dwBytes = (DWORD)((m_mode == WDC_ADDR_MODE.WDC_MODE_8) ? 1 :
                    ((m_mode == WDC_ADDR_MODE.WDC_MODE_16) ? 2 :
                    ((m_mode == WDC_ADDR_MODE.WDC_MODE_32) ? 4 : 8)));
            }
            m_type = (comboTransType.SelectedIndex == 0) ?
           TRANSFER_TYPE.BLOCK : TRANSFER_TYPE.NONBLOCK;
            if (checkEditAutoInc.Enabled == true)
            {
                m_bAutoInc = checkEditAutoInc.Checked;
            }
            m_dwOffset = DWORD.Parse(this.textEditOffset.Text);
            if (m_direction == RW.WRITE && this.editDataWrite.Text == "")
            {
                m_excp = new Exception("You must enter the data to write. " +
                    "data should be hex");
                throw m_excp;
            }

            m_excp = new Exception("The data you've entered is invalid. please "
                + "try again (hex)");

            switch (m_mode)
            {
                case WDC_ADDR_MODE.WDC_MODE_8:
                    {
                        m_bData = new byte[m_dwBytes];

                        if (m_direction == RW.WRITE)
                        {
                            str = editDataWrite.Text;
                            for (int i = 0, j = 0; i < str.Length && j < m_dwBytes; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_bData[j] = Convert.ToByte(str.Substring(i, 2), 16);
                                i += 2;
                            }
                        }

                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_16:
                    {
                        m_wData = new WORD[m_dwBytes / 2];

                        if (m_direction == RW.WRITE)
                        {
                            str = editDataWrite.Text;
                            for (int i = 0, j = 0; i < str.Length && j < m_dwBytes / 2; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_wData[j] = Convert.ToUInt16(str.Substring(i, 4), 16);
                                i += 4;
                            }
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_32:
                    {
                        m_u32Data = new UINT32[m_dwBytes / 4];

                        if (m_direction == RW.WRITE)
                        {
                            str = editDataWrite.Text;
                            for (int i = 0, j = 0; i < str.Length && j < m_dwBytes / 4; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_u32Data[j] = Convert.ToUInt32(str.Substring(i, 8),
                                    16);
                                i += 8;
                            }
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_64:
                    {
                        m_u64Data = new UINT64[m_dwBytes / 8];

                        if (m_direction == RW.WRITE)
                        {
                            str = editDataWrite.Text;
                            for (int i = 0, j = 0; i < str.Length && j < m_dwBytes / 8; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_u64Data[j] = Convert.ToUInt64(str.Substring(i, 2),
                                    16);
                                i += 16;
                            }
                        }
                        break;
                    }
            }
        }
        private void UpdateReadControl(object[] obj, DWORD dwBuffSize,
            WDC_ADDR_MODE mode)
        {
            editDataRead.Text = DisplayHexBuffer(obj, dwBuffSize, mode);
        }
        public static string DisplayHexBuffer(object[] obj, DWORD dwBuffSize,
            WDC_ADDR_MODE mode)
        {
            string display = "00 ";

            switch (mode)
            {
                case WDC_ADDR_MODE.WDC_MODE_8:
                    {
                        BYTE[] buff = (BYTE[])obj[0];
                        for (uint i = 0; i < dwBuffSize; ++i)
                        {
                            display = string.Concat(display,
                                buff[i].ToString("X2"), " ");
                            if ((i + 1) % 16 == 0)
                            {
                                display = string.Concat(display, "\r\n", ((i + 1) / 16).ToString("X2"), " ");
                            }
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_16:
                    {
                        WORD[] buff = (WORD[])obj[0];
                        for (int i = 0; i < dwBuffSize / 2; ++i)
                        {
                            display = string.Concat(display,
                                buff[i].ToString("X4"), " ");
                            if ((i + 1) % 8 == 0)
                            {
                                display = string.Concat(display, "\r\n", ((i + 1) / 8).ToString("X2"), " ");
                            }
                        }

                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_32:
                    {
                        UINT32[] buff = (UINT32[])obj[0];
                        for (int i = 0; i < dwBuffSize / 4; ++i)
                        {
                            display = string.Concat(display,
                                buff[i].ToString("X8"), " ");
                            if ((i + 1) % 4 == 0)
                            {
                                display = string.Concat(display, "\r\n", ((i + 1) / 4).ToString("X2"), " ");
                            }
                        }

                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_64:
                    {
                        UINT64[] buff = (UINT64[])obj[0];
                        for (int i = 0; i < dwBuffSize / 8; ++i)
                        {
                            display = string.Concat(display,
                                buff[i].ToString("X16"), " ");
                            if ((i + 1) % 2 == 0)
                            {
                                display = string.Concat(display, "\r\n", ((i + 1) / 2).ToString("X2"), " ");
                            }
                        }
                        break;
                    }
            }
            return display;
        }
        #endregion
        #region 读写寄存器
        /// <summary>
        /// 写寄存器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            m_direction = RW.WRITE;
            UpdateActiveValue();
            ReadWriteAddrSpace();
        }
        /// <summary>
        /// 读寄存器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            m_direction = RW.READ;
            UpdateActiveValue();
            ReadWriteAddrSpace();
        }
        private void ReadWriteAddrSpace()
        {
            m_obj = new object[1];
            DWORD dwStatus = 0;
            BOOL bIsBlock = (m_type == TRANSFER_TYPE.BLOCK);
            BOOL bIsRead = (m_direction == RW.READ);
            WDC_ADDR_RW_OPTIONS dwOptions = (m_bAutoInc ?
                WDC_ADDR_RW_OPTIONS.WDC_ADDR_RW_DEFAULT :
                WDC_ADDR_RW_OPTIONS.WDC_ADDR_RW_NO_AUTOINC);
            DWORD dwFloorBytes = ((DWORD)(m_dwBytes / (DWORD)m_mode)) *
                (DWORD)m_mode;

            switch (m_mode)
            {
                case WDC_ADDR_MODE.WDC_MODE_8:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, m_dwBytes, m_bData,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr8(m_device.Handle,
                                    m_dwBar, m_dwOffset, ref m_bData[0]);
                            m_obj[0] = m_bData;
                            UpdateReadControl(m_obj, dwFloorBytes, m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_bData,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr8(m_device.Handle,
                                    m_dwBar, m_dwOffset, m_bData[0]);
                        }

                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_16:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_wData,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr16(m_device.Handle,
                                    m_dwBar, m_dwOffset, ref m_wData[0]);
                            m_obj[0] = m_wData;
                            UpdateReadControl(m_obj, dwFloorBytes, m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_wData,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr16(m_device.Handle,
                                    m_dwBar, m_dwOffset, m_wData[0]);
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_32:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_u32Data,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr32(m_device.Handle,
                                    m_dwBar, m_dwOffset, ref m_u32Data[0]);
                            m_obj[0] = m_u32Data;
                            UpdateReadControl(m_obj, dwFloorBytes, m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_u32Data,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr32(m_device.Handle,
                                    m_dwBar, m_dwOffset, m_u32Data[0]);
                        }
                        break;
                    }
                case WDC_ADDR_MODE.WDC_MODE_64:
                    {
                        if (bIsRead)
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_ReadAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_u64Data,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_ReadAddr64(m_device.Handle,
                                    m_dwBar, m_dwOffset, ref m_u64Data[0]);
                            m_obj[0] = m_u64Data;
                            UpdateReadControl(m_obj, dwFloorBytes, m_mode);
                        }
                        else
                        {
                            dwStatus = bIsBlock ?
                                wdc_lib_decl.WDC_WriteAddrBlock(m_device.Handle,
                                    m_dwBar, m_dwOffset, dwFloorBytes, m_u64Data,
                                    m_mode, dwOptions) :
                                wdc_lib_decl.WDC_WriteAddr64(m_device.Handle,
                                    m_dwBar, m_dwOffset, m_u64Data[0]);
                        }

                        break;
                    }
            }
        }

        #endregion
        private void comboTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboTransType.SelectedIndex == 0)
            {
                this.checkEditAutoInc.Enabled = true;
                this.textNumBytes.Enabled = true;
            }
            else
            {
                this.checkEditAutoInc.Enabled = false;
                this.textNumBytes.Enabled = false;
            }
        }

    }
}
