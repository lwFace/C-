package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/ContainerOperations.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Container.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public interface ContainerOperations 
{
  Ch.Elca.Iiop.Demo.StorageSystem.Entry[] Enumerate () throws Ch.Elca.Iiop.GenericUserException;
  void SetValue (String key, String value) throws Ch.Elca.Iiop.GenericUserException;
  void SetEntry (Ch.Elca.Iiop.Demo.StorageSystem.Entry e) throws Ch.Elca.Iiop.GenericUserException;
  String GetValue (String key) throws Ch.Elca.Iiop.GenericUserException;
} // interface ContainerOperations
