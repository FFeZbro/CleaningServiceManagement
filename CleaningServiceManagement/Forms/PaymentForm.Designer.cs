namespace CleaningServiceManagement.Forms.Common
{
    partial class PaymentForm
    {
        private Label lblAmount;
        private ComboBox cmbMethod;
        private Button btnConfirm;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.lblAmount = new Label();
            this.cmbMethod = new ComboBox();
            this.btnConfirm = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Оплата услуги";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Top;

            // lblAmount
            this.lblAmount.Font = new Font("Segoe UI", 12F);
            this.lblAmount.Location = new Point(20, 50);

            // cmbMethod
            this.cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMethod.Location = new Point(20, 90);
            this.cmbMethod.Width = 200;

            // btnConfirm
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.Location = new Point(20, 130);
            this.btnConfirm.BackColor = Color.SteelBlue;
            this.btnConfirm.ForeColor = Color.White;

            // PaymentForm
            this.ClientSize = new Size(300, 200);
            this.Controls.AddRange(new Control[] {
                lblTitle, lblAmount, cmbMethod, btnConfirm
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ResumeLayout(false);
        }
    }
}
