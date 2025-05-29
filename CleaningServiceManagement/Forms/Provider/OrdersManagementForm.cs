using CleaningServiceManagement.Services;
using System;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Provider
{
    public partial class OrdersManagementForm : Form
    {
        private readonly int _providerId;

        public OrdersManagementForm(int providerId)
        {
            _providerId = providerId;
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            cmbOrders.DataSource = DatabaseService.GetPendingOrders(_providerId);
            cmbOrders.DisplayMember = "OrderDetails";
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedItem == null)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            DatabaseService.UpdateOrderStatus(
                ((Order)cmbOrders.SelectedItem).Id,
                cmbStatus.SelectedItem.ToString()
            );
            LoadOrders();
        }
    }
}
