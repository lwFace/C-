using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace com.hirain.avionics.dds.igmp
{
    /*


	public class IGMPManager
	{

	  private static java.util.Timer timer;

	  private static IList<IGMPAddr> groups = new List<IGMPAddr>();

	  // private static native int join(String localAddr, String groupAddr);
	  //
	  // private static native int leave(String localAddr, String groupAddr);
	  //
	  // private static native int dispose();
//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern int join_group(string localAddr, string groupAddr);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern int leave_group(string localAddr, string groupAddr);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public static extern int dispose_igmp();

	  static IGMPManager()
	  {
		// try
		// {
		// System.loadLibrary("IgmpDll_x86_64");
		// }
		// catch (Error e)
		// {
		// System.err.println("load 64 bit dll failed.");
		// }
		// try
		// {
		// System.loadLibrary("IgmpDll_x86");
		// }
		// catch (Error e)
		// {
		// System.err.println("load 32 bit dll failed");
		// }
		com.sun.jna.Native.register(loadDll());
	  }

	  public static string loadDll()
	  {
		string fileExtension = ".dll";
		string fileName = com.sun.jna.Platform.is64Bit() ? "IgmpDll_x86_64" : "IgmpDll_x86";
		string fullFileName = fileName + fileExtension;
		string tempPath = System.getProperty("java.io.tmpdir");
		string dllCopyPath = tempPath + fullFileName;

		File dllCopyFile = new File(dllCopyPath);
		if (dllCopyFile.exists())
		{
		  // dllCopyFile.delete();
		  return dllCopyPath;
		}
		else
		{
		  try
		  {
			dllCopyFile.createNewFile();
		  }
		  catch (java.io.IOException e)
		  {
			Console.WriteLine("Create Dll file is fail:" + dllCopyPath);
			Console.WriteLine(e.ToString());
			Console.Write(e.StackTrace);
		  }
		}

		java.io.InputStream inputStream = typeof(IGMPManager).getResourceAsStream(fullFileName);
		java.io.BufferedInputStream bufferedInputStream = new java.io.BufferedInputStream(inputStream);
		try
		{
		  java.io.OutputStream outputStream = new java.io.FileOutputStream(dllCopyFile);
		  sbyte[] buffer = new sbyte[4096];
		  int num = 0;
		  try
		  {
			while (4096 == (num = bufferedInputStream.read(buffer)))
			{
			  outputStream.Write(buffer);
			}
			outputStream.Write(buffer, 0, num);
			inputStream.close();
			bufferedInputStream.close();
			outputStream.close();
		  }
		  catch (java.io.IOException e)
		  {
			Console.WriteLine(e.ToString());
			Console.Write(e.StackTrace);
		  }

		}
		catch (java.io.FileNotFoundException e1)
		{
		  Console.WriteLine(e1.ToString());
		  Console.Write(e1.StackTrace);
		}
		return tempPath + fileName;
	  }

	  public static int joinGroup(string localAddr, string groupAddr)
	  {
		IGMPAddr addr = new IGMPAddr();
		addr.localAddr = localAddr;
		addr.groupAddr = groupAddr;
		if (!groups.Contains(addr))
		{
		  groups.Add(addr);
		}
		return join_group(localAddr, groupAddr);
	  }

	  public static int leaveGroup(string localAddr, string groupAddr)
	  {
		IGMPAddr addr = new IGMPAddr();
		addr.localAddr = localAddr;
		addr.groupAddr = groupAddr;
		groups.Remove(addr);
		return 0;
	  }

	  public static void start()
	  {
		if (timer == null)
		{
		  timer = new java.util.Timer();
//JAVA TO C# CONVERTER TODO TASK: Anonymous inner classes are not converted to C# if the base type is not defined in the code being converted:
//		  timer.schedule(new java.util.TimerTask()
	//	  {
	//
	//		@Override public void run()
	//		{
	//		  for (IGMPAddr addr : groups)
	//		  {
	//			int ret = joinGroup(addr.localAddr, addr.groupAddr);
	//			if (ret != 0)
	//			{
	//			  System.err.println("join group error." + ret);
	//			  int cc = 0;
	//			  while (cc++ < 100)
	//			  {
	//				try
	//				{
	//				  ret = joinGroup(addr.localAddr, addr.groupAddr);
	//				  if (ret != 0)
	//				  {
	//					System.err.println("join group error." + ret);
	//				  }
	//				  else
	//				  {
	//					break;
	//				  }
	//				  Thread.sleep(1000);
	//				}
	//				catch (InterruptedException e)
	//				{
	//				  e.printStackTrace();
	//				}
	//			  }
	//			}
	//		  }
	//		}
	//	  }, 200000, 200000);
		}
	  }

	  public static void stop()
	  {
		if (timer != null)
		{
		  timer.cancel();
		  timer = null;
		}
		dispose_igmp();
	  }
	}
    */
}