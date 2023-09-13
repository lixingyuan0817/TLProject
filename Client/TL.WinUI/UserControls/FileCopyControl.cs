namespace TL.WinUI.UserControls
{
    public partial class FileCopyControl : UserControl
    {
        public FileCopyControl(string path)
        {
            InitializeComponent();
            this.PathText.ReadOnly = true;
            this.ContentText.ReadOnly = true;
            this.PathText.Text = path;
            if (File.Exists(path))
            {
                var file = new FileInfo(path);
                using var reader = file.OpenText();
                this.ContentText.Text = reader.ReadToEnd();
            }
            else
            {
                ContentText.Text = "错误的文件路径";
            }
        }
    }
}
