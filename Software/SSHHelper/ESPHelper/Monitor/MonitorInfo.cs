using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESPHelper.Monitor
{
    /// <summary>
    /// treeInfo绑定类
    /// </summary>
    class MonitorInfo
    {
        private string m_sName = string.Empty;
    
        private string m_info = string.Empty;

        //子Node节点ID变量
        private int m_iID = -1;

        //父Node节点ID变量
        private int m_iParentID = -1;
        public int ID
        {
            get
            {
                return m_iID;
            }
            set
            {
                m_iID = value;
            }
        }

        public int ParentID
        {
            get
            {
                return m_iParentID;
            }
            set
            {
                m_iParentID = value;
            }
        }

        public string Name
        {
            get
            {
                return m_sName;
            }
            set
            {
                m_sName = value;
            }
        }
        public string Info
        {
            get
            {
                return m_info;
            }
            set
            {
                m_info = value;
            }
        }
    }
}
