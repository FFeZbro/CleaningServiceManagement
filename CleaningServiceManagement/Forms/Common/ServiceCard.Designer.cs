namespace CleaningServiceManagement.Forms.Common
{
    partial class ServiceCard
    {
        private Label lblTitle;
        private Label lblPrice;
        private Label lblDuration;
        private Button btnBook;
        private ToolTip toolTip;

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblPrice = new Label();
            this.lblDuration = new Label();
            this.btnBook = new Button();
            this.toolTip = new ToolTip();
            this.SuspendLayout();

            // Размеры
            this.Size = new Size(250, 120);
            this.BorderStyle = BorderStyle.FixedSingle;

            // lblTitle
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(10, 10);
            this.lblTitle.AutoSize = false;
            this.lblTitle.Width = 230;

            // lblPrice
            this.lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            this.lblPrice.ForeColor = Color.Green;
            this.lblPrice.Location = new Point(10, 40);

            // lblDuration
            this.lblDuration.Font = new Font("Segoe UI", 9F);
            this.lblDuration.Location = new Point(10, 65);

            // btnBook
            this.btnBook.Text = "➔";
            this.btnBook.FlatStyle = FlatStyle.Flat;
            this.btnBook.Size = new Size(40, 40);
            this.btnBook.Location = new Point(190, 60);

            this.Controls.AddRange(new Control[] {
                lblTitle, lblPrice, lblDuration, btnBook
            });
            this.ResumeLayout(false);
        }
    }
}
