using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Demo1553
{
    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CALLBACK_1553
    {
        public int msgId;
        public int src;
        public byte srcAddr;
        public byte subSrcAddr;
        public byte dstAddr;
        public byte subDstAddr;
        public ushort cmd1;
        public ushort cmd2;
        public ushort status1;
        public ushort status2;
        public int sec;
        public int usec;
        public int length;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] payload;
    }

    public delegate void HR_CALLBACK(System.IntPtr pCallbackInfo, System.IntPtr pParam);
   
    public static class Interface1553
    {
        public const string DLL_NAME = "Interface1553.dll";

        [DllImportAttribute(DLL_NAME, EntryPoint = "open", CallingConvention = CallingConvention.Cdecl)]
        public static extern int open(string confStr);

        [DllImportAttribute(DLL_NAME, EntryPoint = "init", CallingConvention = CallingConvention.Cdecl)]
        public static extern int init(string initStr);

        [DllImportAttribute(DLL_NAME, EntryPoint = "start", CallingConvention = CallingConvention.Cdecl)]
        public static extern int start();

        [DllImportAttribute(DLL_NAME, EntryPoint = "stop", CallingConvention = CallingConvention.Cdecl)]
        public static extern int stop();

        [DllImportAttribute(DLL_NAME, EntryPoint = "writeMsg", CallingConvention = CallingConvention.Cdecl)]
        public static extern int writeMsg(int msgId, System.IntPtr pPayload, int nLen);

        [DllImportAttribute(DLL_NAME, EntryPoint = "addListener", CallingConvention = CallingConvention.Cdecl)]
        public static extern void addListener(HR_CALLBACK listener);

        [DllImportAttribute(DLL_NAME, EntryPoint = "close", CallingConvention = CallingConvention.Cdecl)]
        public static extern int close(string confStr);

        [DllImportAttribute(DLL_NAME, EntryPoint = "getLastErr", CallingConvention = CallingConvention.Cdecl)]
        public static extern string getLastErr();

    }
}
