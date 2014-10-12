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
    public partial class ActionEditor : Form
    {
        public ActionEditor()
        {
            InitializeComponent();
        }

        private void ActionEditor_Load(object sender, EventArgs e)
        {
            PopulateAvailableActions();
        }

        private void PopulateAvailableActions()
        {
            
        }
    }
}
