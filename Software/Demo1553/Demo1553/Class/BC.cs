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

    public class BC : Node
    {
        private bool _isRunning;
        /// <summary>
        /// BC是否在监控状态
        /// </summary>
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                _isRunning = value;
                if (_isRunning == false)
                {
                    MonitorMsgList.Clear();
                }
            }
        }
        /// <summary>
        /// BC消息调度列表
        /// </summary>
        public BindingList<BoundMessage> ScheduMsgList; 
        private BlockNum _blockNum;
        /*BC配置信息*/
        public BC()
        {
            this.Type = NodeType.BC;
            ScheduMsgList = new BindingList<BoundMessage>();
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
            foreach (var msg in ScheduMsgList)
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
