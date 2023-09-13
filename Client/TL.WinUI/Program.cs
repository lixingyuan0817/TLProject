using System.Configuration;
using TL.WinUI.Runtime;

namespace TL.WinUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            RTContext.LoadContext();
            RTContext.Opacity = 1.00;
            if (RTContext.IsOpacity)
            {
                RTContext.Opacity = double.Parse(ConfigurationManager.AppSettings["Opacity"]);
            }
            Application.Run(new MainForm());
        }
    }
}