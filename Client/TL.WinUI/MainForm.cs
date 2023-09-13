using TL.WinUI.Runtime;

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
    }
}