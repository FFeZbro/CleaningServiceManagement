using CleaningServiceManagement.Models;
using CleaningServiceManagement.Services;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Provider
{
    public partial class FormProvider : Form
    {
        private readonly int _providerId;

        public FormProvider(int providerId)
        {
            _providerId = providerId;
            InitializeComponent();
            LoadProviderData();
        }

        private void LoadProviderData()
        {
            lblHeader.Text = $"Поставщик #{_providerId} | {DateTime.Now:dd.MM.yyyy}";
            dgvOrders.DataSource = DatabaseService.GetProviderOrders(_providerId);
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
            => new OrdersManagementForm(_providerId).ShowDialog();

        private void btnRatings_Click(object sender, EventArgs e)
            => new RatingForm(_providerId).ShowDialog();
    }
}
