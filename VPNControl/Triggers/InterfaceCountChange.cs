using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace VPNControl.Triggers
{
    [VPNCComponentTrigger("Newtork interface count change","Number of network interfaces changes (increase/decrease)","DougBarry","1","https://github.com/dougbarry")]
    internal class InterfaceCountChange : IVPNCTrigger
    {
        private int _lkInterfaceCount = 0;
        private DateTime _lastCheck = DateTime.MinValue;


        public void Initialise()
        {
            Logger.Entry();

            UpdateNIInfo();
        }

        private void UpdateNIInfo()
        {
            Logger.Entry();

            int nicount = 0;

            NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in nis)
            {
                if (!string.IsNullOrEmpty(ni.Id))
                {
                    nicount++;
                }
            }

            _lkInterfaceCount = nicount;
            _lastCheck = DateTime.Now;
        }

        public void LoadSettings(Dictionary<string, string> settings)
        {
            throw new NotImplementedException();
        }

        public bool TriggerTest()
        {
            Logger.Entry();

            int oldcount = _lkInterfaceCount;
            UpdateNIInfo();
            if (oldcount != _lkInterfaceCount)
            {
                // trigger!
                Logger.Log("Triggered", DebugSeverity.Info);
                return true;
            }
            return false;
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
