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
            //ע�ᴰ��ȫ��͸����
            transparencyManager.RegisterForm(this);
            // ���ü������ʽ����
            AddClipboardFormatListener(this.Handle);
        }

        #region ���������
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
        /// �ػ淭��ǰ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TLGroup_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;

            using StringFormat stringFormat = new();
            stringFormat.Alignment = StringAlignment.Center; // �ı�ˮƽ����

            // ��ȡGroupBox���ı�
            string text = groupBox.Tag.ToString();

            // �����ı�
            e.Graphics.DrawString(text, groupBox.Font, Brushes.Black, groupBox.ClientRectangle, stringFormat);
        }

        /// <summary>
        /// ������������͸����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransparencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // ��ȡTrackBar�ĵ�ǰֵ������ӳ�䵽����͸���ȷ�Χ
            int trackBarValue = TransparencyTrackBar.Value;
            double opacity = 1.00 - trackBarValue / 100.00; // ��ֵӳ�䵽0.0��0.8�ķ�Χ�����ֵ����Ϊ80%
            transparencyManager.SetTransparency(opacity);
        }

        /// <summary>
        /// ����ͣ��ʱ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            HideForm(true);
        }

        #region �����϶�
        /// <summary>
        /// �Ƿ��϶�
        /// </summary>
        private bool isDragging = false;
        /// <summary>
        /// �϶���ʼλ��
        /// </summary>
        private Point dragStartPosition;

        /// <summary>
        /// ��갴��ʱ���Ϊ�϶�
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
        /// ��ס�����϶�����
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
        /// ֹͣ�϶�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        #endregion

        /// <summary>
        /// ���ش���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_Click(object sender, EventArgs e)
        {
            HideForm(true);
        }

        /// <summary>
        /// ��󻯴���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaxFrom_Click(object sender, EventArgs e)
        {
            var btn = (ToolStripButton)sender;
            if (btn.Text == "���")
            {
                this.WindowState = FormWindowState.Maximized;
                btn.Text = "��ԭ";
                return;
            }
            if (btn.Text == "��ԭ")
            {
                this.WindowState = FormWindowState.Normal;
                btn.Text = "���";
                return;
            }

        }

        /// <summary>
        /// �Ƴ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// �����������ͼ�꼤���
        /// <para>�Ҽ���ʾ�˵�</para>
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
        /// �����ö�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToppingForm_Click(object sender, EventArgs e)
        {
            var btn = (ToolStripButton)sender;
            if (btn.Text == "�ö�")
            {
                RTContext.IsTopping = true;
                btn.Text = "ȡ���ö�";
                return;
            }
            if (btn.Text == "ȡ���ö�")
            {
                RTContext.IsTopping = false;
                btn.Text = "�ö�";
                return;
            }
        }

        /// <summary>
        /// ��ʾ�����ش���
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