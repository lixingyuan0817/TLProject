using TL.WinUI.Runtime;
using TL.WinUI.UserControls;

namespace TL.WinUI
{
    public partial class MainForm : Form
    {
        readonly TransparencyManager transparencyManager = TransparencyManager.Instance;
        public MainForm()
        {
            InitializeComponent();
            transparencyManager.RegisterForm(this);
        }

        /// <summary>
        /// 重绘翻译前后组标题居中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TLGroup_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;

            using StringFormat stringFormat = new();
            stringFormat.Alignment = StringAlignment.Center; // 文本水平居中

            // 获取GroupBox的文本
            string text = groupBox.Tag.ToString();

            // 绘制文本
            e.Graphics.DrawString(text, groupBox.Font, Brushes.Black, groupBox.ClientRectangle, stringFormat);
        }

        /// <summary>
        /// 拉动滑块设置透明度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransparencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // 获取TrackBar的当前值，将其映射到窗体透明度范围
            int trackBarValue = TransparencyTrackBar.Value;
            double opacity = 1.00 - trackBarValue / 100.00; // 将值映射到0.0到0.8的范围，最大值限制为80%
            transparencyManager.SetTransparency(opacity);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                TLBeforeGroup.Controls.Clear();
                var userControl = BaseControl.GetUserControl();
                if (userControl != null)
                {
                    userControl.Dock = DockStyle.Fill;
                    TLBeforeGroup.Controls.Add(userControl);
                }
            }
        }
    }
}