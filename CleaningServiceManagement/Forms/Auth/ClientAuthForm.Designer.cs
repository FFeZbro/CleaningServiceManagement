namespace CleaningServiceManagement.Forms.Auth
{
    partial class ClientAuthForm
    {
        private DataGridView dgvBookings;
        private Button btnNewBooking;
        private Button btnLogout;
        private Label lblWelcome;

        private void InitializeComponent()
        {
            this.dgvBookings = new DataGridView();
            this.btnNewBooking = new Button();
            this.btnLogout = new Button();
            this.lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();

            // dgvBookings
            this.dgvBookings.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new Point(20, 60);
            this.dgvBookings.Size = new Size(600, 300);
            this.dgvBookings.ReadOnly = true;

            // btnNewBooking
            this.btnNewBooking.Location = new Point(20, 370);
            this.btnNewBooking.Text = "Новая заявка";
            this.btnNewBooking.Click += new EventHandler(this.btnNewBooking_Click);

            // btnLogout
            this.btnLogout.Location = new Point(520, 370);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblWelcome.Location = new Point(20, 20);

            // ClientAuthForm
            this.ClientSize = new Size(640, 420);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.dgvBookings);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "ClientAuthForm";
            this.Text = "Кабинет клиента";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
