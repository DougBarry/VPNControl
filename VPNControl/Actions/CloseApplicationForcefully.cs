using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Diagnostics;

namespace VPNControl.Actions
{
    [VPNCComponentAction("Close application forcefully", "Close application forcefully by killing the process.", "DougBarry", "1", "https://github.com/dougbarry")]
    class CloseApplicationForcefully : IVPNCAction
    {
        public enum MatchType
        {
            MatchExact,
            MatchSubstring,
            MatchRegex
        }

        private Settings _settings = null;

	    public Settings CurrentSettings
	    {
		    get { return _settings;}
		    set { _settings = value;}
	    }


        public CloseApplicationForcefully()
        {
            this._settings = new Settings();
        }

        public void PerformAction()
        {
            Logger.Entry();

            Process[] allLocal = Process.GetProcesses();

            foreach (Process p in allLocal)
            {
                //foreach (string s in _applicationMasks)
                //{
                string app = this.CurrentSettings.ApplicationEXE;
                string proc = p.ProcessName;

                if (!this.CurrentSettings.CaseSensitive)
                {
                    app = app.ToLower();
                    proc = proc.ToLower();
                }

                switch (this.CurrentSettings.MatchType)
                {
                    case MatchType.MatchRegex:
                        if (System.Text.RegularExpressions.Regex.IsMatch(proc, app))
                        {
                            p.Kill();
                        }
                        break;
                    case MatchType.MatchExact:
                        if (proc.Equals(app.ToLower()))
                        {
                            // match, send sigterm
                            p.Kill();
                        }
                        break;
                    default:
                        if (proc.Contains(app))
                        {
                            p.Kill();
                        }
                        break;
                }
                //}

            } 
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

        public IVPNCComponentSettings GetAvailableSettings()
        {
            Logger.Entry();

            return new Settings();
        }


        [TypeConverter(typeof(PropertySorter))]
        [DefaultProperty("ApplicationEXE")]
        public class Settings : IVPNCComponentSettings
        {
            string _applicationEXE;

            [EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]
            [DisplayName("Application executable mask")]
            [Description("Full path and filename of executable or masked string")]
            [Category("Action (required)"), PropertyOrder(10)]
            public string ApplicationEXE
            {
                get { return _applicationEXE; }
                set { _applicationEXE = value; }
            }

            MatchType _matchType;

            [DisplayName("Match type")]
            [Description("How to treat matching on application executable mask")]
            [Category("Optional"), PropertyOrder(10)]
            public MatchType MatchType
            {
                get { return _matchType; }
                set { _matchType = value; }
            }

            bool _caseSensitive;

            [DisplayName("Case sensitive")]
            [Description("If set to true, match will be case sensitive")]
            [Category("Optional"), PropertyOrder(11)]
            public bool CaseSensitive
            {
                get { return _caseSensitive; }
                set { _caseSensitive = value; }
            }


        }


        public void LoadSettings(IVPNCComponentSettings properties)
        {
            Logger.Entry();

            Settings settingsLoading = null;

            try
            {
                settingsLoading = (Settings)properties;
            }
            catch(InvalidCastException e)
            {
                throw e;
            }

            this.CurrentSettings = settingsLoading;
        }

        public override string ToString()
        {
            return "Close application forcefully (" + this.CurrentSettings.ApplicationEXE + ")";
        }
    }
}
