using CleaningServiceManagement.Services;
using System.Data;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Client
{
    public partial class OrdersForm : Form
    {
        private readonly int _clientId;

        public OrdersForm(int clientId)
        {
            _clientId = clientId;
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = DatabaseService.GetClientOrders(_clientId);
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
