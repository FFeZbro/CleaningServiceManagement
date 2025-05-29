namespace CleaningServiceManagement.Forms.Provider
{
    partial class RatingForm
    {
        private DataGridView dgvRatings;
        private Label lblAverageRating;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.dgvRatings = new DataGridView();
            this.lblAverageRating = new Label();
            this.lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)this.dgvRatings).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Отзывы клиентов";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;

            // dgvRatings
            this.dgvRatings.Dock = DockStyle.Fill;
            this.dgvRatings.ReadOnly = true;
            this.dgvRatings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRatings.Top = 40;

            // lblAverageRating
            this.lblAverageRating.Dock = DockStyle.Bottom;
            this.lblAverageRating.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAverageRating.TextAlign = ContentAlignment.MiddleRight;
            this.lblAverageRating.Padding = new Padding(0, 0, 20, 10);

            // RatingForm
            this.ClientSize = new Size(600, 400);
            this.Controls.Add(this.dgvRatings);
            this.Controls.Add(this.lblAverageRating);
            this.Controls.Add(this.lblTitle);
            ((System.ComponentModel.ISupportInitialize)this.dgvRatings).EndInit();
            this.ResumeLayout(false);
        }
    }
}
