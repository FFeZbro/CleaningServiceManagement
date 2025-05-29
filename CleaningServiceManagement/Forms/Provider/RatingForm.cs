using CleaningServiceManagement.Services;
using System.Data;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Provider
{
    public partial class RatingForm : Form
    {
        private readonly int _providerId;

        public RatingForm(int providerId)
        {
            _providerId = providerId;
            InitializeComponent();
            LoadRatings();
        }

        private void LoadRatings()
        {
            dgvRatings.DataSource = DatabaseService.GetProviderRatings(_providerId);
            lblAverageRating.Text = $"Средний рейтинг: {DatabaseService.GetAverageRating(_providerId):0.0}";
        }
    }
}
