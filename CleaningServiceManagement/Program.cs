using System;
using System.Windows.Forms;
using CleaningServiceManagement.Forms.Auth;
using CleaningServiceManagement.Services;

namespace CleaningServiceManagement
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Инициализация конфигурации
            AppConfig.Initialize();

            // Настройка главного потока
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, e) =>
                HandleFatalError(e.Exception);

            try
            {
                // Запуск splash screen с таймаутом из конфига
                var splashTimeout = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SplashScreenTimeout"] ?? "3000");

                using (var splash = new FormSplash(splashTimeout))
                {
                    splash.ShowDialog();
                }

                // Инициализация сервисов
                DatabaseService.Initialize();
                NotificationService.Start();

                // Запуск главной формы аутентификации
                Application.Run(new FormAuth());
            }
            catch (Exception ex)
            {
                HandleFatalError(ex);
            }
            finally
            {
                // Корректное завершение работы
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

    // Вспомогательный класс для работы с конфигом
    public static class AppConfig
    {
        public static void Initialize()
        {
            // Здесь можно добавить дополнительную инициализацию
        }
    }
}
