namespace FitnessStudioApp.FORMS
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblLogin = new Label();
            lblSubtitle = new Label();
            pnlCard = new Panel();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chbShowPassword = new CheckBox();
            pnlDivider = new Panel();
            pnlButtons = new Panel();
            btnLogin = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            pnlCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(230, 241, 251);
            lblLogin.Location = new Point(103, 28);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(181, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "FITNESS APP";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(55, 138, 221);
            lblSubtitle.Location = new Point(103, 61);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(142, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to your account";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(chbShowPassword);
            pnlCard.Controls.Add(pnlDivider);
            pnlCard.Controls.Add(pnlButtons);
            pnlCard.Location = new Point(36, 85);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(408, 290);
            pnlCard.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(133, 183, 235);
            lblUser.Location = new Point(28, 24);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(71, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "USERNAME";
            lblUser.Click += lblUser_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(15, 27, 45);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(230, 241, 251);
            txtUsername.Location = new Point(28, 42);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(352, 27);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(133, 183, 235);
            lblPassword.Location = new Point(28, 86);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 27, 45);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(230, 241, 251);
            txtPassword.Location = new Point(28, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(352, 27);
            txtPassword.TabIndex = 1;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.FromArgb(26, 39, 64);
            chbShowPassword.Font = new Font("Segoe UI", 9F);
            chbShowPassword.ForeColor = Color.FromArgb(133, 183, 235);
            chbShowPassword.Location = new Point(28, 140);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(108, 19);
            chbShowPassword.TabIndex = 2;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(35, 55, 90);
            pnlDivider.Location = new Point(28, 172);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(352, 1);
            pnlDivider.TabIndex = 3;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(26, 39, 64);
            pnlButtons.Controls.Add(btnLogin);
            pnlButtons.Controls.Add(btnRegister);
            pnlButtons.Location = new Point(28, 184);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(352, 88);
            pnlButtons.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(24, 95, 165);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(230, 241, 251);
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(352, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(26, 39, 64);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(55, 138, 221);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 33, 55);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F);
            btnRegister.ForeColor = Color.FromArgb(133, 183, 235);
            btnRegister.Location = new Point(0, 48);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(352, 36);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Create an Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(480, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblLogin);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Login";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblSubtitle;
        private Panel pnlCard;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chbShowPassword;
        private Panel pnlDivider;
        private Panel pnlButtons;
        private Button btnLogin;
        private Button btnRegister;
        private PictureBox pictureBox1;
    }
}