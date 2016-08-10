using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553
{
    public enum ResourceType { Project,Card, Channel, Node };
    public class BoundResourceBase
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public object Tag { get; set; }
        /// <summary>
        /// 驱动所用ID
        /// </summary>
        private int _resourceId;
        private ResourceType resType;

        /// <summary>
        /// 获取treelist节点类型
        /// </summary>
        /// <returns></returns>
        public ResourceType GetResourceType()
        {
            return resType;
        }

        public void SetResourceType(ResourceType type)
        {
             resType = type;
        }

        public int GetResourceId()
        {
            return _resourceId;
        }
        public void SetResourceId(int id)
        {
            _resourceId = id ;
        }
    }
}
