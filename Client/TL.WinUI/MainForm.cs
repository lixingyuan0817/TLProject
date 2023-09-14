using System.Runtime.InteropServices;
using TL.WinUI.Runtime;

namespace TL.WinUI
{
    public partial class MainForm : Form
    {
        readonly TransparencyManager transparencyManager = TransparencyManager.Instance;
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //注册窗体全局透明度
            transparencyManager.RegisterForm(this);
            // 启用剪贴板格式监听
            AddClipboardFormatListener(this.Handle);
        }

        #region 剪贴板监听
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AddClipboardFormatListener(IntPtr hwnd);

        const int WM_CLIPBOARDUPDATE = 0x031D;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                this.Show();
                this.Activate();
            }
        }
        #endregion

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

        /// <summary>
        /// 窗体停用时隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            HideForm(true);
        }

        #region 窗口拖动
        /// <summary>
        /// 是否拖动
        /// </summary>
        private bool isDragging = false;
        /// <summary>
        /// 拖动起始位置
        /// </summary>
        private Point dragStartPosition;

        /// <summary>
        /// 鼠标按下时标记为拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPosition = e.Location;
            }
        }

        /// <summary>
        /// 按住不放拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - dragStartPosition.X, currentPos.Y - dragStartPosition.Y);
            }
        }

        /// <summary>
        /// 停止拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        #endregion

        /// <summary>
        /// 隐藏窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_Click(object sender, EventArgs e)
        {
            HideForm(true);
        }

        /// <summary>
        /// 最大化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaxFrom_Click(object sender, EventArgs e)
        {
            var btn = (ToolStripButton)sender;
            if (btn.Text == "最大化")
            {
                this.WindowState = FormWindowState.Maximized;
                btn.Text = "还原";
                return;
            }
            if (btn.Text == "还原")
            {
                this.WindowState = FormWindowState.Normal;
                btn.Text = "最大化";
                return;
            }

        }

        /// <summary>
        /// 推出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 左键单击托盘图标激活窗体
        /// <para>右键显示菜单</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HideForm(false);
            }
        }

        /// <summary>
        /// 窗口置顶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToppingForm_Click(object sender, EventArgs e)
        {
            var btn = (ToolStripButton)sender;
            if (btn.Text == "置顶")
            {
                RTContext.IsTopping = true;
                btn.Text = "取消置顶";
                return;
            }
            if (btn.Text == "取消置顶")
            {
                RTContext.IsTopping = false;
                btn.Text = "置顶";
                return;
            }
        }

        /// <summary>
        /// 显示或隐藏窗体
        /// </summary>
        /// <param name="isHide"></param>
        private void HideForm(bool isHide)
        {
            if (isHide)
            {
                if (this.Visible)
                {
                    this.Hide();
                }
            }
            else
            {
                if (!this.Visible)
                {
                    this.Show();
                    this.Activate();
                }
            }
        }
    }
}