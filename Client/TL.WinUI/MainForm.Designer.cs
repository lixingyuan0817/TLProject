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
            TransparencyTrackBar = new TrackBar();
            BottomBarPanel = new Panel();
            TLBeforeGroup = new GroupBox();
            TLAfterGroup = new GroupBox();
            TLProcessBar = new ToolStripProgressBar();
            MenuBar = new ToolStrip();
            CenterContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)TransparencyTrackBar).BeginInit();
            BottomBarPanel.SuspendLayout();
            MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CenterContainer).BeginInit();
            CenterContainer.Panel1.SuspendLayout();
            CenterContainer.Panel2.SuspendLayout();
            CenterContainer.SuspendLayout();
            SuspendLayout();
            // 
            // TransparencyTrackBar
            // 
            TransparencyTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TransparencyTrackBar.AutoSize = false;
            TransparencyTrackBar.Location = new Point(1177, 3);
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
            BottomBarPanel.Location = new Point(0, 707);
            BottomBarPanel.Name = "BottomBarPanel";
            BottomBarPanel.Size = new Size(1390, 28);
            BottomBarPanel.TabIndex = 3;
            // 
            // TLBeforeGroup
            // 
            TLBeforeGroup.Dock = DockStyle.Fill;
            TLBeforeGroup.Location = new Point(0, 0);
            TLBeforeGroup.Name = "TLBeforeGroup";
            TLBeforeGroup.Size = new Size(689, 676);
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
            TLAfterGroup.Size = new Size(689, 676);
            TLAfterGroup.TabIndex = 0;
            TLAfterGroup.TabStop = false;
            TLAfterGroup.Tag = "翻译后";
            TLAfterGroup.Paint += TLGroup_Paint;
            // 
            // TLProcessBar
            // 
            TLProcessBar.Alignment = ToolStripItemAlignment.Right;
            TLProcessBar.AutoSize = false;
            TLProcessBar.BackColor = Color.White;
            TLProcessBar.ForeColor = Color.Lime;
            TLProcessBar.Name = "TLProcessBar";
            TLProcessBar.RightToLeftLayout = true;
            TLProcessBar.Size = new Size(550, 22);
            // 
            // MenuBar
            // 
            MenuBar.Items.AddRange(new ToolStripItem[] { TLProcessBar });
            MenuBar.Location = new Point(0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Size = new Size(1390, 25);
            MenuBar.TabIndex = 1;
            // 
            // CenterContainer
            // 
            CenterContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterContainer.BorderStyle = BorderStyle.Fixed3D;
            CenterContainer.Location = new Point(0, 28);
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
            CenterContainer.Size = new Size(1390, 680);
            CenterContainer.SplitterDistance = 693;
            CenterContainer.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 735);
            ControlBox = false;
            Controls.Add(CenterContainer);
            Controls.Add(MenuBar);
            Controls.Add(BottomBarPanel);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "Li.TransactionClient";
            ((System.ComponentModel.ISupportInitialize)TransparencyTrackBar).EndInit();
            BottomBarPanel.ResumeLayout(false);
            MenuBar.ResumeLayout(false);
            MenuBar.PerformLayout();
            CenterContainer.Panel1.ResumeLayout(false);
            CenterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CenterContainer).EndInit();
            CenterContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar TransparencyTrackBar;
        private Panel BottomBarPanel;
        private ToolStripProgressBar TLProcessBar;
        private ToolStrip MenuBar;
        private GroupBox TLBeforeGroup;
        private GroupBox TLAfterGroup;
        private SplitContainer CenterContainer;
    }
}