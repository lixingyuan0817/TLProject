using System.Configuration;

namespace TL.WinUI.Runtime
{
    public class TransparencyManager
    {
        private static TransparencyManager instance;
        private readonly List<Form> registeredForms = new();

        public static TransparencyManager Instance
        {
            get
            {
                instance ??= new TransparencyManager();
                return instance;
            }
        }

        /// <summary>
        /// 注册需要全局透明的窗体
        /// </summary>
        /// <param name="form"></param>
        public void RegisterForm(Form form)
        {
            if (!registeredForms.Contains(form))
            {
                form.Opacity = RTContext.Opacity;
                registeredForms.Add(form);
            }
        }

        /// <summary>
        /// 注销窗体
        /// </summary>
        /// <param name="form"></param>
        public void UnregisterForm(Form form)
        {
            registeredForms.Remove(form);
        }

        /// <summary>
        /// 设置透明度
        /// </summary>
        /// <param name="opacity"></param>
        public void SetTransparency(double opacity)
        {
            if (RTContext.IsOpacity)
            {
                // 修改配置项
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                config.AppSettings.Settings["Opacity"].Value = opacity.ToString();

                // 保存修改
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            foreach (Form form in registeredForms)
            {
                RTContext.Opacity = opacity;
                form.Opacity = RTContext.Opacity;
            }
        }
    }
}
