using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace xsd
{
    public class SerializeHelp
    {
        public static string Serialize(System.Type type, object o)
        {
            string result = string.Empty;
            try
            {
                XmlSerializer xs = new XmlSerializer(type);
                MemoryStream ms = new MemoryStream();
                xs.Serialize(ms, o);
                ms.Seek(0, SeekOrigin.Begin);
                StreamReader sr = new StreamReader(ms);
                result = sr.ReadToEnd();
                ms.Close();
            }
            catch (Exception ex)
            {
                // nLogInfo.Write(ex.Message + ex.StackTrace);
            }
            return result;
        }

        public static object Deserialize(System.Type type, string xml)
        {
            object root = new object();
            try
            {
                XmlSerializer xs = new XmlSerializer(type);
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(xml);
                sw.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                root = xs.Deserialize(ms);
                ms.Close();
            }
            catch (Exception ex)
            {
                //   nLogInfo.Write(ex.Message + ex.StackTrace);
            }
            return root;
        }
    }
}
