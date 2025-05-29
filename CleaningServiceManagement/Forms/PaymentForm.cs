using System;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Common
{
    public partial class PaymentForm : Form
    {
        private readonly decimal _amount;

        public PaymentForm(decimal amount)
        {
            _amount = amount;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            lblAmount.Text = $"К оплате: {_amount:C2}";
            cmbMethod.Items.AddRange(new[] { "Карта", "Наличные", "Apple Pay" });
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedItem == null)
            {
                MessageBox.Show("Выберите способ оплаты");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
