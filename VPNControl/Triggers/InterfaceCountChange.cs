using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace VPNControl.Triggers
{
    [VPNCComponent("Newtork interface count change","DougBarry","1","https://github.com/dougbarry", VPNCComponentType.Trigger)]
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

    
    }
}
