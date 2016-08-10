using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553
{
    public class Card
    {
        public int Id;
        public string Name;
        public int Num;
        public bool IsEnable;

        /*定义通道的Dictionary*/
        public Dictionary<int, Channel> channels;

        public Card()
        {
            IsEnable = false;
            channels = new Dictionary<int, Channel>();
        }

        public Channel GetChannle(int chnId)
        {
            return channels[chnId];
        }

        /// <summary>
        /// 增加通道对象
        /// </summary>
        /// <param name="chnId"></param>
        public void AddChannle(int chnId,Channel channel)
        {
            /*加入到Dictionary*/
            channels.Add(chnId,channel);
        }
    }
}
