namespace CleaningServiceManagement.Forms.Client
{
    partial class OrdersForm
    {
        private DataGridView dgvOrders;

        private void InitializeComponent()
        {
            this.dgvOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.dgvOrders).BeginInit();
            this.SuspendLayout();

            // dgvOrders
            this.dgvOrders.Dock = DockStyle.Fill;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.RowHeadersVisible = false;

            // OrdersForm
            this.ClientSize = new Size(600, 400);
            this.Controls.Add(this.dgvOrders);
            this.StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)this.dgvOrders).EndInit();
            this.ResumeLayout(false);
        }
    }
}
