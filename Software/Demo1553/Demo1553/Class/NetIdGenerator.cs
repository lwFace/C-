using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553.Class
{
    public static class NetIdGenerator
    {
        private static List<int> _idList = new List<int>();
        private static readonly int BASE_ID = 10000;
        private static readonly int MAX_NUM = 10000;

        public static void UpdateIdList()
        {
            foreach (var card in CardManager.cards)
            {
                foreach (var chn in card.Value.channels)
                {
                    BC bc = chn.Value.GetBC();
                    foreach (var msg in bc.MsgList)
                    {
                        if (!_idList.Contains(msg.NetId))
                        {
                            _idList.Add(msg.NetId);
                        }
                    }
                    RT rt = chn.Value.GetRT();
                    foreach (var msg in rt.RTMsgList)
                    {
                        if (!_idList.Contains(msg.NetId))
                        {
                            _idList.Add(msg.NetId);
                        }
                    }
                }
            }
        }

        public static int GenerateNetId()
        {
            for (int i = BASE_ID; i < BASE_ID + MAX_NUM; i++)
            {
                if (!_idList.Contains(i))
                {
                    _idList.Add(i);
                    return i;
                }
            }
            return -1;
        }
    }
}
