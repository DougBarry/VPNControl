using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace VPNControl.Actions
{
    [VPNCComponentAction("uTorrent API function", "Perform uTorrent API function", "DougBarry", "1", "https://github.com/dougbarry")]
    class uTorrentAPI : IVPNCAction
    {
        private Settings _settings = null;

        public Settings CurrentSettings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        public enum uTorrentAction
        {
            TestConnection,
            StopAll,
            PauseAll,
            StartAll,
            ForceStartAll
        }

        public void PerformAction()
        {
            Logger.Entry();

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
            Logger.Entry();

            return new Settings();
        }

        [TypeConverter(typeof(PropertySorter))]
        [DefaultProperty("uTorrentAPIURL")]
        public class Settings : IVPNCComponentSettings
        {
            string _uTorrentAPIURL;

            [DisplayName("uTorrent API URL")]
            [Description("")]
            [Category("Action (required)"), PropertyOrder(12)]
            public string uTorrentAPIURL
            {
                get { return _uTorrentAPIURL; }
                set { _uTorrentAPIURL = value; }
            }

            uTorrentAction _action = uTorrentAction.TestConnection;

            [DisplayName("uTorrent Action Type")]
            [Description("")]
            [Category("Optional"), PropertyOrder(10)]
            public uTorrentAction Parameters
            {
                get { return _action; }
                set { _action = value; }
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
            catch (InvalidCastException e)
            {
                throw e;
            }

            this.CurrentSettings = settingsLoading;
        }

        public override string ToString()
        {
            return "uTorrent API Call (" + this.CurrentSettings.uTorrentAPIURL + ")";
        }
    }
}
