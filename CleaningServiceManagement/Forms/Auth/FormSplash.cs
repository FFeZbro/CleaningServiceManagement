using System;
using System.Windows.Forms;
using CleaningServiceManagement.Services;

namespace CleaningServiceManagement.Forms.Auth
{
    public partial class FormSplash : Form
    {
        private readonly Timer _timer = new Timer();

        public FormSplash()
        {
            InitializeComponent();
            ConfigureTimer();
            CheckDatabase();
        }

        private void ConfigureTimer()
        {
            _timer.Interval = 3000; // 3 секунды
            _timer.Tick += (s, e) =>
            {
                _timer.Stop();
                NavigationService.RedirectTo<FormAuth>();
            };
            _timer.Start();
        }

        private void CheckDatabase()
        {
            try
            {
                DatabaseService.Initialize();
                lblStatus.Text = "Система готова к работе";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Ошибка подключения к БД";
                btnRetry.Visible = true;
                _timer.Stop();
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            btnRetry.Visible = false;
            lblStatus.Text = "Повторное подключение...";
            CheckDatabase();
            _timer.Start();
        }
    }
}
