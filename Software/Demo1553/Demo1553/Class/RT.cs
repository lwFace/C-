﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Demo1553
{
    public class RT:Node
    {
        private bool _isRunning;
        /// <summary>
        /// RT是否在监控状态
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

        public BindingList<BoundRTMessage> RTMsgList;
        private bool[] _rtStatus;
        /*RT配置信息*/
        public RT()
        {
            this.Type = NodeType.RT;
            RTMsgList = new BindingList<BoundRTMessage>();
            _rtStatus = new bool[30];
        }

        public void SetRTStatus(int rtAddr, bool bEnable)
        {
            _rtStatus[rtAddr-1] = bEnable;
        }

        public bool[] GetRTStatus()
        {
            return _rtStatus;
        }
    }
}
