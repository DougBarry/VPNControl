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
    public partial class frmActionAbout : Form
    {
        private VPNCComponentActionAttribute _action = null;

        public frmActionAbout(VPNCComponentActionAttribute attr)
        {
            InitializeComponent();
            this._action = attr;

            this.txtAuthor.Text = attr.Author;
            this.txtDescription.Text = attr.Description;
            this.txtName.Text = attr.HRName;
            this.txtversion.Text = attr.Version;
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = attr.Website;
            this.llWebsite.Links.Add(link);
            this.llWebsite.Text = attr.Website;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            this.Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Logger.Entry();

            this.Close();
        }

        private void frmActionAbout_Load(object sender, EventArgs e)
        {
            Logger.Entry();

        }

        private void llWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logger.Entry();

            // FIXME should probably put in some checks to make sure we dont just execute a system command!
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }
    }
}
