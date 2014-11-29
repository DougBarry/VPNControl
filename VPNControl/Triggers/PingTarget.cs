using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl.Triggers
{
    [VPNCComponentTrigger("Newtork ping target condition","Ping a host and test the response condition", "DougBarry", "1", "https://github.com/dougbarry")]
    class PingTarget : IVPNCTrigger
    {
        public bool TriggerTest()
        {
            throw new NotImplementedException();
        }

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public void LoadSettings(Dictionary<string, string> settings)
        {
            throw new NotImplementedException();
        }


        public string GetAuthor()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public string GetWebsite()
        {
            throw new NotImplementedException();
        }

        public string GetVersion()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public IVPNCComponentSettings GetAvailableSettings()
        {
            throw new NotImplementedException();
        }


        public void LoadSettings(IVPNCComponentSettings properties)
        {
            throw new NotImplementedException();
        }
    }
}
