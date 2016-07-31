using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jungo.wdapi_dotnet;
using wdc_err = Jungo.wdapi_dotnet.WD_ERROR_CODES;
using item_types = Jungo.wdapi_dotnet.ITEM_TYPE;
using UINT64 = System.UInt64;
using UINT32 = System.UInt32;
using DWORD = System.UInt32;
using WORD = System.UInt16;
using BYTE = System.Byte;
using BOOL = System.Boolean;
using WDC_DEVICE_HANDLE = System.IntPtr;
using HANDLE = System.IntPtr;

namespace WDCLibrary
{
    /* PCI diagnostics interrupt handler function type */
    public delegate void USER_INTERRUPT_CALLBACK(HR_Device device);
    public class HR_Device
    {
        private WDC_DEVICE m_wdcDevice = new WDC_DEVICE();
        protected string m_sDeviceLongDesc;
        protected string m_sDeviceShortDesc;
        private HR_REG m_regs;

        #region " properties "
        /*********************
         *  properties       *
         *********************/

        public IntPtr Handle
        {
            get
            {
                return m_wdcDevice.hDev;
            }
            set
            {
                m_wdcDevice.hDev = value;
            }
        }

        protected WDC_DEVICE wdcDevice
        {
            get
            {
                return m_wdcDevice;
            }
            set
            {
                m_wdcDevice = value;
            }
        }

        public WD_PCI_ID id
        {
            get
            {
                return m_wdcDevice.id.pciId;
            }
            set
            {
                m_wdcDevice.id.pciId = value;
            }
        }

        public WD_PCI_SLOT slot
        {
            get
            {
                return m_wdcDevice.slot.pciSlot;
            }
            set
            {
                m_wdcDevice.slot.pciSlot = value;
            }
        }

        public WDC_ADDR_DESC[] AddrDesc
        {
            get
            {
                return m_wdcDevice.pAddrDesc;
            }
            set
            {
                m_wdcDevice.pAddrDesc = value;
            }
        }

        public HR_REG Regs
        {
            get
            {
                return m_regs;
            }
        }

        #endregion
        #region " constructors " 
        /* constructors & destructors */
        internal protected HR_Device(WD_PCI_SLOT slot): this(0, 0, slot){}

        internal protected HR_Device(DWORD dwVendorId, DWORD dwDeviceId,
            WD_PCI_SLOT slot)
        {
            m_wdcDevice = new WDC_DEVICE();
            m_wdcDevice.id.pciId.dwVendorId = dwVendorId;
            m_wdcDevice.id.pciId.dwDeviceId = dwDeviceId;
            m_wdcDevice.slot.pciSlot = slot;
            m_regs = new HR_REG();
            SetDescription();
        } 

        public void Dispose()
        {
            Close();
        }
#endregion

        #region read/write reg
        public DWORD ReadReg_8(WDC_REG reg, ref BYTE data)
        {
            return wdc_lib_decl.WDC_ReadAddr8(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, ref data);
        }
        public DWORD ReadReg_16(WDC_REG reg, ref WORD data)
        {
            return wdc_lib_decl.WDC_ReadAddr16(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, ref data);
        }
        public DWORD ReadReg_32(WDC_REG reg, ref UINT32 data)
        {
            return wdc_lib_decl.WDC_ReadAddr32(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, ref data);
        }
        public DWORD ReadReg_64(WDC_REG reg, ref UINT64 data)
        {
            return wdc_lib_decl.WDC_ReadAddr64(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, ref data);
        }
        public DWORD ReadBlk(WDC_REG reg, byte[] data, UINT32 len,WDC_ADDR_RW_OPTIONS options)
        {
            return wdc_lib_decl.WDC_ReadAddrBlock(Handle, reg.dwAddrSpace, reg.dwOffset, len, data,WDC_ADDR_MODE.WDC_MODE_8 ,options);           
        }
        
        public DWORD WriteReg_8(WDC_REG reg, BYTE data)
        {
            return wdc_lib_decl.WDC_WriteAddr8(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, data);
        }
        public DWORD WriteReg_16(WDC_REG reg, WORD data)
        {
            return wdc_lib_decl.WDC_WriteAddr16(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, data);
        }
        public DWORD WriteReg_32(WDC_REG reg, UINT32 data)
        {
            return wdc_lib_decl.WDC_WriteAddr32(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, data);
        }
        public DWORD WriteReg_64(WDC_REG reg, UINT64 data)
        {
            return wdc_lib_decl.WDC_WriteAddr64(Handle,
                                    reg.dwAddrSpace, reg.dwOffset, data);
        }
        public DWORD WriteBlk(WDC_REG reg, byte[] data, UINT32 len,WDC_ADDR_RW_OPTIONS options)
        {
            return wdc_lib_decl.WDC_WriteAddrBlock(Handle, reg.dwAddrSpace, reg.dwOffset, len, data,WDC_ADDR_MODE.WDC_MODE_8 ,options);           
        }
        #endregion
        #region " Device Open/Close "
        /****************************
         *  Device Open & Close      *
         *****************************/

        /* public methods */

        public virtual DWORD Open()
        {
            DWORD dwStatus;
            WD_PCI_CARD_INFO deviceInfo = new WD_PCI_CARD_INFO();

            /* Retrieve the device's resources information */
            deviceInfo.pciSlot = slot;
            dwStatus = wdc_lib_decl.WDC_PciGetDeviceInfo(deviceInfo);
            if ((DWORD)wdc_err.WD_STATUS_SUCCESS != dwStatus)
            {
                Log.ErrLog("HR_DEVICE.Open: Failed retrieving the "
                    + "device's resources information. Error 0x" +
                    dwStatus.ToString("X") + ": " + utils.Stat2Str(dwStatus) +
                    "(" + this.ToString(false) + ")");
                return dwStatus;
            }

            dwStatus = wdc_lib_decl.WDC_PciDeviceOpen(ref m_wdcDevice,
                deviceInfo, IntPtr.Zero, IntPtr.Zero, "", IntPtr.Zero);

            if ((DWORD)wdc_err.WD_STATUS_SUCCESS != dwStatus)
            {
                Log.ErrLog("HR_DEVICE.Open: Failed opening a " +
                    "WDC device handle. Error 0x" + dwStatus.ToString("X") +
                    ": " + utils.Stat2Str(dwStatus) + "(" +
                    this.ToString(false) + ")");
                goto Error;
            }

            Log.TraceLog("HR_DEVICE.Open: Opened a PCI device " +
                this.ToString(false));

            return dwStatus;
        Error:
            if (Handle != IntPtr.Zero)
                Close();

            return dwStatus;
        }

        public virtual bool Close()
        {
            DWORD dwStatus;

            if (Handle == IntPtr.Zero)
            {
                Log.ErrLog("HR_DEVICE.Close: Error - NULL "
                    + "device handle");
                return false;
            }

            /* Close the device */
            dwStatus = wdc_lib_decl.WDC_PciDeviceClose(Handle);
            if ((DWORD)wdc_err.WD_STATUS_SUCCESS != dwStatus)
            {
                Log.ErrLog("HR_DEVICE.Close: Failed closing a "
                    + "WDC device handle (0x" + Handle.ToInt64().ToString("X")
                    + ". Error 0x" + dwStatus.ToString("X") + ": " +
                    utils.Stat2Str(dwStatus) + this.ToString(false));
            }
            else
            {
                Log.TraceLog("HR_DEVICE.Close: " +
                    this.ToString(false) + " was closed successfully");
            }

            return ((DWORD)wdc_err.WD_STATUS_SUCCESS == dwStatus);
        }

        #endregion
        #region " utilities "
      
        /* protected methods */

        protected void SetDescription()
        {
            m_sDeviceLongDesc = string.Format("HR Device: Vendor ID 0x{0:X}, "
                + "Device ID 0x{1:X}, Physical Location {2:X}:{3:X}:{4:X}",
                id.dwVendorId, id.dwDeviceId, slot.dwBus, slot.dwSlot,
                slot.dwFunction);

            m_sDeviceShortDesc = string.Format("Device " +
                "{0:X},{1:X} {2:X}:{3:X}:{4:X}", id.dwVendorId,
                id.dwDeviceId, slot.dwBus, slot.dwSlot, slot.dwFunction);
        }
        /*public method*/       
        public string[] AddrDescToString(bool bMemOnly)
        {
            string[] sAddr = new string[AddrDesc.Length];
            for (int i = 0; i < sAddr.Length; ++i)
            {
                sAddr[i] = "BAR " +
                    AddrDesc[i].dwAddrSpace.ToString() +
                    ((AddrDesc[i].fIsMemory) ? " Memory " : " I/O ");

                if (wdc_lib_decl.WDC_AddrSpaceIsActive(Handle,
                    AddrDesc[i].dwAddrSpace))
                {
                    WD_ITEMS item =
                        m_wdcDevice.cardReg.Card.Item[AddrDesc[i].dwItemIndex];
                    UINT64 dwAddr = (UINT64)(AddrDesc[i].fIsMemory ?
                        item.I.Mem.dwPhysicalAddr : item.I.IO.dwAddr);

                    sAddr[i] += dwAddr.ToString("X") + " - " +
                        (dwAddr + AddrDesc[i].dwBytes - 1).ToString("X") +
                        " (" + AddrDesc[i].dwBytes.ToString("X") + " bytes)";
                }
                else
                    sAddr[i] += "Inactive address space";
            }
            return sAddr;
        }
        public string ToString(BOOL bLong)
        {
            return (bLong) ? m_sDeviceLongDesc : m_sDeviceShortDesc;
        }
        public bool IsMySlot(ref WD_PCI_SLOT slot)
        {
            if (m_wdcDevice.slot.pciSlot.dwBus == slot.dwBus &&
                m_wdcDevice.slot.pciSlot.dwSlot == slot.dwSlot &&
                m_wdcDevice.slot.pciSlot.dwFunction == slot.dwFunction)
                return true;

            return false;
        }
        #endregion

    }//end of class
    
    
}
