using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553.Class
{
    public class BM:Node
    {
        private bool _isRunning;
        /// <summary>
        /// BM是否在监控状态
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

        public BM()
        {
            this.Type = NodeType.BM;
        }
    }
}
