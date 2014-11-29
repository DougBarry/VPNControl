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
    public partial class frmEventGroupEditor : Form
    {
        private string _eventGroupName;

        public string EventGroupName
        {
            get { return _eventGroupName; }
            set { _eventGroupName = value; }
        }
        

        public frmEventGroupEditor()
        {
            InitializeComponent();
        }

        private void frmEventGroupEditor_Load(object sender, EventArgs e)
        {
            Logger.Entry();

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            // save name and close
            _eventGroupName = this.txtEGName.Text;
            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            _eventGroupName = null;
            this.Close();
        }
    }
}
