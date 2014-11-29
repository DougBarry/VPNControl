namespace VPNControl
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.butEGEdit = new System.Windows.Forms.Button();
            this.butEGToggle = new System.Windows.Forms.Button();
            this.butEGRemove = new System.Windows.Forms.Button();
            this.butEGAdd = new System.Windows.Forms.Button();
            this.clstEventGroups = new System.Windows.Forms.CheckedListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActionsEG = new System.Windows.Forms.ComboBox();
            this.butActionsEdit = new System.Windows.Forms.Button();
            this.butActionsToggle = new System.Windows.Forms.Button();
            this.butActionsRemvoe = new System.Windows.Forms.Button();
            this.butActionsAdd = new System.Windows.Forms.Button();
            this.clstActions = new System.Windows.Forms.CheckedListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTriggersEG = new System.Windows.Forms.ComboBox();
            this.butTriggersEdit = new System.Windows.Forms.Button();
            this.butTriggersToggle = new System.Windows.Forms.Button();
            this.butTriggersRemove = new System.Windows.Forms.Button();
            this.butTriggersAdd = new System.Windows.Forms.Button();
            this.clstTriggers = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.butActivate = new System.Windows.Forms.Button();
            this.ButExit = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblBigMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 75);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "L&og to file";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(128, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "&Launch with windows";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "A&ctivate on launch";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "&Minimise to tray on activation";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.butEGEdit);
            this.tabPage3.Controls.Add(this.butEGToggle);
            this.tabPage3.Controls.Add(this.butEGRemove);
            this.tabPage3.Controls.Add(this.butEGAdd);
            this.tabPage3.Controls.Add(this.clstEventGroups);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(560, 325);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "Event groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // butEGEdit
            // 
            this.butEGEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEGEdit.Location = new System.Drawing.Point(320, 290);
            this.butEGEdit.Name = "butEGEdit";
            this.butEGEdit.Size = new System.Drawing.Size(75, 23);
            this.butEGEdit.TabIndex = 11;
            this.butEGEdit.Text = "Ed&it";
            this.butEGEdit.UseVisualStyleBackColor = true;
            this.butEGEdit.Click += new System.EventHandler(this.butEGEdit_Click);
            // 
            // butEGToggle
            // 
            this.butEGToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEGToggle.Location = new System.Drawing.Point(165, 290);
            this.butEGToggle.Name = "butEGToggle";
            this.butEGToggle.Size = new System.Drawing.Size(75, 23);
            this.butEGToggle.TabIndex = 10;
            this.butEGToggle.Text = "&Toggle";
            this.butEGToggle.UseVisualStyleBackColor = true;
            this.butEGToggle.Click += new System.EventHandler(this.butEGToggle_Click);
            // 
            // butEGRemove
            // 
            this.butEGRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEGRemove.Location = new System.Drawing.Point(475, 290);
            this.butEGRemove.Name = "butEGRemove";
            this.butEGRemove.Size = new System.Drawing.Size(75, 23);
            this.butEGRemove.TabIndex = 9;
            this.butEGRemove.Text = "&Remove";
            this.butEGRemove.UseVisualStyleBackColor = true;
            this.butEGRemove.Click += new System.EventHandler(this.butEGRemove_Click);
            // 
            // butEGAdd
            // 
            this.butEGAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEGAdd.Location = new System.Drawing.Point(10, 290);
            this.butEGAdd.Name = "butEGAdd";
            this.butEGAdd.Size = new System.Drawing.Size(75, 23);
            this.butEGAdd.TabIndex = 8;
            this.butEGAdd.Text = "A&dd";
            this.butEGAdd.UseVisualStyleBackColor = true;
            this.butEGAdd.Click += new System.EventHandler(this.butEGAdd_Click);
            // 
            // clstEventGroups
            // 
            this.clstEventGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clstEventGroups.FormattingEnabled = true;
            this.clstEventGroups.Location = new System.Drawing.Point(10, 16);
            this.clstEventGroups.Name = "clstEventGroups";
            this.clstEventGroups.Size = new System.Drawing.Size(530, 259);
            this.clstEventGroups.TabIndex = 7;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.cmbActionsEG);
            this.tabPage6.Controls.Add(this.butActionsEdit);
            this.tabPage6.Controls.Add(this.butActionsToggle);
            this.tabPage6.Controls.Add(this.butActionsRemvoe);
            this.tabPage6.Controls.Add(this.butActionsAdd);
            this.tabPage6.Controls.Add(this.clstActions);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(560, 325);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Actions";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Event group:";
            // 
            // cmbActionsEG
            // 
            this.cmbActionsEG.FormattingEnabled = true;
            this.cmbActionsEG.Location = new System.Drawing.Point(105, 19);
            this.cmbActionsEG.Name = "cmbActionsEG";
            this.cmbActionsEG.Size = new System.Drawing.Size(435, 21);
            this.cmbActionsEG.TabIndex = 7;
            this.cmbActionsEG.SelectedIndexChanged += new System.EventHandler(this.cmbActionsEG_SelectedIndexChanged);
            // 
            // butActionsEdit
            // 
            this.butActionsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butActionsEdit.Location = new System.Drawing.Point(320, 290);
            this.butActionsEdit.Name = "butActionsEdit";
            this.butActionsEdit.Size = new System.Drawing.Size(75, 23);
            this.butActionsEdit.TabIndex = 6;
            this.butActionsEdit.Text = "Ed&it";
            this.butActionsEdit.UseVisualStyleBackColor = true;
            this.butActionsEdit.Click += new System.EventHandler(this.butActionsEdit_Click);
            // 
            // butActionsToggle
            // 
            this.butActionsToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butActionsToggle.Location = new System.Drawing.Point(165, 290);
            this.butActionsToggle.Name = "butActionsToggle";
            this.butActionsToggle.Size = new System.Drawing.Size(75, 23);
            this.butActionsToggle.TabIndex = 5;
            this.butActionsToggle.Text = "&Toggle";
            this.butActionsToggle.UseVisualStyleBackColor = true;
            // 
            // butActionsRemvoe
            // 
            this.butActionsRemvoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butActionsRemvoe.Location = new System.Drawing.Point(475, 290);
            this.butActionsRemvoe.Name = "butActionsRemvoe";
            this.butActionsRemvoe.Size = new System.Drawing.Size(75, 23);
            this.butActionsRemvoe.TabIndex = 4;
            this.butActionsRemvoe.Text = "&Remove";
            this.butActionsRemvoe.UseVisualStyleBackColor = true;
            // 
            // butActionsAdd
            // 
            this.butActionsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butActionsAdd.Location = new System.Drawing.Point(10, 290);
            this.butActionsAdd.Name = "butActionsAdd";
            this.butActionsAdd.Size = new System.Drawing.Size(75, 23);
            this.butActionsAdd.TabIndex = 3;
            this.butActionsAdd.Text = "A&dd";
            this.butActionsAdd.UseVisualStyleBackColor = true;
            this.butActionsAdd.Click += new System.EventHandler(this.butActionsAdd_Click);
            // 
            // clstActions
            // 
            this.clstActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clstActions.FormattingEnabled = true;
            this.clstActions.Location = new System.Drawing.Point(10, 46);
            this.clstActions.Name = "clstActions";
            this.clstActions.Size = new System.Drawing.Size(530, 229);
            this.clstActions.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.cmbTriggersEG);
            this.tabPage7.Controls.Add(this.butTriggersEdit);
            this.tabPage7.Controls.Add(this.butTriggersToggle);
            this.tabPage7.Controls.Add(this.butTriggersRemove);
            this.tabPage7.Controls.Add(this.butTriggersAdd);
            this.tabPage7.Controls.Add(this.clstTriggers);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(560, 325);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Triggers";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Event group:";
            // 
            // cmbTriggersEG
            // 
            this.cmbTriggersEG.FormattingEnabled = true;
            this.cmbTriggersEG.Location = new System.Drawing.Point(105, 19);
            this.cmbTriggersEG.Name = "cmbTriggersEG";
            this.cmbTriggersEG.Size = new System.Drawing.Size(435, 21);
            this.cmbTriggersEG.TabIndex = 11;
            // 
            // butTriggersEdit
            // 
            this.butTriggersEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butTriggersEdit.Location = new System.Drawing.Point(320, 290);
            this.butTriggersEdit.Name = "butTriggersEdit";
            this.butTriggersEdit.Size = new System.Drawing.Size(75, 23);
            this.butTriggersEdit.TabIndex = 10;
            this.butTriggersEdit.Text = "Ed&it";
            this.butTriggersEdit.UseVisualStyleBackColor = true;
            // 
            // butTriggersToggle
            // 
            this.butTriggersToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butTriggersToggle.Location = new System.Drawing.Point(165, 290);
            this.butTriggersToggle.Name = "butTriggersToggle";
            this.butTriggersToggle.Size = new System.Drawing.Size(75, 23);
            this.butTriggersToggle.TabIndex = 9;
            this.butTriggersToggle.Text = "&Toggle";
            this.butTriggersToggle.UseVisualStyleBackColor = true;
            // 
            // butTriggersRemove
            // 
            this.butTriggersRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butTriggersRemove.Location = new System.Drawing.Point(475, 290);
            this.butTriggersRemove.Name = "butTriggersRemove";
            this.butTriggersRemove.Size = new System.Drawing.Size(75, 23);
            this.butTriggersRemove.TabIndex = 8;
            this.butTriggersRemove.Text = "&Remove";
            this.butTriggersRemove.UseVisualStyleBackColor = true;
            // 
            // butTriggersAdd
            // 
            this.butTriggersAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butTriggersAdd.Location = new System.Drawing.Point(10, 290);
            this.butTriggersAdd.Name = "butTriggersAdd";
            this.butTriggersAdd.Size = new System.Drawing.Size(75, 23);
            this.butTriggersAdd.TabIndex = 7;
            this.butTriggersAdd.Text = "A&dd";
            this.butTriggersAdd.UseVisualStyleBackColor = true;
            // 
            // clstTriggers
            // 
            this.clstTriggers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clstTriggers.FormattingEnabled = true;
            this.clstTriggers.Location = new System.Drawing.Point(10, 46);
            this.clstTriggers.Name = "clstTriggers";
            this.clstTriggers.Size = new System.Drawing.Size(530, 229);
            this.clstTriggers.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(560, 325);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(560, 325);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // butActivate
            // 
            this.butActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butActivate.Location = new System.Drawing.Point(497, 427);
            this.butActivate.Name = "butActivate";
            this.butActivate.Size = new System.Drawing.Size(75, 23);
            this.butActivate.TabIndex = 1;
            this.butActivate.Text = "&Activate";
            this.butActivate.UseVisualStyleBackColor = true;
            // 
            // ButExit
            // 
            this.ButExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButExit.Location = new System.Drawing.Point(416, 427);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(75, 23);
            this.ButExit.TabIndex = 2;
            this.ButExit.Text = "E&xit";
            this.ButExit.UseVisualStyleBackColor = true;
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Enabled = false;
            this.chkActive.Location = new System.Drawing.Point(16, 431);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 1;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblBigMessage
            // 
            this.lblBigMessage.AutoSize = true;
            this.lblBigMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigMessage.Location = new System.Drawing.Point(4, 10);
            this.lblBigMessage.Name = "lblBigMessage";
            this.lblBigMessage.Size = new System.Drawing.Size(154, 31);
            this.lblBigMessage.TabIndex = 4;
            this.lblBigMessage.Text = "MESSAGE";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblBigMessage);
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 51);
            this.panel1.TabIndex = 5;
            // 
            // sysTray
            // 
            this.sysTray.Text = "notifyIcon1";
            this.sysTray.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.butActivate);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frmMain";
            this.Text = "VPNControl";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button butActivate;
        private System.Windows.Forms.Button ButExit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button butActionsEdit;
        private System.Windows.Forms.Button butActionsToggle;
        private System.Windows.Forms.Button butActionsRemvoe;
        private System.Windows.Forms.Button butActionsAdd;
        private System.Windows.Forms.CheckedListBox clstActions;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button butTriggersEdit;
        private System.Windows.Forms.Button butTriggersToggle;
        private System.Windows.Forms.Button butTriggersRemove;
        private System.Windows.Forms.Button butTriggersAdd;
        private System.Windows.Forms.CheckedListBox clstTriggers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblBigMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.NotifyIcon sysTray;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button butEGEdit;
        private System.Windows.Forms.Button butEGToggle;
        private System.Windows.Forms.Button butEGRemove;
        private System.Windows.Forms.Button butEGAdd;
        private System.Windows.Forms.CheckedListBox clstEventGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbActionsEG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTriggersEG;

    }
}

