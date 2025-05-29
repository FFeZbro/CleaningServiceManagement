namespace CleaningServiceManagement.Forms.Client
{
    partial class ReviewsForm
    {
        private ComboBox cmbOrders;
        private TextBox txtComment;
        private Button btnSubmit;
        private NumericUpDown ratingControl;

        private void InitializeComponent()
        {
            this.cmbOrders = new ComboBox();
            this.txtComment = new TextBox();
            this.btnSubmit = new Button();
            this.ratingControl = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)this.ratingControl).BeginInit();
            this.SuspendLayout();

            // ratingControl
            this.ratingControl.Minimum = 1;
            this.ratingControl.Maximum = 5;
            this.ratingControl.Location = new Point(20, 20);

            // cmbOrders
            this.cmbOrders.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrders.Location = new Point(20, 60);
            this.cmbOrders.Width = 300;

            // txtComment
            this.txtComment.Multiline = true;
            this.txtComment.ScrollBars = ScrollBars.Vertical;
            this.txtComment.Location = new Point(20, 100);
            this.txtComment.Size = new Size(360, 150);
            this.txtComment.PlaceholderText = "Ваш отзыв...";

            // btnSubmit
            this.btnSubmit.Text = "Отправить";
            this.btnSubmit.Location = new Point(300, 260);

            // ReviewsForm
            this.ClientSize = new Size(400, 300);
            this.Controls.AddRange(new Control[] {
                ratingControl, cmbOrders, txtComment, btnSubmit
            });
            ((System.ComponentModel.ISupportInitialize)this.ratingControl).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
