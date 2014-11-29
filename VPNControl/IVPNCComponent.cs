using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VPNControl
{
    public interface IVPNCComponent
    {
        void Initialise();
        void LoadSettings(Dictionary<string,string> settings);
        void LoadSettings(IVPNCComponentSettings properties);
        //string GetAuthor();
        //string GetDescription();
        //string GetWebsite();
        //string GetVersion();
        //string GetName();

        IVPNCComponentSettings GetAvailableSettings();

    }
}
