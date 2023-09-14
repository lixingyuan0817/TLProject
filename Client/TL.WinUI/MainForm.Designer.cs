namespace TL.WinUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TransparencyTrackBar = new TrackBar();
            BottomBarPanel = new Panel();
            TLBeforeGroup = new GroupBox();
            TLAfterGroup = new GroupBox();
            MenuBar = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            CenterContainer = new SplitContainer();
            NotifyIcon = new NotifyIcon(components);
            NotifyMenu = new ContextMenuStrip(components);
            Close = new ToolStripMenuItem();
            TLPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)TransparencyTrackBar).BeginInit();
            BottomBarPanel.SuspendLayout();
            MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CenterContainer).BeginInit();
            CenterContainer.Panel1.SuspendLayout();
            CenterContainer.Panel2.SuspendLayout();
            CenterContainer.SuspendLayout();
            NotifyMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TransparencyTrackBar
            // 
            TransparencyTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TransparencyTrackBar.AutoSize = false;
            TransparencyTrackBar.Location = new Point(933, 3);
            TransparencyTrackBar.Maximum = 70;
            TransparencyTrackBar.Name = "TransparencyTrackBar";
            TransparencyTrackBar.Size = new Size(210, 22);
            TransparencyTrackBar.TabIndex = 0;
            TransparencyTrackBar.TickStyle = TickStyle.None;
            TransparencyTrackBar.ValueChanged += TransparencyTrackBar_ValueChanged;
            // 
            // BottomBarPanel
            // 
            BottomBarPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BottomBarPanel.Controls.Add(TransparencyTrackBar);
            BottomBarPanel.Location = new Point(0, 656);
            BottomBarPanel.Name = "BottomBarPanel";
            BottomBarPanel.Size = new Size(1146, 28);
            BottomBarPanel.TabIndex = 3;
            // 
            // TLBeforeGroup
            // 
            TLBeforeGroup.Dock = DockStyle.Fill;
            TLBeforeGroup.Location = new Point(0, 0);
            TLBeforeGroup.Name = "TLBeforeGroup";
            TLBeforeGroup.RightToLeft = RightToLeft.No;
            TLBeforeGroup.Size = new Size(565, 593);
            TLBeforeGroup.TabIndex = 0;
            TLBeforeGroup.TabStop = false;
            TLBeforeGroup.Tag = "翻译前";
            TLBeforeGroup.Paint += TLGroup_Paint;
            // 
            // TLAfterGroup
            // 
            TLAfterGroup.Dock = DockStyle.Fill;
            TLAfterGroup.Location = new Point(0, 0);
            TLAfterGroup.Name = "TLAfterGroup";
            TLAfterGroup.Size = new Size(569, 593);
            TLAfterGroup.TabIndex = 0;
            TLAfterGroup.TabStop = false;
            TLAfterGroup.Tag = "翻译后";
            TLAfterGroup.Paint += TLGroup_Paint;
            // 
            // MenuBar
            // 
            MenuBar.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1 });
            MenuBar.Location = new Point(0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Size = new Size(1146, 25);
            MenuBar.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 22);
            toolStripButton1.Text = "选项";
            toolStripButton1.ToolTipText = "选项";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // CenterContainer
            // 
            CenterContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterContainer.BorderStyle = BorderStyle.Fixed3D;
            CenterContainer.Location = new Point(0, 60);
            CenterContainer.Margin = new Padding(6);
            CenterContainer.Name = "CenterContainer";
            // 
            // CenterContainer.Panel1
            // 
            CenterContainer.Panel1.Controls.Add(TLBeforeGroup);
            // 
            // CenterContainer.Panel2
            // 
            CenterContainer.Panel2.Controls.Add(TLAfterGroup);
            CenterContainer.Size = new Size(1146, 597);
            CenterContainer.SplitterDistance = 569;
            CenterContainer.TabIndex = 4;
            // 
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = NotifyMenu;
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
            NotifyIcon.Text = "TL";
            NotifyIcon.Visible = true;
            NotifyIcon.MouseClick += NotifyIcon_MouseClick;
            // 
            // NotifyMenu
            // 
            NotifyMenu.Items.AddRange(new ToolStripItem[] { Close });
            NotifyMenu.Name = "NotifyMenu";
            NotifyMenu.Size = new Size(101, 26);
            // 
            // Close
            // 
            Close.Name = "Close";
            Close.Size = new Size(100, 22);
            Close.Text = "退出";
            Close.Click += Close_Click;
            // 
            // TLPanel
            // 
            TLPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TLPanel.Location = new Point(2, 28);
            TLPanel.Name = "TLPanel";
            TLPanel.Size = new Size(1141, 28);
            TLPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 684);
            Controls.Add(TLPanel);
            Controls.Add(CenterContainer);
            Controls.Add(MenuBar);
            Controls.Add(BottomBarPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MainForm";
            Text = "Li.TransactionClient";
            Deactivate += MainForm_Deactivate;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            ((System.ComponentModel.ISupportInitialize)TransparencyTrackBar).EndInit();
            BottomBarPanel.ResumeLayout(false);
            MenuBar.ResumeLayout(false);
            MenuBar.PerformLayout();
            CenterContainer.Panel1.ResumeLayout(false);
            CenterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CenterContainer).EndInit();
            CenterContainer.ResumeLayout(false);
            NotifyMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar TransparencyTrackBar;
        private Panel BottomBarPanel;
        private ToolStrip MenuBar;
        private GroupBox TLBeforeGroup;
        private GroupBox TLAfterGroup;
        private SplitContainer CenterContainer;
        private NotifyIcon NotifyIcon;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton MinForm;
        private ContextMenuStrip NotifyMenu;
        private ToolStripMenuItem Close;
        private Panel TLPanel;
    }
}