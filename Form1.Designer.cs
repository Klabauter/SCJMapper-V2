﻿namespace SCJMapper_V2
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      timer1.Stop( );
      // Unacquire all DirectInput objects.
      foreach ( JoystickCls js in m_JS ) js.FinishDX( );

      if ( disposing && ( components != null ) ) {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.btDumpList = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.rtb = new System.Windows.Forms.RichTextBox();
      this.cmCopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsiCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPReplace = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiSelAll = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.btGrab = new System.Windows.Forms.Button();
      this.btDump = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label56 = new System.Windows.Forms.Label();
      this.label55 = new System.Windows.Forms.Label();
      this.label57 = new System.Windows.Forms.Label();
      this.label54 = new System.Windows.Forms.Label();
      this.cbJs3 = new System.Windows.Forms.ComboBox();
      this.cbJs2 = new System.Windows.Forms.ComboBox();
      this.cbJs1 = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cbxThrottle = new System.Windows.Forms.CheckBox();
      this.btFind = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btClear = new System.Windows.Forms.Button();
      this.lblLastJ = new System.Windows.Forms.Label();
      this.lblAction = new System.Windows.Forms.Label();
      this.btAssign = new System.Windows.Forms.Button();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.IL = new System.Windows.Forms.ImageList(this.components);
      this.tc1 = new System.Windows.Forms.TabControl();
      this.tabJS1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txRebind = new System.Windows.Forms.TextBox();
      this.linkLblReleases = new System.Windows.Forms.LinkLabel();
      this.label8 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonExit = new System.Windows.Forms.Button();
      this.OFD = new System.Windows.Forms.OpenFileDialog();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SFD = new System.Windows.Forms.SaveFileDialog();
      this.tlpanel = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.txFilter = new System.Windows.Forms.TextBox();
      this.btClearFilter = new System.Windows.Forms.Button();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btSettings = new System.Windows.Forms.Button();
      this.cbxBlendUnmapped = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.btSaveMyMapping = new System.Windows.Forms.Button();
      this.btLoadMyMapping = new System.Windows.Forms.Button();
      this.txMappingName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsDDbtProfiles = new System.Windows.Forms.ToolStripDropDownButton();
      this.tsBtReset = new System.Windows.Forms.ToolStripDropDownButton();
      this.resetDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsDDbtMappings = new System.Windows.Forms.ToolStripDropDownButton();
      this.tsBtLoad = new System.Windows.Forms.ToolStripDropDownButton();
      this.defaultsLoadAndGrabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetLoadAndGrabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadAndGrabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.UC_JoyPanel = new SCJMapper_V2.UC_JoyPanel();
      this.cmCopyPaste.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tc1.SuspendLayout();
      this.tabJS1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tlpanel.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btDumpList
      // 
      this.btDumpList.Location = new System.Drawing.Point(3, 33);
      this.btDumpList.Name = "btDumpList";
      this.btDumpList.Size = new System.Drawing.Size(120, 24);
      this.btDumpList.TabIndex = 24;
      this.btDumpList.Text = "Dump List-->";
      this.btDumpList.UseVisualStyleBackColor = true;
      this.btDumpList.Click += new System.EventHandler(this.btDumpList_Click);
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(606, 823);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(372, 36);
      this.label3.TabIndex = 22;
      this.label3.Text = "Right click above to open the context menu";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rtb
      // 
      this.rtb.AcceptsTab = true;
      this.rtb.BackColor = System.Drawing.Color.Ivory;
      this.rtb.ContextMenuStrip = this.cmCopyPaste;
      this.rtb.DetectUrls = false;
      this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtb.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtb.Location = new System.Drawing.Point(606, 81);
      this.rtb.Name = "rtb";
      this.tlpanel.SetRowSpan(this.rtb, 2);
      this.rtb.Size = new System.Drawing.Size(372, 667);
      this.rtb.TabIndex = 21;
      this.rtb.Text = "";
      this.rtb.WordWrap = false;
      // 
      // cmCopyPaste
      // 
      this.cmCopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCopy,
            this.tsiPaste,
            this.tsiPReplace,
            this.tsiSelAll,
            this.toolStripSeparator1,
            this.tsiOpen,
            this.tsiSaveAs});
      this.cmCopyPaste.Name = "cmCopyPaste";
      this.cmCopyPaste.Size = new System.Drawing.Size(170, 142);
      // 
      // tsiCopy
      // 
      this.tsiCopy.Name = "tsiCopy";
      this.tsiCopy.Size = new System.Drawing.Size(169, 22);
      this.tsiCopy.Text = "Copy";
      this.tsiCopy.Click += new System.EventHandler(this.tsiCopy_Click);
      // 
      // tsiPaste
      // 
      this.tsiPaste.Name = "tsiPaste";
      this.tsiPaste.Size = new System.Drawing.Size(169, 22);
      this.tsiPaste.Text = "Paste";
      this.tsiPaste.Click += new System.EventHandler(this.tsiPaste_Click);
      // 
      // tsiPReplace
      // 
      this.tsiPReplace.Name = "tsiPReplace";
      this.tsiPReplace.Size = new System.Drawing.Size(169, 22);
      this.tsiPReplace.Text = "Paste (Replace all)";
      this.tsiPReplace.Click += new System.EventHandler(this.tsiPReplace_Click);
      // 
      // tsiSelAll
      // 
      this.tsiSelAll.Name = "tsiSelAll";
      this.tsiSelAll.Size = new System.Drawing.Size(169, 22);
      this.tsiSelAll.Text = "Select All";
      this.tsiSelAll.Click += new System.EventHandler(this.tsiSelAll_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
      // 
      // tsiOpen
      // 
      this.tsiOpen.Name = "tsiOpen";
      this.tsiOpen.Size = new System.Drawing.Size(169, 22);
      this.tsiOpen.Text = "Open...";
      this.tsiOpen.Click += new System.EventHandler(this.tsiOpen_Click);
      // 
      // tsiSaveAs
      // 
      this.tsiSaveAs.Name = "tsiSaveAs";
      this.tsiSaveAs.Size = new System.Drawing.Size(169, 22);
      this.tsiSaveAs.Text = "Save as...";
      this.tsiSaveAs.Click += new System.EventHandler(this.tsiSaveAs_Click);
      // 
      // btGrab
      // 
      this.btGrab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btGrab.Location = new System.Drawing.Point(171, 3);
      this.btGrab.Name = "btGrab";
      this.btGrab.Size = new System.Drawing.Size(120, 24);
      this.btGrab.TabIndex = 19;
      this.btGrab.Text = "<-- Grab XML";
      this.btGrab.UseVisualStyleBackColor = true;
      this.btGrab.Click += new System.EventHandler(this.btGrab_Click);
      // 
      // btDump
      // 
      this.btDump.Location = new System.Drawing.Point(3, 3);
      this.btDump.Name = "btDump";
      this.btDump.Size = new System.Drawing.Size(120, 24);
      this.btDump.TabIndex = 20;
      this.btDump.Text = "Dump XML-->";
      this.btDump.UseVisualStyleBackColor = true;
      this.btDump.Click += new System.EventHandler(this.btDump_Click);
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.label56);
      this.panel3.Controls.Add(this.label55);
      this.panel3.Controls.Add(this.label57);
      this.panel3.Controls.Add(this.label54);
      this.panel3.Controls.Add(this.cbJs3);
      this.panel3.Controls.Add(this.cbJs2);
      this.panel3.Controls.Add(this.cbJs1);
      this.panel3.Location = new System.Drawing.Point(3, 294);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(289, 118);
      this.panel3.TabIndex = 18;
      // 
      // label56
      // 
      this.label56.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label56.Location = new System.Drawing.Point(7, 89);
      this.label56.Name = "label56";
      this.label56.Size = new System.Drawing.Size(39, 20);
      this.label56.TabIndex = 2;
      this.label56.Text = "js3";
      // 
      // label55
      // 
      this.label55.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label55.Location = new System.Drawing.Point(7, 62);
      this.label55.Name = "label55";
      this.label55.Size = new System.Drawing.Size(39, 20);
      this.label55.TabIndex = 2;
      this.label55.Text = "js2";
      // 
      // label57
      // 
      this.label57.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label57.Location = new System.Drawing.Point(7, 9);
      this.label57.Name = "label57";
      this.label57.Size = new System.Drawing.Size(267, 20);
      this.label57.TabIndex = 2;
      this.label57.Text = "SC-Device to Joystick Mapping";
      // 
      // label54
      // 
      this.label54.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label54.Location = new System.Drawing.Point(7, 35);
      this.label54.Name = "label54";
      this.label54.Size = new System.Drawing.Size(39, 20);
      this.label54.TabIndex = 2;
      this.label54.Text = "js1";
      // 
      // cbJs3
      // 
      this.cbJs3.DisplayMember = "js1";
      this.cbJs3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbJs3.FormattingEnabled = true;
      this.cbJs3.Items.AddRange(new object[] {
            "Joystick 1",
            "Joystick 2",
            "Joystick 3"});
      this.cbJs3.Location = new System.Drawing.Point(52, 86);
      this.cbJs3.MaxDropDownItems = 4;
      this.cbJs3.Name = "cbJs3";
      this.cbJs3.Size = new System.Drawing.Size(233, 25);
      this.cbJs3.TabIndex = 0;
      // 
      // cbJs2
      // 
      this.cbJs2.DisplayMember = "js1";
      this.cbJs2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbJs2.FormattingEnabled = true;
      this.cbJs2.Items.AddRange(new object[] {
            "Joystick 1",
            "Joystick 2",
            "Joystick 3"});
      this.cbJs2.Location = new System.Drawing.Point(52, 59);
      this.cbJs2.MaxDropDownItems = 4;
      this.cbJs2.Name = "cbJs2";
      this.cbJs2.Size = new System.Drawing.Size(233, 25);
      this.cbJs2.TabIndex = 0;
      // 
      // cbJs1
      // 
      this.cbJs1.DisplayMember = "js1";
      this.cbJs1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbJs1.FormattingEnabled = true;
      this.cbJs1.Items.AddRange(new object[] {
            "Joystick 1",
            "Joystick 2",
            "Joystick 3"});
      this.cbJs1.Location = new System.Drawing.Point(52, 32);
      this.cbJs1.MaxDropDownItems = 4;
      this.cbJs1.Name = "cbJs1";
      this.cbJs1.Size = new System.Drawing.Size(233, 25);
      this.cbJs1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.cbxThrottle);
      this.panel2.Controls.Add(this.btFind);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.btClear);
      this.panel2.Controls.Add(this.lblLastJ);
      this.panel2.Controls.Add(this.lblAction);
      this.panel2.Controls.Add(this.btAssign);
      this.panel2.Location = new System.Drawing.Point(3, 418);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(289, 103);
      this.panel2.TabIndex = 17;
      // 
      // cbxThrottle
      // 
      this.cbxThrottle.AutoSize = true;
      this.cbxThrottle.Location = new System.Drawing.Point(110, 72);
      this.cbxThrottle.Name = "cbxThrottle";
      this.cbxThrottle.Size = new System.Drawing.Size(62, 17);
      this.cbxThrottle.TabIndex = 13;
      this.cbxThrottle.Text = "Throttle";
      this.cbxThrottle.UseVisualStyleBackColor = true;
      // 
      // btFind
      // 
      this.btFind.Location = new System.Drawing.Point(190, 37);
      this.btFind.Name = "btFind";
      this.btFind.Size = new System.Drawing.Size(84, 20);
      this.btFind.TabIndex = 12;
      this.btFind.Text = "Find 1st.";
      this.btFind.UseVisualStyleBackColor = true;
      this.btFind.Click += new System.EventHandler(this.btFind_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 37);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(25, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Ctrl.";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 17);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(31, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Cmd.";
      // 
      // btClear
      // 
      this.btClear.Location = new System.Drawing.Point(190, 67);
      this.btClear.Name = "btClear";
      this.btClear.Size = new System.Drawing.Size(94, 25);
      this.btClear.TabIndex = 2;
      this.btClear.Text = "Clear";
      this.btClear.UseVisualStyleBackColor = true;
      this.btClear.Click += new System.EventHandler(this.btClear_Click);
      // 
      // lblLastJ
      // 
      this.lblLastJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblLastJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastJ.Location = new System.Drawing.Point(52, 37);
      this.lblLastJ.Name = "lblLastJ";
      this.lblLastJ.Size = new System.Drawing.Size(135, 20);
      this.lblLastJ.TabIndex = 1;
      this.lblLastJ.Text = "...";
      // 
      // lblAction
      // 
      this.lblAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblAction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAction.Location = new System.Drawing.Point(52, 17);
      this.lblAction.Name = "lblAction";
      this.lblAction.Size = new System.Drawing.Size(222, 20);
      this.lblAction.TabIndex = 1;
      this.lblAction.Text = "...";
      // 
      // btAssign
      // 
      this.btAssign.Location = new System.Drawing.Point(10, 67);
      this.btAssign.Name = "btAssign";
      this.btAssign.Size = new System.Drawing.Size(94, 25);
      this.btAssign.TabIndex = 0;
      this.btAssign.Text = "Assign";
      this.btAssign.UseVisualStyleBackColor = true;
      this.btAssign.Click += new System.EventHandler(this.btAssign_Click);
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView1.HotTracking = true;
      this.treeView1.ImageKey = "Map";
      this.treeView1.ImageList = this.IL;
      this.treeView1.Location = new System.Drawing.Point(6, 81);
      this.treeView1.Name = "treeView1";
      this.tlpanel.SetRowSpan(this.treeView1, 3);
      this.treeView1.SelectedImageKey = "Selected";
      this.treeView1.Size = new System.Drawing.Size(294, 739);
      this.treeView1.TabIndex = 16;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // IL
      // 
      this.IL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL.ImageStream")));
      this.IL.TransparentColor = System.Drawing.Color.Transparent;
      this.IL.Images.SetKeyName(0, "Map");
      this.IL.Images.SetKeyName(1, "Selected");
      this.IL.Images.SetKeyName(2, "J");
      this.IL.Images.SetKeyName(3, "K");
      this.IL.Images.SetKeyName(4, "X");
      this.IL.Images.SetKeyName(5, "P");
      this.IL.Images.SetKeyName(6, "Z");
      // 
      // tc1
      // 
      this.tc1.Controls.Add(this.tabJS1);
      this.tc1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
      this.tc1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc1.HotTrack = true;
      this.tc1.ItemSize = new System.Drawing.Size(62, 20);
      this.tc1.Location = new System.Drawing.Point(3, 3);
      this.tc1.Multiline = true;
      this.tc1.Name = "tc1";
      this.tc1.SelectedIndex = 0;
      this.tc1.Size = new System.Drawing.Size(289, 285);
      this.tc1.TabIndex = 15;
      this.tc1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tc1_DrawItem);
      // 
      // tabJS1
      // 
      this.tabJS1.Controls.Add(this.UC_JoyPanel);
      this.tabJS1.Location = new System.Drawing.Point(4, 24);
      this.tabJS1.Name = "tabJS1";
      this.tabJS1.Padding = new System.Windows.Forms.Padding(3);
      this.tabJS1.Size = new System.Drawing.Size(281, 257);
      this.tabJS1.TabIndex = 0;
      this.tabJS1.Text = "Joystick 1";
      // 
      // panel1
      // 
      this.tlpanel.SetColumnSpan(this.panel1, 3);
      this.panel1.Controls.Add(this.txRebind);
      this.panel1.Controls.Add(this.linkLblReleases);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(6, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(972, 66);
      this.panel1.TabIndex = 14;
      // 
      // txRebind
      // 
      this.txRebind.Location = new System.Drawing.Point(603, 39);
      this.txRebind.Name = "txRebind";
      this.txRebind.Size = new System.Drawing.Size(361, 20);
      this.txRebind.TabIndex = 4;
      this.txRebind.Text = "pp_rebindkeys";
      // 
      // linkLblReleases
      // 
      this.linkLblReleases.AutoSize = true;
      this.linkLblReleases.Location = new System.Drawing.Point(731, 17);
      this.linkLblReleases.Name = "linkLblReleases";
      this.linkLblReleases.Size = new System.Drawing.Size(233, 13);
      this.linkLblReleases.TabIndex = 3;
      this.linkLblReleases.TabStop = true;
      this.linkLblReleases.Text = "For information and updates visit us @ Github ...";
      this.linkLblReleases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblReleases_LinkClicked);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(353, 42);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(54, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "by Cassini";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(226, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(185, 25);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "SC Joystick Mapper";
      // 
      // label4
      // 
      this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
      this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(220, 66);
      this.label4.TabIndex = 0;
      // 
      // buttonExit
      // 
      this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonExit.Location = new System.Drawing.Point(171, 39);
      this.buttonExit.Name = "buttonExit";
      this.buttonExit.Size = new System.Drawing.Size(120, 24);
      this.buttonExit.TabIndex = 13;
      this.buttonExit.Text = "Exit";
      this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
      // 
      // OFD
      // 
      this.OFD.DefaultExt = "xml";
      this.OFD.FileName = "Open Map File";
      this.OFD.Filter = "Mapping files|*.xml|All files|*.*";
      this.OFD.ReadOnlyChecked = true;
      this.OFD.SupportMultiDottedExtensions = true;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // SFD
      // 
      this.SFD.DefaultExt = "xml";
      this.SFD.Filter = "Mapping files|*.xml|Text files|*.txt|All files|*.*";
      this.SFD.SupportMultiDottedExtensions = true;
      // 
      // tlpanel
      // 
      this.tlpanel.ColumnCount = 3;
      this.tlpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
      this.tlpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
      this.tlpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpanel.Controls.Add(this.rtb, 2, 1);
      this.tlpanel.Controls.Add(this.panel1, 0, 0);
      this.tlpanel.Controls.Add(this.label3, 2, 4);
      this.tlpanel.Controls.Add(this.treeView1, 0, 1);
      this.tlpanel.Controls.Add(this.flowLayoutPanel1, 1, 1);
      this.tlpanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
      this.tlpanel.Controls.Add(this.tableLayoutPanel2, 1, 3);
      this.tlpanel.Controls.Add(this.tableLayoutPanel3, 2, 3);
      this.tlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tlpanel.Location = new System.Drawing.Point(0, 0);
      this.tlpanel.Name = "tlpanel";
      this.tlpanel.Padding = new System.Windows.Forms.Padding(3);
      this.tlpanel.RowCount = 5;
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tlpanel.Size = new System.Drawing.Size(984, 862);
      this.tlpanel.TabIndex = 25;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.tc1);
      this.flowLayoutPanel1.Controls.Add(this.panel3);
      this.flowLayoutPanel1.Controls.Add(this.panel2);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(306, 81);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 534);
      this.flowLayoutPanel1.TabIndex = 22;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.btDump, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btGrab, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btDumpList, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.txFilter, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.btClearFilter, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(306, 621);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 127);
      this.tableLayoutPanel1.TabIndex = 23;
      // 
      // txFilter
      // 
      this.txFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txFilter.Location = new System.Drawing.Point(3, 67);
      this.txFilter.Name = "txFilter";
      this.txFilter.Size = new System.Drawing.Size(120, 20);
      this.txFilter.TabIndex = 25;
      this.txFilter.WordWrap = false;
      this.txFilter.TextChanged += new System.EventHandler(this.txFilter_TextChanged);
      // 
      // btClearFilter
      // 
      this.btClearFilter.Location = new System.Drawing.Point(3, 93);
      this.btClearFilter.Name = "btClearFilter";
      this.btClearFilter.Size = new System.Drawing.Size(120, 24);
      this.btClearFilter.TabIndex = 26;
      this.btClearFilter.Text = "Clear Filter";
      this.btClearFilter.UseVisualStyleBackColor = true;
      this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.buttonExit, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.btSettings, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.cbxBlendUnmapped, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(306, 754);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 66);
      this.tableLayoutPanel2.TabIndex = 24;
      // 
      // btSettings
      // 
      this.btSettings.Location = new System.Drawing.Point(3, 39);
      this.btSettings.Name = "btSettings";
      this.btSettings.Size = new System.Drawing.Size(120, 24);
      this.btSettings.TabIndex = 14;
      this.btSettings.Text = "Settings";
      this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
      // 
      // cbxBlendUnmapped
      // 
      this.cbxBlendUnmapped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cbxBlendUnmapped.AutoSize = true;
      this.cbxBlendUnmapped.Location = new System.Drawing.Point(3, 16);
      this.cbxBlendUnmapped.Name = "cbxBlendUnmapped";
      this.cbxBlendUnmapped.Size = new System.Drawing.Size(106, 17);
      this.cbxBlendUnmapped.TabIndex = 15;
      this.cbxBlendUnmapped.Text = "Blend unmapped";
      this.cbxBlendUnmapped.UseVisualStyleBackColor = true;
      this.cbxBlendUnmapped.CheckedChanged += new System.EventHandler(this.cbxBlendUnmapped_CheckedChanged);
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
      this.tableLayoutPanel3.Controls.Add(this.btSaveMyMapping, 1, 1);
      this.tableLayoutPanel3.Controls.Add(this.btLoadMyMapping, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.txMappingName, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(606, 754);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 66);
      this.tableLayoutPanel3.TabIndex = 25;
      // 
      // btSaveMyMapping
      // 
      this.btSaveMyMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btSaveMyMapping.Image = ((System.Drawing.Image)(resources.GetObject("btSaveMyMapping.Image")));
      this.btSaveMyMapping.Location = new System.Drawing.Point(191, 39);
      this.btSaveMyMapping.Name = "btSaveMyMapping";
      this.btSaveMyMapping.Size = new System.Drawing.Size(178, 24);
      this.btSaveMyMapping.TabIndex = 15;
      this.btSaveMyMapping.Text = "Dump and Save my Mapping";
      this.btSaveMyMapping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btSaveMyMapping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btSaveMyMapping.Click += new System.EventHandler(this.btSaveMyMapping_Click);
      // 
      // btLoadMyMapping
      // 
      this.btLoadMyMapping.Location = new System.Drawing.Point(3, 39);
      this.btLoadMyMapping.Name = "btLoadMyMapping";
      this.btLoadMyMapping.Size = new System.Drawing.Size(120, 24);
      this.btLoadMyMapping.TabIndex = 14;
      this.btLoadMyMapping.Text = "Load my Mapping";
      this.btLoadMyMapping.Visible = false;
      this.btLoadMyMapping.Click += new System.EventHandler(this.btLoadMyMapping_Click);
      // 
      // txMappingName
      // 
      this.txMappingName.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.txMappingName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
      this.txMappingName.Location = new System.Drawing.Point(135, 8);
      this.txMappingName.Name = "txMappingName";
      this.txMappingName.Size = new System.Drawing.Size(234, 20);
      this.txMappingName.TabIndex = 0;
      this.txMappingName.WordWrap = false;
      this.txMappingName.TextChanged += new System.EventHandler(this.txMappingName_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(49, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "Mapping name:";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tsDDbtProfiles,
            this.tsBtReset,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.tsDDbtMappings,
            this.tsBtLoad});
      this.statusStrip1.Location = new System.Drawing.Point(0, 832);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.statusStrip1.ShowItemToolTips = true;
      this.statusStrip1.Size = new System.Drawing.Size(984, 30);
      this.statusStrip1.TabIndex = 26;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel2
      // 
      this.toolStripStatusLabel2.BackColor = System.Drawing.Color.DarkKhaki;
      this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 25);
      this.toolStripStatusLabel2.Text = "Profiles:";
      // 
      // tsDDbtProfiles
      // 
      this.tsDDbtProfiles.AutoSize = false;
      this.tsDDbtProfiles.BackColor = System.Drawing.Color.DarkKhaki;
      this.tsDDbtProfiles.Image = ((System.Drawing.Image)(resources.GetObject("tsDDbtProfiles.Image")));
      this.tsDDbtProfiles.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsDDbtProfiles.Name = "tsDDbtProfiles";
      this.tsDDbtProfiles.Size = new System.Drawing.Size(250, 28);
      this.tsDDbtProfiles.Text = "Available Profiles";
      this.tsDDbtProfiles.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsDDbtProfiles_DropDownItemClicked);
      // 
      // tsBtReset
      // 
      this.tsBtReset.AutoSize = false;
      this.tsBtReset.BackColor = System.Drawing.Color.DarkKhaki;
      this.tsBtReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDefaultsToolStripMenuItem,
            this.resetEmptyToolStripMenuItem});
      this.tsBtReset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtReset.Image")));
      this.tsBtReset.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsBtReset.Name = "tsBtReset";
      this.tsBtReset.Size = new System.Drawing.Size(100, 28);
      this.tsBtReset.Text = "Reset...";
      this.tsBtReset.ToolTipText = "Reset with chosen options";
      // 
      // resetDefaultsToolStripMenuItem
      // 
      this.resetDefaultsToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
      this.resetDefaultsToolStripMenuItem.Name = "resetDefaultsToolStripMenuItem";
      this.resetDefaultsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.resetDefaultsToolStripMenuItem.Text = "Reset defaults !";
      this.resetDefaultsToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultsToolStripMenuItem_Click);
      // 
      // resetEmptyToolStripMenuItem
      // 
      this.resetEmptyToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
      this.resetEmptyToolStripMenuItem.Name = "resetEmptyToolStripMenuItem";
      this.resetEmptyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.resetEmptyToolStripMenuItem.Text = "Reset empty !";
      this.resetEmptyToolStripMenuItem.Click += new System.EventHandler(this.resetEmptyToolStripMenuItem_Click);
      // 
      // toolStripStatusLabel3
      // 
      this.toolStripStatusLabel3.AutoSize = false;
      this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 25);
      this.toolStripStatusLabel3.Text = "                            ";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 25);
      this.toolStripStatusLabel1.Text = "Mappings:";
      // 
      // tsDDbtMappings
      // 
      this.tsDDbtMappings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tsDDbtMappings.AutoSize = false;
      this.tsDDbtMappings.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.tsDDbtMappings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsDDbtMappings.Image = ((System.Drawing.Image)(resources.GetObject("tsDDbtMappings.Image")));
      this.tsDDbtMappings.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsDDbtMappings.Name = "tsDDbtMappings";
      this.tsDDbtMappings.Size = new System.Drawing.Size(250, 28);
      this.tsDDbtMappings.Text = "Available Mappings";
      this.tsDDbtMappings.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsDDbtMappings_DropDownItemClicked);
      // 
      // tsBtLoad
      // 
      this.tsBtLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tsBtLoad.AutoSize = false;
      this.tsBtLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.tsBtLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultsLoadAndGrabToolStripMenuItem,
            this.resetLoadAndGrabToolStripMenuItem,
            this.loadAndGrabToolStripMenuItem,
            this.loadToolStripMenuItem});
      this.tsBtLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsBtLoad.Image")));
      this.tsBtLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsBtLoad.Name = "tsBtLoad";
      this.tsBtLoad.Size = new System.Drawing.Size(80, 28);
      this.tsBtLoad.Text = "Load...";
      // 
      // defaultsLoadAndGrabToolStripMenuItem
      // 
      this.defaultsLoadAndGrabToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.defaultsLoadAndGrabToolStripMenuItem.Name = "defaultsLoadAndGrabToolStripMenuItem";
      this.defaultsLoadAndGrabToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.defaultsLoadAndGrabToolStripMenuItem.Text = "Defaults, Load and Grab !";
      this.defaultsLoadAndGrabToolStripMenuItem.Click += new System.EventHandler(this.defaultsLoadAndGrabToolStripMenuItem_Click);
      // 
      // resetLoadAndGrabToolStripMenuItem
      // 
      this.resetLoadAndGrabToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.resetLoadAndGrabToolStripMenuItem.Name = "resetLoadAndGrabToolStripMenuItem";
      this.resetLoadAndGrabToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.resetLoadAndGrabToolStripMenuItem.Text = "Reset, Load and Grab !";
      this.resetLoadAndGrabToolStripMenuItem.Click += new System.EventHandler(this.resetLoadAndGrabToolStripMenuItem_Click);
      // 
      // loadAndGrabToolStripMenuItem
      // 
      this.loadAndGrabToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.loadAndGrabToolStripMenuItem.Name = "loadAndGrabToolStripMenuItem";
      this.loadAndGrabToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.loadAndGrabToolStripMenuItem.Text = "Load and Grab !";
      this.loadAndGrabToolStripMenuItem.Click += new System.EventHandler(this.loadAndGrabToolStripMenuItem_Click);
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.loadToolStripMenuItem.Text = "Load !";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
      // 
      // UC_JoyPanel
      // 
      this.UC_JoyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UC_JoyPanel.Location = new System.Drawing.Point(3, 3);
      this.UC_JoyPanel.Name = "UC_JoyPanel";
      this.UC_JoyPanel.Size = new System.Drawing.Size(275, 251);
      this.UC_JoyPanel.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 862);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tlpanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(1000, 900);
      this.Name = "MainForm";
      this.Text = "SC Joystick Mapper";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.cmCopyPaste.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.tc1.ResumeLayout(false);
      this.tabJS1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tlpanel.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btDumpList;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox rtb;
    private System.Windows.Forms.Button btGrab;
    private System.Windows.Forms.Button btDump;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label56;
    private System.Windows.Forms.Label label55;
    private System.Windows.Forms.Label label57;
    private System.Windows.Forms.Label label54;
    private System.Windows.Forms.ComboBox cbJs3;
    private System.Windows.Forms.ComboBox cbJs2;
    private System.Windows.Forms.ComboBox cbJs1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btFind;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btClear;
    private System.Windows.Forms.Label lblLastJ;
    private System.Windows.Forms.Label lblAction;
    private System.Windows.Forms.Button btAssign;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TabControl tc1;
    private System.Windows.Forms.TabPage tabJS1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.OpenFileDialog OFD;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ContextMenuStrip cmCopyPaste;
    private System.Windows.Forms.ToolStripMenuItem tsiCopy;
    private System.Windows.Forms.ToolStripMenuItem tsiPaste;
    private System.Windows.Forms.ToolStripMenuItem tsiPReplace;
    private System.Windows.Forms.ToolStripMenuItem tsiSelAll;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem tsiOpen;
    private System.Windows.Forms.ToolStripMenuItem tsiSaveAs;
    private System.Windows.Forms.SaveFileDialog SFD;
    private System.Windows.Forms.ImageList IL;
    private UC_JoyPanel UC_JoyPanel;
    private System.Windows.Forms.TableLayoutPanel tlpanel;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripDropDownButton tsDDbtProfiles;
    private System.Windows.Forms.ToolStripDropDownButton tsDDbtMappings;
    private System.Windows.Forms.ToolStripDropDownButton tsBtReset;
    private System.Windows.Forms.ToolStripMenuItem resetDefaultsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetEmptyToolStripMenuItem;
    private System.Windows.Forms.ToolStripDropDownButton tsBtLoad;
    private System.Windows.Forms.ToolStripMenuItem loadAndGrabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetLoadAndGrabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem defaultsLoadAndGrabToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    private System.Windows.Forms.Button btClearFilter;
    private System.Windows.Forms.TextBox txFilter;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btSaveMyMapping;
    private System.Windows.Forms.Button btLoadMyMapping;
    private System.Windows.Forms.TextBox txMappingName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel linkLblReleases;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.CheckBox cbxThrottle;
    private System.Windows.Forms.TextBox txRebind;
    private System.Windows.Forms.Button btSettings;
    private System.Windows.Forms.CheckBox cbxBlendUnmapped;
  }
}

