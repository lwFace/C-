using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datarouter;

namespace com.hirain.avionics.dds
{
    public static class DataTransmit
    {
        public static Payload[] ByteToPayload(byte[] data)
        {
            int len = data.Length;
            Payload[] payload = new Payload[len];
            for (int i = 0; i < len; i++)
            {
                payload[i] = new Payload();
                payload[i]._value = data[i];
            }
            return payload;
        }

        public static byte[] PayloadToByte(Payload[] payload)
        {
            int len = payload.Length;
            byte[] data = new byte[len];
            for (int i = 0; i < len; i++)
            {
                data[i] = payload[i]._value;
            }
            return data;
        }
    }
}
