using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml;

namespace Demo1553
{
    public class BoundResourceChannel : BoundResourceBase
    {
        //public BindingList<BoundResourceNode> NdList
        //{
        //    get { return ndList; }
        //    set { ndList = value; }
        //} 

        public BoundResourceChannel()
        {
            SetResourceType(ResourceType.Channel);
        }
    }
}
