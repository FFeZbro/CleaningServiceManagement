namespace CleaningServiceManagement.Forms.Common
{
    partial class FormServices
    {
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnRefresh;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.flowLayoutPanel = new FlowLayoutPanel();
            this.btnRefresh = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Каталог услуг";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Padding = new Padding(10);

            // flowLayoutPanel
            this.flowLayoutPanel.Dock = DockStyle.Fill;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Padding = new Padding(20);
            this.flowLayoutPanel.BackColor = Color.FromArgb(250, 250, 250);

            // btnRefresh
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Dock = DockStyle.Bottom;
            this.btnRefresh.Height = 40;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;

            // FormServices
            this.ClientSize = new Size(900, 600);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.ResumeLayout(false);
        }
    }
}
