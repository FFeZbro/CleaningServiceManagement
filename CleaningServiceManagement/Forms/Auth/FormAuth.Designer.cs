namespace CleaningServiceManagement.Forms.Auth
{
    partial class FormAuth
    {
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkRegister;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.linkRegister = new LinkLabel();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // txtEmail
            this.txtEmail.PlaceholderText = "example@mail.com";
            this.txtEmail.Location = new Point(50, 80);
            this.txtEmail.Size = new Size(300, 25);

            // txtPassword
            this.txtPassword.PlaceholderText = "Пароль";
            this.txtPassword.Location = new Point(50, 120);
            this.txtPassword.PasswordChar = '•';

            // btnLogin
            this.btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(50, 170);
            this.btnLogin.Text = "Войти";
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // linkRegister
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new Point(50, 220);
            this.linkRegister.Text = "Нет аккаунта? Зарегистрироваться";
            this.linkRegister.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(50, 30);
            this.lblTitle.Text = "Авторизация";

            // FormAuth
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Name = "FormAuth";
            this.Text = "CleaningService — Вход";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
