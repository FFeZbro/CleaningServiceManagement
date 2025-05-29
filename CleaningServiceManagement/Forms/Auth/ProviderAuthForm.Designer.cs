namespace CleaningServiceManagement.Forms.Auth
{
    partial class ProviderAuthForm
    {
        private DataGridView dgvServices;
        private DataGridView dgvBookings;
        private Button btnAddService;
        private Button btnProcessBooking;
        private Button btnLogout;
        private TabControl tabControl;

        private void InitializeComponent()
        {
            this.dgvServices = new DataGridView();
            this.dgvBookings = new DataGridView();
            this.btnAddService = new Button();
            this.btnProcessBooking = new Button();
            this.btnLogout = new Button();
            this.tabControl = new TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(new TabPage("Услуги") { Controls = { dgvServices, btnAddService } });
            this.tabControl.Controls.Add(new TabPage("Заказы") { Controls = { dgvBookings, btnProcessBooking } });
            this.tabControl.Location = new Point(10, 10);
            this.tabControl.Size = new Size(780, 400);

            // dgvServices
            this.dgvServices.Dock = DockStyle.Fill;
            this.dgvServices.ReadOnly = true;

            // dgvBookings
            this.dgvBookings.Dock = DockStyle.Fill;

            // btnAddService
            this.btnAddService.Location = new Point(10, 360);
            this.btnAddService.Text = "Добавить услугу";

            // btnProcessBooking
            this.btnProcessBooking.Location = new Point(10, 360);
            this.btnProcessBooking.Text = "Обработать заказ";

            // btnLogout
            this.btnLogout.Location = new Point(700, 420);
            this.btnLogout.Text = "Выйти";

            // ProviderAuthForm
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnLogout);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "ProviderAuthForm";
            this.Text = "Панель поставщика";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
