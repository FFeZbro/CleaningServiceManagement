using CleaningServiceManagement.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Client
{
    public partial class ReviewsForm : Form
    {
        private readonly int _clientId;

        public ReviewsForm(int clientId)
        {
            _clientId = clientId;
            InitializeComponent();
            LoadReviews();
        }

        private void LoadReviews()
        {
            cmbOrders.DataSource = DatabaseService.GetCompletedOrders(_clientId);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedItem == null || ratingControl.Value == 0)
            {
                MessageBox.Show("Выберите заказ и оценку");
                return;
            }

            DatabaseService.AddReview(
                ((DataRowView)cmbOrders.SelectedItem)["OrderId"].ToString(),
                ratingControl.Value,
                txtComment.Text
            );
            Close();
        }
    }
}
