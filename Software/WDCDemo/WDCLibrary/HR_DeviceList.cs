using System;
using System.Collections;

using Jungo.wdapi_dotnet;
using wdc_err = Jungo.wdapi_dotnet.WD_ERROR_CODES;
using DWORD = System.UInt32;
using BOOL = System.Boolean;
using WDC_DRV_OPEN_OPTIONS = System.UInt32; 

namespace WDCLibrary
{
    public class HR_DeviceList : ArrayList
    {
        private string HR_DEFAULT_LICENSE_STRING  = "6C3CC2CFE89E7AD0424A070D434A6F6DC495C274.shen.zhang";
        private string HR_DEFAULT_DRIVER_NAME  = "windrvr6";

        private static HR_DeviceList instance;
        private static bool _initFlag = false;

        public static HR_DeviceList TheDeviceList()
        {
            if (instance == null)
            {
                instance = new HR_DeviceList();
            }
            return instance;
        }

        private HR_DeviceList(){}
        /// <summary>
        /// 初始化Windriver库
        /// </summary>
        /// <returns></returns>
        public DWORD Init()
        {
            if (_initFlag)
            {
                Exception excp = new Exception("HR_DeviceList.Init: " +
                    "Driver library has already loaded!");
                throw excp;
                return (DWORD)wdc_err.WD_OPERATION_ALREADY_DONE;
            }
            if (windrvr_decl.WD_DriverName(HR_DEFAULT_DRIVER_NAME) == null)
            {
                Log.ErrLog("HR_DeviceList.Init: Failed to set driver name for the " +
                    "WDC library.");
                return (DWORD)wdc_err.WD_SYSTEM_INTERNAL_ERROR;
            }  
            
            DWORD dwStatus = wdc_lib_decl.WDC_SetDebugOptions(wdc_lib_consts.WDC_DBG_DEFAULT,
                null);
            if (dwStatus != (DWORD)wdc_err.WD_STATUS_SUCCESS)
            {
                Log.ErrLog("HR_DeviceList.Init: Failed to initialize debug options for the " +
                    "WDC library. Error 0x" + dwStatus.ToString("X") + 
                    utils.Stat2Str(dwStatus));        
                return dwStatus;
            }  
            
            dwStatus = wdc_lib_decl.WDC_DriverOpen(
                (WDC_DRV_OPEN_OPTIONS)wdc_lib_consts.WDC_DRV_OPEN_DEFAULT,
                HR_DEFAULT_LICENSE_STRING);
            if (dwStatus != (DWORD)wdc_err.WD_STATUS_SUCCESS)
            {
                Log.ErrLog("HR_DeviceList.Init: Failed to initialize the WDC library. "
                    + "Error 0x" + dwStatus.ToString("X") + utils.Stat2Str(dwStatus));
                return dwStatus;
            }
            _initFlag = true;
            return dwStatus;
        }
        /// <summary>
        /// 获取设备句柄
        /// </summary>
        /// <param name="index">设备索引号</param>
        /// <returns></returns>
        public HR_Device Get(int index)
        {
            if(index >= this.Count || index < 0)
                return null;
            return (HR_Device)this[index];
        }
        /// <summary>
        /// 获取设备句柄
        /// </summary>
        /// <param name="index">设备卡槽</param>
        /// <returns></returns>
        public HR_Device Get(WD_PCI_SLOT slot)
        {
            foreach(HR_Device device in this)
            {
                if(device.IsMySlot(ref slot))
                    return device;
            }
            return null;
        }
        /// <summary>
        /// 扫描设备
        /// </summary>
        /// <param name="vendorId">设备Vendor ID</param>
        /// <param name="deviceId">设备Device ID</param>
        /// <returns></returns>
        public DWORD Populate(DWORD vendorId, DWORD deviceId)
        {
            DWORD dwStatus;
            WDC_PCI_SCAN_RESULT scanResult = new WDC_PCI_SCAN_RESULT();

            dwStatus = wdc_lib_decl.WDC_PciScanDevices(vendorId,
                deviceId, scanResult);

            if ((DWORD)wdc_err.WD_STATUS_SUCCESS != dwStatus)
            {
                Log.ErrLog("HR_DeviceList.Populate: Failed scanning "
                    + "the PCI bus. Error 0x" + dwStatus.ToString("X") +
                    utils.Stat2Str(dwStatus));
                return dwStatus;
            }

            if (scanResult.dwNumDevices == 0)
            {
                Log.ErrLog("HR_DeviceList.Populate: No matching PCI " +
                    "device was found for search criteria " + vendorId.ToString("X")
                    + ", " + deviceId.ToString("X"));
                return (DWORD)wdc_err.WD_INVALID_PARAMETER;
            }

            for (int i = 0; i < scanResult.dwNumDevices; ++i)
            {
                HR_Device device;
                WD_PCI_SLOT slot = scanResult.deviceSlot[i];

                device = new HR_Device(scanResult.deviceId[i].dwVendorId,
                    scanResult.deviceId[i].dwDeviceId, slot);

                this.Add(device);                                
            }                        
            return (DWORD)wdc_err.WD_STATUS_SUCCESS;
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            if (!_initFlag)
            {
                Exception excp = new Exception("HR_DeviceList.Dispose: " +
                    "Driver library has already disposed!");
                throw excp;
                return;
            }
            foreach (HR_Device device in this)
                device.Dispose();
            this.Clear();

            DWORD dwStatus = wdc_lib_decl.WDC_DriverClose();
            if(dwStatus != (DWORD)wdc_err.WD_STATUS_SUCCESS)
            {
                Exception excp = new Exception("HR_DeviceList.Dispose: " +
                    "Failed to uninit the WDC library. Error 0x" +
                    dwStatus.ToString("X") + utils.Stat2Str(dwStatus));
                throw excp;
            }
            _initFlag = false;
        }
        public bool GetDrvStatus()
        {
            return _initFlag;
        }
    }//end of class
}
