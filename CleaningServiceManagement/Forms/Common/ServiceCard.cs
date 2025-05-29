using CleaningServiceManagement.Models;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Common
{
    public partial class ServiceCard : UserControl
    {
        private readonly Service _service;

        public ServiceCard(Service service)
        {
            _service = service;
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            lblTitle.Text = _service.Name;
            lblPrice.Text = $"{_service.Price:C2}";
            lblDuration.Text = $"⏱️ {_service.DurationMinutes} мин";
            toolTip.SetToolTip(btnBook, "Забронировать");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Бронирование: {_service.Name}");
        }
    }
}
