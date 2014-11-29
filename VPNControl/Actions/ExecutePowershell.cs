using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Design;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Management.Automation.Runspaces;
using System.Management.Automation;

namespace VPNControl.Actions
{
    [VPNCComponentAction("Execute powershell", "Execute a powershell script with optional parameters", "DougBarry", "1", "https://github.com/dougbarry")]
    class ExecutePowershell : IVPNCAction
    {
        RunspaceConfiguration _runspaceConfiguration = null;
        Runspace _runspace = null;
        RunspaceInvoke _scriptInvoker = null;


        public void PerformAction()
        {
            Logger.Entry();

            throw new NotImplementedException();

            PSConsoleLoadException pscle;

            this._runspaceConfiguration = RunspaceConfiguration.Create(@"C:\Program Files (x86)\VMware\Infrastructure\vSphere PowerCLI\vim.psc1", out pscle);

            this._runspace = RunspaceFactory.CreateRunspace(this._runspaceConfiguration);
            this._runspace.Open();

            this._scriptInvoker = new RunspaceInvoke(_runspace);

            //using (Pipeline cloneVMPSpipeline = this._runspace.CreatePipeline())
            //{
            //    string targetFolderId = GetFolderIDFromPath(targetFolder);

            //    cloneVMPSpipeline.Commands.AddScript(GetScript("CloneVirtualMachineSingular.ps1"), false);

            //    cloneVMPSpipeline.Commands[0].Parameters.Add(new CommandParameter("SourceVMId", sourceVMId));
            //    cloneVMPSpipeline.Commands[0].Parameters.Add(new CommandParameter("TargetInventoryLocationFolderId", targetFolderId));
            //    cloneVMPSpipeline.Commands[0].Parameters.Add(new CommandParameter("TargetDatastore", targetDatastore));
            //    cloneVMPSpipeline.Commands[0].Parameters.Add(new CommandParameter("TargetHost", targetHost));
            //    cloneVMPSpipeline.Commands[0].Parameters.Add(new CommandParameter("TargetMachineName", targetVMName));

            //    // Execute PowerShell script
            //    Collection<PSObject> results = cloneVMPSpipeline.Invoke();

            //    if (results.Count < 1)
            //    {
            //        // error!
            //        return null;
            //    }

            //    if (results[0] == null)
            //    {
            //        // error
            //        return null;
            //    }

            //    return results[0].ToString();

                //                return true;
            //}


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

        //class CustomFileNameEditor : UITypeEditor
        //{
        //    public CustomFileNameEditor()
        //    {
        //    }

        //    private string _customFilter = "Powershell files (*.ps?)|*.ps?";

        //    [DefaultValue("Powershell files (*.ps?)|*.ps?")]
        //    public string CustomFilter
        //    {
        //        get { return _customFilter; }
        //        set { _customFilter = value; }
        //    }

        //    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        //    {
        //        // We'll show modal dialog (OpenFileDialog)
        //        return UITypeEditorEditStyle.Modal;
        //    }

        //    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        //    {
        //        using (OpenFileDialog dialog = new OpenFileDialog())
        //        {
        //            dialog.Filter = this.CustomFilter;

        //            if (dialog.ShowDialog() == DialogResult.OK)
        //                value = dialog.FileName;
        //        }
        //        return value;
        //    }
        //}


        [TypeConverter(typeof(PropertySorter))]
        [DefaultProperty("ScriptFile")]
        class Settings : IVPNCComponentSettings
        {
            string _scriptFile;

            [EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]
            [DisplayName("Powershell script")]
            [Description("Full path and filename of powershell script")]
            [Category("Action (required)"), PropertyOrder(10)]
            public string ScriptFile
            {
                get { return _scriptFile; }
                set { _scriptFile = value; }
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

            throw new NotImplementedException();
        }
    }
}
