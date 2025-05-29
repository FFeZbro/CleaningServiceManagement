using CleaningServiceManagement.Models;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Client
{
    public partial class FormClient : Form
    {
        private readonly int _clientId;

        public FormClient(int clientId)
        {
            _clientId = clientId;
            InitializeComponent();
            LoadClientData();
        }

        private void LoadClientData()
        {
            lblWelcome.Text = $"Клиент #{_clientId} | {DateTime.Now:dd.MM.yyyy}";
        }

        private void btnBookings_Click(object sender, EventArgs e)
            => new BookingForm(_clientId).ShowDialog();

        private void btnOrders_Click(object sender, EventArgs e)
            => new OrdersForm(_clientId).ShowDialog();

        private void btnReviews_Click(object sender, EventArgs e)
            => new ReviewsForm(_clientId).ShowDialog();
    }
}
