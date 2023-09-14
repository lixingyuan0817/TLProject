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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TransparencyTrackBar = new System.Windows.Forms.TrackBar();
            this.BottomBarPanel = new System.Windows.Forms.Panel();
            this.TLBeforeGroup = new System.Windows.Forms.GroupBox();
            this.TLAfterGroup = new System.Windows.Forms.GroupBox();
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseForm = new System.Windows.Forms.ToolStripButton();
            this.MaxFrom = new System.Windows.Forms.ToolStripButton();
            this.MinForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.CenterContainer = new System.Windows.Forms.SplitContainer();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyTrackBar)).BeginInit();
            this.BottomBarPanel.SuspendLayout();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterContainer)).BeginInit();
            this.CenterContainer.Panel1.SuspendLayout();
            this.CenterContainer.Panel2.SuspendLayout();
            this.CenterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransparencyTrackBar
            // 
            this.TransparencyTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparencyTrackBar.AutoSize = false;
            this.TransparencyTrackBar.Location = new System.Drawing.Point(707, 3);
            this.TransparencyTrackBar.Maximum = 70;
            this.TransparencyTrackBar.Name = "TransparencyTrackBar";
            this.TransparencyTrackBar.Size = new System.Drawing.Size(210, 22);
            this.TransparencyTrackBar.TabIndex = 0;
            this.TransparencyTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TransparencyTrackBar.ValueChanged += new System.EventHandler(this.TransparencyTrackBar_ValueChanged);
            // 
            // BottomBarPanel
            // 
            this.BottomBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomBarPanel.Controls.Add(this.TransparencyTrackBar);
            this.BottomBarPanel.Location = new System.Drawing.Point(0, 417);
            this.BottomBarPanel.Name = "BottomBarPanel";
            this.BottomBarPanel.Size = new System.Drawing.Size(920, 28);
            this.BottomBarPanel.TabIndex = 3;
            // 
            // TLBeforeGroup
            // 
            this.TLBeforeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLBeforeGroup.Location = new System.Drawing.Point(0, 0);
            this.TLBeforeGroup.Name = "TLBeforeGroup";
            this.TLBeforeGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TLBeforeGroup.Size = new System.Drawing.Size(454, 386);
            this.TLBeforeGroup.TabIndex = 0;
            this.TLBeforeGroup.TabStop = false;
            this.TLBeforeGroup.Tag = "翻译前";
            // 
            // TLAfterGroup
            // 
            this.TLAfterGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLAfterGroup.Location = new System.Drawing.Point(0, 0);
            this.TLAfterGroup.Name = "TLAfterGroup";
            this.TLAfterGroup.Size = new System.Drawing.Size(454, 386);
            this.TLAfterGroup.TabIndex = 0;
            this.TLAfterGroup.TabStop = false;
            this.TLAfterGroup.Tag = "翻译后";
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.CloseForm,
            this.MaxFrom,
            this.MinForm,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(920, 25);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            this.MenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseMove);
            this.MenuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseUp);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "选项";
            this.toolStripButton1.ToolTipText = "选项";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CloseForm
            // 
            this.CloseForm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseForm.Image")));
            this.CloseForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseForm.Size = new System.Drawing.Size(36, 22);
            this.CloseForm.Text = "关闭";
            // 
            // MaxFrom
            // 
            this.MaxFrom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MaxFrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MaxFrom.Image = ((System.Drawing.Image)(resources.GetObject("MaxFrom.Image")));
            this.MaxFrom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaxFrom.Name = "MaxFrom";
            this.MaxFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxFrom.Size = new System.Drawing.Size(48, 22);
            this.MaxFrom.Text = "最大化";
            // 
            // MinForm
            // 
            this.MinForm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MinForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MinForm.Image = ((System.Drawing.Image)(resources.GetObject("MinForm.Image")));
            this.MinForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MinForm.Name = "MinForm";
            this.MinForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinForm.Size = new System.Drawing.Size(48, 22);
            this.MinForm.Text = "最小化";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Text = "置顶";
            // 
            // CenterContainer
            // 
            this.CenterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CenterContainer.Location = new System.Drawing.Point(0, 28);
            this.CenterContainer.Margin = new System.Windows.Forms.Padding(6);
            this.CenterContainer.Name = "CenterContainer";
            // 
            // CenterContainer.Panel1
            // 
            this.CenterContainer.Panel1.Controls.Add(this.TLBeforeGroup);
            // 
            // CenterContainer.Panel2
            // 
            this.CenterContainer.Panel2.Controls.Add(this.TLAfterGroup);
            this.CenterContainer.Size = new System.Drawing.Size(920, 390);
            this.CenterContainer.SplitterDistance = 458;
            this.CenterContainer.TabIndex = 4;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "TL";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 445);
            this.Controls.Add(this.CenterContainer);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.BottomBarPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Li.TransactionClient";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyTrackBar)).EndInit();
            this.BottomBarPanel.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.CenterContainer.Panel1.ResumeLayout(false);
            this.CenterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CenterContainer)).EndInit();
            this.CenterContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton MinForm;
        private ToolStripButton MaxFrom;
        private ToolStripButton CloseForm;
    }
}