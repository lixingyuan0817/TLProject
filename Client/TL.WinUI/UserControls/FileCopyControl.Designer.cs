namespace TL.WinUI.UserControls
{
    partial class FileCopyControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            PathText = new TextBox();
            ContentText = new RichTextBox();
            SuspendLayout();
            // 
            // PathText
            // 
            PathText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PathText.Location = new Point(3, 3);
            PathText.Name = "PathText";
            PathText.Size = new Size(424, 23);
            PathText.TabIndex = 0;
            // 
            // ContentText
            // 
            ContentText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContentText.Location = new Point(3, 32);
            ContentText.Name = "ContentText";
            ContentText.Size = new Size(424, 535);
            ContentText.TabIndex = 1;
            ContentText.Text = "";
            // 
            // FileCopyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentText);
            Controls.Add(PathText);
            Name = "FileCopyControl";
            Size = new Size(430, 570);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PathText;
        private RichTextBox ContentText;
    }
}
