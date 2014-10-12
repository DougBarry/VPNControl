using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    public interface IVPNCComponent
    {

        void Initialise();
        void LoadSettings(Dictionary<string,string> settings);

    }
}
