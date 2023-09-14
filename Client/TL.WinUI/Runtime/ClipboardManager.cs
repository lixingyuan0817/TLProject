using TL.WinUI.UserControls;

namespace TL.WinUI.Runtime
{
    public class ClipboardManager
    {
        public static UserControl GetUserControl()
        {
            var clipboardData = Clipboard.GetDataObject();
            UserControl userControl = null;
            if (clipboardData == null)
            {
                return userControl;
            }
            if (clipboardData.GetDataPresent(DataFormats.FileDrop))
            {
                var data = (string[])clipboardData.GetData(DataFormats.FileDrop, true);
                userControl = new FileCopyControl(data[0]);
                return userControl;
            }
            return userControl;
        }
    }
}
