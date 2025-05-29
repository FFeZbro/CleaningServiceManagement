using System;
using System.Windows.Forms;
using CleaningServiceManagement.Forms.Auth;
using CleaningServiceManagement.Services;

namespace CleaningServiceManagement
{
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ������������� ������������
            AppConfig.Initialize();

            // ��������� �������� ������
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, e) =>
                HandleFatalError(e.Exception);

            try
            {
                // ������ splash screen � ��������� �� �������
                var splashTimeout = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SplashScreenTimeout"] ?? "3000");

                using (var splash = new FormSplash(splashTimeout))
                {
                    splash.ShowDialog();
                }

                // ������������� ��������
                DatabaseService.Initialize();
                NotificationService.Start();

                // ������ ������� ����� ��������������
                Application.Run(new FormAuth());
            }
            catch (Exception ex)
            {
                HandleFatalError(ex);
            }
            finally
            {
                // ���������� ���������� ������
                NotificationService.Stop();
                DatabaseService.Cleanup();
            }
        }

        private static void HandleFatalError(Exception ex)
        {
            string errorMsg = $"Critical error: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
            MessageBox.Show(errorMsg, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }

    // ��������������� ����� ��� ������ � ��������
    public static class AppConfig
    {
        public static void Initialize()
        {
            // ����� ����� �������� �������������� �������������
        }
    }
}
