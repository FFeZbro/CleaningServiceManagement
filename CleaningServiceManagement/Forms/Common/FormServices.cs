using CleaningServiceManagement.Models;
using CleaningServiceManagement.Services;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Common
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var service in DatabaseService.GetAllServices())
            {
                var card = new ServiceCard(service);
                card.Margin = new Padding(10);
                flowLayoutPanel.Controls.Add(card);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadServices();
    }
}
