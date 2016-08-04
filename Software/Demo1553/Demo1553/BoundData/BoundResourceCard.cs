using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553
{
    class BoundResourceCard:BoundResourceBase
    {
        //private BindingList<BoundResourceChannel> chnList = new BindingList<BoundResourceChannel>();
        //public BindingList<BoundResourceChannel> ChnList
        //{
        //    get { return chnList; }
        //    set { chnList = value; }
        //} 

        public BoundResourceCard()
        {
            SetResourceType(ResourceType.Card);
        }
    }
}
