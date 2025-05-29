namespace CleaningServiceManagement.Forms.Auth
{
    partial class FormSplash
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblStatus;
        private Button btnRetry;
        private PictureBox logoPictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStatus = new Label();
            this.btnRetry = new Button();
            this.logoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 10F);
            this.lblStatus.Location = new Point(50, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(300, 19);
            this.lblStatus.Text = "Загрузка системы...";
            this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // btnRetry
            this.btnRetry.Location = new Point(150, 180);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new Size(100, 30);
            this.btnRetry.Text = "Повторить";
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new EventHandler(this.btnRetry_Click);

            // logoPictureBox
            this.logoPictureBox.Image = Properties.Resources.Logo; // Добавьте лого в ресурсы
            this.logoPictureBox.Location = new Point(125, 50);
            this.logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.logoPictureBox.Size = new Size(150, 80);

            // FormSplash
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 250);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "FormSplash";
            this.Text = "Добро пожаловать";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
