using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace VPNControl
{
    public partial class frmActionEditor : Form
    {
        struct ActionAtrributePair
        {
            public VPNCComponentActionAttribute Attrib;
            public Type ObjType;

            public ActionAtrributePair(VPNCComponentActionAttribute attrib, Type objType)
            {
                this.Attrib = attrib;
                this.ObjType = objType;
            }
        }

        VPNCComponentActionAttribute _selectedActionType = null;
        List<ActionAtrributePair> _pairs = new List<ActionAtrributePair>();


        static IEnumerable<Type> GetTypesWithAttribute(Assembly assembly, Type typ)
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(typ, true).Length > 0)
                {
                    yield return type;
                }
            }
        }

        private frmMain _mainForm = null;
        private IVPNCAction _definedAction = null;

        public frmActionEditor(frmMain mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void ActionEditor_Load(object sender, EventArgs e)
        {
            Logger.Entry();

            PopulateAvailableActions();
        }

        private void PopulateAvailableActions()
        {
            Logger.Entry();

            List<Type> types = new List<Type>(GetTypesWithAttribute(Assembly.GetExecutingAssembly(), typeof(VPNCComponentActionAttribute)));

            foreach (Type typ in types)
            {
                VPNCComponentActionAttribute aa = (VPNCComponentActionAttribute)Attribute.GetCustomAttribute(typ, typeof(VPNCComponentActionAttribute));
                cmbActionTypes.Items.Add(new ComboItemAction(aa.HRName, aa));
                _pairs.Add(new ActionAtrributePair(aa,typ));
            }

            cmbActionTypes.Sorted = true;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            // send back object
            _definedAction.LoadSettings((IVPNCComponentSettings) this.pgActionEditor.SelectedObject);

            this._mainForm.SubmitAction(this._definedAction);
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            this.Close();
        }

        private void lnkActionAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logger.Entry();

            if (_selectedActionType == null)
                return;

            frmActionAbout win = new frmActionAbout(_selectedActionType);
            win.ShowDialog();
        }

        private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Entry();

            // get selected item
            if (cmbActionTypes.SelectedIndex < 0)
                return;

            ComboItemAction aa = null;
            try
            {
                aa = (ComboItemAction)cmbActionTypes.SelectedItem;
            }
            catch (Exception ex)
            {
                return;
            }

            if (aa.SourceType == null)
                return;

            _selectedActionType = aa.SourceType;

            if (_selectedActionType == null)
                return;

            // create instance of selected item to get property grid info

            Type actionType = _pairs.Find(o=>o.Attrib.GUID == _selectedActionType.GUID).ObjType;

            if (actionType == null)
                return;

            IVPNCAction action = (IVPNCAction)Activator.CreateInstance(actionType);

            this._definedAction = action;

            this.pgActionEditor.SelectedObject = action.GetAvailableSettings();
        }

    }
}
