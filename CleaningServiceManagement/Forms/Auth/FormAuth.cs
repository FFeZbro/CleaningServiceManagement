using System;
using System.Windows.Forms;
using CleaningServiceManagement.Models;
using CleaningServiceManagement.Services;

namespace CleaningServiceManagement.Forms.Auth
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                NotificationService.ShowNotification("Ошибка", "Заполните все поля");
                return;
            }

            try
            {
                var user = DatabaseService.ValidateUser(txtEmail.Text, txtPassword.Text);

                if (user == null)
                {
                    NotificationService.ShowNotification("Ошибка", "Неверные учетные данные");
                    return;
                }

                RedirectByRole(user.Role);
            }
            catch (Exception ex)
            {
                NotificationService.ShowNotification("Ошибка", $"Ошибка авторизации: {ex.Message}");
            }
        }

        private void RedirectByRole(string role)
        {
            switch (role)
            {
                case "Client":
                    NavigationService.RedirectTo<ClientAuthForm>();
                    break;
                case "Provider":
                    NavigationService.RedirectTo<ProviderAuthForm>();
                    break;
                case "Admin":
                    // NavigationService.RedirectTo<AdminDashboardForm>();
                    break;
                default:
                    throw new InvalidOperationException("Неизвестная роль пользователя");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // NavigationService.RedirectTo<FormRegistration>();
        }
    }
}
