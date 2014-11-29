using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace VPNControl.Actions
{
    [VPNCComponentAction("Execute program", "Execute a program with optional command line switches", "DougBarry", "1", "https://github.com/dougbarry")]
    class ExecuteProgram : IVPNCAction
    {
        private Settings _settings = null;

        public Settings CurrentSettings
        {
            get { return _settings; }
            set { _settings = value; }
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
        [DefaultProperty("ApplicationExecutable")]
        public class Settings : IVPNCComponentSettings
        {
            string _applicationExecutable;

            [EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]
            [DisplayName("Powershell script")]
            [Description("Full path and filename of powershell script")]
            [Category("Action (required)"), PropertyOrder(10)]
            public string ApplicationEXE
            {
                get { return _applicationExecutable; }
                set { _applicationExecutable = value; }
            }

            string _startIn;

            [DisplayName("Start in")]
            [Description("Directory in which to start the powershell script")]
            [Category("Optional"), PropertyOrder(12)]
            public string StartIn
            {
                get { return _startIn; }
                set { _startIn = value; }
            }

            string _parameters;

            [DisplayName("Parameters")]
            [Description("Text parameters to pass to powershell script")]
            [Category("Optional"), PropertyOrder(10)]
            public string Parameters
            {
                get { return _parameters; }
                set { _parameters = value; }
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
            return "Execute program (" + this.CurrentSettings.ApplicationEXE + ")";
        }
    }
}
