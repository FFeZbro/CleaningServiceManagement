namespace CleaningServiceManagement.Forms.Client
{
    partial class FormClient
    {
        private Button btnBookings;
        private Button btnOrders;
        private Button btnReviews;
        private Label lblWelcome;
        private Panel panelMenu;

        private void InitializeComponent()
        {
            this.btnBookings = new Button();
            this.btnOrders = new Button();
            this.btnReviews = new Button();
            this.lblWelcome = new Label();
            this.panelMenu = new Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();

            // panelMenu
            this.panelMenu.BackColor = Color.FromArgb(240, 240, 240);
            this.panelMenu.Controls.Add(this.btnReviews);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnBookings);
            this.panelMenu.Dock = DockStyle.Left;
            this.panelMenu.Width = 200;

            // btnBookings
            this.btnBookings.Text = "Бронирования";
            this.btnBookings.Dock = DockStyle.Top;
            this.btnBookings.Height = 50;
            this.btnBookings.FlatStyle = FlatStyle.Flat;

            // btnOrders
            this.btnOrders.Text = "Мои заказы";
            this.btnOrders.Dock = DockStyle.Top;
            this.btnOrders.Top = 50;

            // btnReviews
            this.btnReviews.Text = "Отзывы";
            this.btnReviews.Dock = DockStyle.Top;
            this.btnReviews.Top = 100;

            // lblWelcome
            this.lblWelcome.Dock = DockStyle.Top;
            this.lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblWelcome.Padding = new Padding(10);

            // FormClient
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelMenu);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
