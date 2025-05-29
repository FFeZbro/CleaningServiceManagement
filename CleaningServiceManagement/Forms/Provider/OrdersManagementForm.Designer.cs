namespace CleaningServiceManagement.Forms.Provider
{
    partial class OrdersManagementForm
    {
        private ComboBox cmbOrders;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.cmbOrders = new ComboBox();
            this.cmbStatus = new ComboBox();
            this.btnUpdateStatus = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Управление заказами";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;

            // cmbOrders
            this.cmbOrders.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrders.Location = new Point(20, 50);
            this.cmbOrders.Width = 400;

            // cmbStatus
            this.cmbStatus.Items.AddRange(new[] { "Принят", "В работе", "Завершен" });
            this.cmbStatus.Location = new Point(20, 90);

            // btnUpdateStatus
            this.btnUpdateStatus.Text = "Обновить статус";
            this.btnUpdateStatus.Location = new Point(20, 130);
            this.btnUpdateStatus.BackColor = Color.SteelBlue;
            this.btnUpdateStatus.ForeColor = Color.White;

            // OrdersManagementForm
            this.ClientSize = new Size(450, 200);
            this.Controls.AddRange(new Control[] {
                lblTitle, cmbOrders, cmbStatus, btnUpdateStatus
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ResumeLayout(false);
        }
    }
}
