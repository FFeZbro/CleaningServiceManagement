namespace CleaningServiceManagement.Forms.Provider
{
    partial class FormProvider
    {
        private DataGridView dgvOrders;
        private Button btnManageOrders;
        private Button btnRatings;
        private Label lblHeader;
        private Panel panelSidebar;

        private void InitializeComponent()
        {
            this.dgvOrders = new DataGridView();
            this.btnManageOrders = new Button();
            this.btnRatings = new Button();
            this.lblHeader = new Label();
            this.panelSidebar = new Panel();
            ((System.ComponentModel.ISupportInitialize)this.dgvOrders).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();

            // panelSidebar
            this.panelSidebar.BackColor = Color.FromArgb(240, 240, 240);
            this.panelSidebar.Controls.Add(this.btnRatings);
            this.panelSidebar.Controls.Add(this.btnManageOrders);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 150;

            // btnManageOrders
            this.btnManageOrders.Text = "Управление заказами";
            this.btnManageOrders.Dock = DockStyle.Top;
            this.btnManageOrders.Height = 50;
            this.btnManageOrders.FlatStyle = FlatStyle.Flat;

            // btnRatings
            this.btnRatings.Text = "Рейтинги";
            this.btnRatings.Dock = DockStyle.Top;
            this.btnRatings.Top = 50;

            // dgvOrders
            this.dgvOrders.Dock = DockStyle.Fill;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // lblHeader
            this.lblHeader.Dock = DockStyle.Top;
            this.lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHeader.Padding = new Padding(10);
            this.lblHeader.BackColor = Color.SteelBlue;
            this.lblHeader.ForeColor = Color.White;

            // FormProvider
            this.ClientSize = new Size(900, 500);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panelSidebar);
            ((System.ComponentModel.ISupportInitialize)this.dgvOrders).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
