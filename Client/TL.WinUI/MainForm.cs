using System.Runtime.InteropServices;
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
            //���ش���
            if (this.Visible)
            {
                this.Hide();
            }
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
        /// ˫������ͼ�꼤���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
                this.Activate();
            }
        }


    }
}