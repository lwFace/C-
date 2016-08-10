using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Demo1553
{
    public struct BlockNum
    {
        public int periodNum;
        public int aperiodNum;
    }

    public class BC:Node
    {
        public BindingList<BoundMessage> MsgList;
        private BlockNum _blockNum;
        /*BC配置信息*/
        public BC()
        {
            this.Type = NodeType.BC;
            MsgList = new BindingList<BoundMessage>();
            _blockNum = new BlockNum();
        }
        /// <summary>
        /// 获取BC周期和非周期消息个数
        /// </summary>
        /// <returns>BC周期和非周期消息个数</returns>
        public BlockNum GetBlockNum()
        {
            _blockNum.periodNum = 0;
            _blockNum.aperiodNum = 0;
            foreach (var msg in MsgList)
            {
                if (msg.Period == 0)
                {
                    _blockNum.aperiodNum++;
                }
                else
                {
                    _blockNum.periodNum++;
                }
            }
            return _blockNum;
        }
    }
}
