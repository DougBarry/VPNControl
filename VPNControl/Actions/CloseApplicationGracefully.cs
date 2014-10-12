using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace VPNControl.Actions
{
    [VPNCComponent("Close application gracefully","DougBarry","1","https://github.com/dougbarry", VPNCComponentType.Action)]
    internal class CloseApplicationGracefully : IVPNCAction
    {
        private List<string> _applicationMasks = null;
        private bool _exactMatch = false;
        private bool _isRegex = false;

        public void PerformAction()
        {
            Process[] allLocal = Process.GetProcesses();

            foreach (Process p in allLocal)
            {
                foreach (string s in _applicationMasks)
                {
                    if (_isRegex)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(p.ProcessName, s))
                        {
                            p.CloseMainWindow();
                        }
                    }
                    else
                    {
                        if (_exactMatch)
                        {
                            if (p.ProcessName.Equals(s))
                            {
                                // match, send sigterm
                                p.CloseMainWindow();
                            }
                        }
                        else
                        {
                            if (p.ProcessName.Contains(s))
                            {
                                p.CloseMainWindow();
                            }
                        }
                    }
                }

            }
        }

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public void LoadSettings(Dictionary<string, string> settings)
        {
            throw new NotImplementedException();
        }
    }
}