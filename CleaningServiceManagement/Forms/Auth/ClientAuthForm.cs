using System;
using System.Data;
using System.Windows.Forms;
using CleaningServiceManagement.Services;

namespace CleaningServiceManagement.Forms.Auth
{
    public partial class ClientAuthForm : Form
    {
        private int _clientId;

        public ClientAuthForm(int clientId)
        {
            _clientId = clientId;
            InitializeComponent();
            LoadClientData();
        }

        private void LoadClientData()
        {
            try
            {
                var bookings = DatabaseService.GetClientBookings(_clientId);
                dgvBookings.DataSource = bookings;
                lblWelcome.Text = $"Добро пожаловать, клиент #{_clientId}";
            }
            catch (Exception ex)
            {
                NotificationService.ShowNotification("Ошибка", $"Не удалось загрузить данные: {ex.Message}");
            }
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            // NavigationService.RedirectTo<NewBookingForm>();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationService.RedirectTo<FormAuth>();
        }
    }
}
