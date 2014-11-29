using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VPNControl
{
    public partial class frmMain : Form
    {
        private delegate void WriteToLogDelegate(string logText);
        public delegate void ActionFormSubmitted(IVPNCAction action);

        public event ActionFormSubmitted ActionFormSubmit;


        private List<VPNCEventGroup> _eventGroups = null;
        private List<VPNCEventGroupItem> _actionsList = null;
        private List<VPNCEventGroupItem> _triggersList = null;

        public frmMain()
        {
            Logger.Entry();

            _eventGroups = new List<VPNCEventGroup>();
            _actionsList = new List<VPNCEventGroupItem>();
            _triggersList = new List<VPNCEventGroupItem>();

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Logger.Entry();

            Logger.AddLogTarget(new WriteToLogDelegate(WriteToLog));

            LoadStartupDefaults();
        }

        private void WriteToLog(string text)
        {
            if (this.IsDisposed || this.Disposing)
                return;

            if (this.rtbLog.InvokeRequired)
            {
                WriteToLogDelegate d = new WriteToLogDelegate(WriteToLog);
                this.Invoke(d);
            }

            this.rtbLog.AppendText(text+Environment.NewLine);
        }

        private void LoadStartupDefaults()
        {
            Logger.Entry();

            SetMessagedDisabled();
        }

        private void SetMessagedDisabled()
        {
            Logger.Entry();

            lblBigMessage.ForeColor = Color.Red;
            lblBigMessage.Text = "Disabled";
        }

        private void ButExit_Click(object sender, EventArgs e)
        {
            Logger.Entry();


            Application.Exit();
        }

        private void butEGAdd_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            ShowEventGroupAddDialog();
        }

        private void ShowEventGroupAddDialog(string name = "")
        {
            Logger.Entry();

            bool tryAgain = true;

            using (frmEventGroupEditor ege = new frmEventGroupEditor())
            {

                while (tryAgain == true)
                {
                    ege.EventGroupName = name;

                    DialogResult res = ege.ShowDialog();

                    if (res != System.Windows.Forms.DialogResult.OK)
                        return;

                    name = ege.EventGroupName;

                    if (!string.IsNullOrEmpty(name))
                    {
                        // name set, do stuff
                        // check for duplicate name
                        if ((_eventGroups.Find(o => o.Name.Equals(name)) != null))
                        {
                            // duplicate!
                            MessageBox.Show("Group name \"" + name + "\" already exists");
                            // go back to edit form
                            tryAgain = true;
                        }
                        else
                        {
                            tryAgain = false;
                        }

                    }
                }
                VPNCEventGroup eg = new VPNCEventGroup(name);
                _eventGroups.Add(eg);
                Logger.Log("New event group added: \"" + eg.ToString() + "\""); 
                UpdateEventGroupList();
            }
        }

        private void UpdateEventGroupList()
        {
            Logger.Entry();

            if (this.IsDisposed || this.Disposing)
                return;

            if (this.clstEventGroups.InvokeRequired)
            {
                GenericDelegate d = new GenericDelegate(UpdateEventGroupList);
                this.Invoke(d);
            }
            else
            {
                this.clstEventGroups.BeginUpdate();
                this.cmbActionsEG.BeginUpdate();
                this.cmbTriggersEG.BeginUpdate();

                this.clstEventGroups.Items.Clear();
                this.cmbActionsEG.Items.Clear();
                this.cmbTriggersEG.Items.Clear();

                foreach (VPNCEventGroup eg in _eventGroups)
                {
                    this.clstEventGroups.Items.Add(eg);
                    this.cmbActionsEG.Items.Add(eg);
                    this.cmbTriggersEG.Items.Add(eg);
                }
                this.clstEventGroups.EndUpdate();
                this.cmbActionsEG.EndUpdate();
                this.cmbTriggersEG.EndUpdate();
            }

            if (this.cmbActionsEG.Items.Count > 0)
                if (this.cmbActionsEG.SelectedItem == null)
                    this.cmbActionsEG.SelectedIndex = 0;

            if (this.cmbTriggersEG.Items.Count > 0)
                if (this.cmbTriggersEG.SelectedItem == null)
                    this.cmbTriggersEG.SelectedIndex = 0;
        }

        private void butActionsAdd_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            if (this.cmbActionsEG.SelectedItem == null)
            {
                MessageBox.Show("Select an event group to add actions to.");
                return;
            }

            if (this.IsDisposed || this.Disposing)
                return;

            if (this.clstEventGroups.InvokeRequired)
            {
                GenericDelegate d = new GenericDelegate(ShowActionEditorForm);
                this.Invoke(d);
            }
            else
            {
                ShowActionEditorForm();
            }
        }

        private void ShowActionEditorForm()
        {
            Logger.Entry();

            // if no event groups, error
            if (_eventGroups.Count < 1)
            {
                MessageBox.Show("Please add an event group.");
                return;
            }

            using (frmActionEditor ae = new frmActionEditor(this))
            {
                ae.ShowDialog();
                // result will be added via called method...
            }
        }

        public void SubmitAction(IVPNCAction action)
        {
            Logger.Entry();

            // should be an event group selected...
            if (this._eventGroups.Count < 1)
                return;

            // FIXME
            try
            {
                VPNCEventGroup eg = (VPNCEventGroup)this.cmbActionsEG.SelectedItem;
                this._actionsList.Add(new VPNCEventGroupItem(eg, action));
                Logger.Log("New action \"" + action.ToString() + "\" added to event group \"" + eg.Name + "\"");
            }
            catch (Exception e)
            {
                return;
            }

            // update actions list

            UpdateActionsList();
        }

        private void UpdateActionsList()
        {
            Logger.Entry();

            if (this.cmbActionsEG.SelectedItem == null)
                return;

            if (this.IsDisposed || this.Disposing)
                return;

            if (this.clstEventGroups.InvokeRequired)
            {
                GenericDelegate d = new GenericDelegate(UpdateActionsList);
                this.Invoke(d);
            }
            else
            {
                try
                {

                    this.clstActions.BeginUpdate();
                    this.clstActions.Items.Clear();

                    foreach (VPNCEventGroupItem egi in _actionsList)
                    {
                        if (egi.EventGroup.Equals((VPNCEventGroup)this.cmbActionsEG.SelectedItem))
                        {
                            this.clstActions.Items.Add(egi.Component);
                        }
                    }
                    this.clstActions.EndUpdate();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private void cmbActionsEG_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Entry();

            UpdateActionsList();
        }

        private void butEGEdit_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            // should be an event group selected...
            if (this._eventGroups.Count < 1)
                return;

            if (this.clstEventGroups.SelectedItem == null)
                return;

            VPNCEventGroup eg = null;

            try
            {
                eg = (VPNCEventGroup)this.clstEventGroups.SelectedItem;
            }
            catch (Exception ex)
            {
                return;
            }

            if (eg == null)
                return;

            ShowEventGroupEditDialog(eg);
            UpdateEventGroupList();
        }

        private void ShowEventGroupEditDialog(VPNCEventGroup eventGroup)
        {
            Logger.Entry();

            bool tryAgain = true;

            using (frmEventGroupEditor ege = new frmEventGroupEditor())
            {
                string name = eventGroup.Name;

                while (tryAgain == true)
                {
                    ege.EventGroupName = name;

                    DialogResult res = ege.ShowDialog();

                    if (res != System.Windows.Forms.DialogResult.OK)
                        return;

                    name = ege.EventGroupName;

                    if (!string.IsNullOrEmpty(name))
                    {
                        // name set, do stuff
                        // check for duplicate name
                        if ((_eventGroups.Find(o => o.Name.Equals(name)) != null))
                        {
                            // duplicate!
                            MessageBox.Show("Group name \"" + name + "\" already exists");
                            // go back to edit form
                            tryAgain = true;
                        }
                        else
                        {
                            tryAgain = false;
                        }

                    }
                }

                eventGroup.Name = name;
            }
        }

        private void butEGRemove_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            // should be an event group selected...
            if (this._eventGroups.Count < 1)
                return;

            if (this.clstEventGroups.SelectedItem == null)
                return;

            VPNCEventGroup eg = null;

            try
            {
                eg = (VPNCEventGroup)this.clstEventGroups.SelectedItem;
            }
            catch (Exception ex)
            {
                return;
            }

            if (eg == null)
                return;

            // confirm messagebox
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete event group \"" + eg.Name + "\"? This will remove all child event triggers and actions!");
            if (dr != System.Windows.Forms.DialogResult.OK)
            {
                // abort!
                return;
            }
            else
            {
                string name = eg.Name;
                // big delete time!
                eg.Triggers = null;
                eg.Actions = null;
                _eventGroups.Remove(eg);
                eg = null;

                Logger.Log("Event group and children removed: \"" + name + "\"");
            }

            UpdateEventGroupList();
        }

        private void butEGToggle_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            // should be an event group selected...
            if (this._eventGroups.Count < 1)
                return;

            if (this.clstEventGroups.SelectedItem == null)
                return;

            // FIXME the toggle status is unused!
            this.clstEventGroups.SetItemChecked(this.clstEventGroups.SelectedIndex,!(this.clstEventGroups.GetItemChecked(this.clstEventGroups.SelectedIndex)));

        }

        private void butActionsEdit_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            // if no event groups, error
            if (_eventGroups.Count < 1)
            {
                MessageBox.Show("Please add an event group.");
                return;
            }

            //using (frmActionEditor ae = new frmActionEditor(this))
            //{
            //    ae.ShowDialog();
            //    // result will be added via called event...
            //}

        }


    }
}
