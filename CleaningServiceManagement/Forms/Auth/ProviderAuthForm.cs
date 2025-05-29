using System;
using System.Data;
using System.Windows.Forms;
using CleaningServiceManagement.Services;

namespace CleaningServiceManagement.Forms.Auth
{
    public partial class ProviderAuthForm : Form
    {
        private int _providerId;

        public ProviderAuthForm(int providerId)
        {
            _providerId = providerId;
            InitializeComponent();
            LoadProviderData();
        }

        private void LoadProviderData()
        {
            try
            {
                // Загрузка данных поставщика
                var services = DatabaseService.GetProviderServices(_providerId);
                var bookings = DatabaseService.GetProviderBookings(_providerId);

                dgvServices.DataSource = services;
                dgvBookings.DataSource = bookings;
                lblWelcome.Text = $"Панель управления поставщика #{_providerId}";
            }
            catch (Exception ex)
            {
                NotificationService.ShowNotification("Ошибка", $"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            // NavigationService.ShowDialog<AddServiceForm>();
            LoadProviderData(); // Обновляем данные после закрытия формы
        }

        private void btnProcessBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow?.DataBoundItem is DataRowView row)
            {
                var bookingId = (int)row["BookingId"];
                // NavigationService.RedirectTo<ProcessBookingForm>(bookingId);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationService.RedirectTo<FormAuth>();
        }
    }
}
