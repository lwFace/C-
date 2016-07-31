using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.hirain.avionics.healthmanager
{
    interface  IEventListener
    {
        int ID{get;}

          void handleMsgs(datarouter.EVENT_msg msgs);
    }
}
