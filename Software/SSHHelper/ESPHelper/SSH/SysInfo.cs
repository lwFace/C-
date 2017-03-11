using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESPHelper.SSH
{
    /// <summary>
    /// 系统基本信息结构体
    /// </summary>
    public struct SYS_BASE_INFO
    {
        /// <summary>
        /// 系统类型
        /// </summary>
        public string sysType;
        /// <summary>
        /// 系统名称
        /// </summary>
        public string osName;
        /// <summary>
        /// 处理器类型
        /// </summary>
        public string architecture;
        /// <summary>
        /// 内核版本
        /// </summary>
        public string kernalRelease;
        /// <summary>
        /// 主机名称
        /// </summary>
        public string hostName;
    }
    /// <summary>
    /// 网卡基本信息结构体
    /// </summary>
    public struct SYS_ETH_INFO
    {
        /// <summary>
        /// 网卡IP
        /// </summary>
        public string ethIp;
        /// <summary>
        /// 网卡名称
        /// </summary>
        public string ethName;
        /// <summary>
        /// 网卡链接状态
        /// </summary>
        public bool linked;
    }
    /// <summary>
    /// 获取内存信息
    /// </summary>
    public struct SYS_MEM_INFO
    {
        public uint memTotal;
        public uint memUsed;
        public uint swapTotal;
        public uint swapUsed;
    }

    public struct SYS_DISK_INFO
    {
        public string diskName;
        public uint totalSize;//kb
        public uint usedSize;//kb
    }

    public struct SYS_CPU_INFO
    {
        public uint coreNum;
        public string name;
    }
}
