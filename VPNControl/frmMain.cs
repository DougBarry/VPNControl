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

        

        public frmMain()
        {
            Logger.Entry();

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Logger.Entry();

            LoadStartupDefaults();
        }

        private void LoadStartupDefaults()
        {
            Logger.Entry();

            SetMessagedDisabled();
            //Logger.AddLogTarget(rtf box)
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
    }
}
