package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/ManagerOperations.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Manager.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public interface ManagerOperations 
{
  Ch.Elca.Iiop.Demo.StorageSystem.Container CreateContainer () throws Ch.Elca.Iiop.GenericUserException;
  Ch.Elca.Iiop.Demo.StorageSystem.Container[] FilterContainers (Ch.Elca.Iiop.Demo.StorageSystem.Entry[] filter) throws Ch.Elca.Iiop.GenericUserException;
} // interface ManagerOperations
