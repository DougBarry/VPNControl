using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    public interface IVPNCTrigger:IVPNCComponent
    {

        bool TriggerTest();
    }
}
