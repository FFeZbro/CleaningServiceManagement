using CleaningServiceManagement.Models;
using CleaningServiceManagement.Services;
using System;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Client
{
    public partial class BookingForm : Form
    {
        private readonly int _clientId;

        public BookingForm(int clientId)
        {
            _clientId = clientId;
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            // Загрузка услуг из БД
            cmbServices.DataSource = DatabaseService.GetAvailableServices();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbServices.SelectedItem == null || dtpDate.Value < DateTime.Today)
            {
                MessageBox.Show("Проверьте введенные данные");
                return;
            }

            DatabaseService.CreateBooking(
                _clientId,
                ((Service)cmbServices.SelectedItem).Id,
                dtpDate.Value
            );
            Close();
        }
    }
}
