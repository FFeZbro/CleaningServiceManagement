namespace CleaningServiceManagement.Forms.Client
{
    partial class BookingForm
    {
        private ComboBox cmbServices;
        private DateTimePicker dtpDate;
        private Button btnSubmit;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.cmbServices = new ComboBox();
            this.dtpDate = new DateTimePicker();
            this.btnSubmit = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Новое бронирование";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;

            // cmbServices
            this.cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbServices.Location = new Point(50, 60);
            this.cmbServices.Width = 300;

            // dtpDate
            this.dtpDate.Location = new Point(50, 100);
            this.dtpDate.Format = DateTimePickerFormat.Custom;
            this.dtpDate.CustomFormat = "dd.MM.yyyy HH:mm";

            // btnSubmit
            this.btnSubmit.Text = "Подтвердить";
            this.btnSubmit.Location = new Point(50, 150);
            this.btnSubmit.BackColor = Color.SteelBlue;
            this.btnSubmit.ForeColor = Color.White;

            // BookingForm
            this.ClientSize = new Size(400, 250);
            this.Controls.AddRange(new Control[] {
                lblTitle, cmbServices, dtpDate, btnSubmit
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
