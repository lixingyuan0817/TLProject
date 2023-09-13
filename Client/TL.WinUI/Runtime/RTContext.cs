using System.Configuration;

namespace TL.WinUI.Runtime
{
    public class RTContext
    {
        #region 是否存储透明度
        private static bool _isOpacity;
        public static bool IsOpacity { get => _isOpacity; private set => _isOpacity = value; }
        public static void SetIsOpacity(bool isOpacity)
        {
            // 修改配置项
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            config.AppSettings.Settings["IsOpacity"].Value = isOpacity.ToString();
            config.AppSettings.Settings["Opacity"].Value = Opacity.ToString();

            // 保存修改
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            _isOpacity = isOpacity;
        }
        #endregion

        #region 透明度
        public static double Opacity { get; set; }
        #endregion

        public static void LoadContext()
        {

        }
    }
}
