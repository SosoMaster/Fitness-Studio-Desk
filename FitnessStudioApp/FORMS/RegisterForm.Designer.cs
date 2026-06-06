namespace FitnessStudioApp.FORMS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlCard = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            btnShowPassword = new Button();
            lblConfirmPassword = new Label();
            pnlConfirmPassword = new Panel();
            txtConfirmPassword = new TextBox();
            btnShowConfirm = new Button();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPhoneHint = new Label();
            pnlDivider = new Panel();
            lblRegisterAs = new Label();
            cmbRoles = new ComboBox();
            pnlButtons = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCard.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlConfirmPassword.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 241, 251);
            lblTitle.Location = new Point(94, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "FITNESS APP";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(55, 138, 221);
            lblSubtitle.Location = new Point(98, 61);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(125, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create your account";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(pnlPassword);
            pnlCard.Controls.Add(lblConfirmPassword);
            pnlCard.Controls.Add(pnlConfirmPassword);
            pnlCard.Controls.Add(lblPhone);
            pnlCard.Controls.Add(txtPhone);
            pnlCard.Controls.Add(lblPhoneHint);
            pnlCard.Controls.Add(pnlDivider);
            pnlCard.Controls.Add(lblRegisterAs);
            pnlCard.Controls.Add(cmbRoles);
            pnlCard.Controls.Add(pnlButtons);
            pnlCard.Location = new Point(36, 90);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(468, 545);
            pnlCard.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(133, 183, 235);
            lblUsername.Location = new Point(28, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(15, 27, 45);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(230, 241, 251);
            txtUsername.Location = new Point(28, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(410, 27);
            txtUsername.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(133, 183, 235);
            lblEmail.Location = new Point(28, 82);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 27, 45);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.FromArgb(230, 241, 251);
            txtEmail.Location = new Point(28, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(410, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(133, 183, 235);
            lblPassword.Location = new Point(28, 142);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "PASSWORD";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(15, 27, 45);
            pnlPassword.BorderStyle = BorderStyle.FixedSingle;
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Controls.Add(btnShowPassword);
            pnlPassword.Location = new Point(28, 160);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(410, 30);
            pnlPassword.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 27, 45);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(230, 241, 251);
            txtPassword.Location = new Point(4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(340, 20);
            txtPassword.TabIndex = 2;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.FromArgb(15, 27, 45);
            btnShowPassword.Cursor = Cursors.Hand;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnShowPassword.ForeColor = Color.FromArgb(55, 138, 221);
            btnShowPassword.Location = new Point(352, 4);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(52, 22);
            btnShowPassword.TabIndex = 3;
            btnShowPassword.TabStop = false;
            btnShowPassword.Text = "SHOW";
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(133, 183, 235);
            lblConfirmPassword.Location = new Point(28, 205);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(130, 15);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "CONFIRM PASSWORD";
            // 
            // pnlConfirmPassword
            // 
            pnlConfirmPassword.BackColor = Color.FromArgb(15, 27, 45);
            pnlConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            pnlConfirmPassword.Controls.Add(txtConfirmPassword);
            pnlConfirmPassword.Controls.Add(btnShowConfirm);
            pnlConfirmPassword.Location = new Point(28, 223);
            pnlConfirmPassword.Name = "pnlConfirmPassword";
            pnlConfirmPassword.Size = new Size(410, 30);
            pnlConfirmPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(15, 27, 45);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.ForeColor = Color.FromArgb(230, 241, 251);
            txtConfirmPassword.Location = new Point(4, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(340, 20);
            txtConfirmPassword.TabIndex = 3;
            // 
            // btnShowConfirm
            // 
            btnShowConfirm.BackColor = Color.FromArgb(15, 27, 45);
            btnShowConfirm.Cursor = Cursors.Hand;
            btnShowConfirm.FlatAppearance.BorderSize = 0;
            btnShowConfirm.FlatStyle = FlatStyle.Flat;
            btnShowConfirm.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnShowConfirm.ForeColor = Color.FromArgb(55, 138, 221);
            btnShowConfirm.Location = new Point(352, 4);
            btnShowConfirm.Name = "btnShowConfirm";
            btnShowConfirm.Size = new Size(52, 22);
            btnShowConfirm.TabIndex = 4;
            btnShowConfirm.TabStop = false;
            btnShowConfirm.Text = "SHOW";
            btnShowConfirm.UseVisualStyleBackColor = false;
            btnShowConfirm.Click += btnShowConfirm_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(133, 183, 235);
            lblPhone.Location = new Point(28, 268);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(47, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "PHONE";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(15, 27, 45);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.FromArgb(230, 241, 251);
            txtPhone.Location = new Point(28, 286);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(410, 27);
            txtPhone.TabIndex = 4;
            // 
            // lblPhoneHint
            // 
            lblPhoneHint.AutoSize = true;
            lblPhoneHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblPhoneHint.ForeColor = Color.FromArgb(80, 120, 170);
            lblPhoneHint.Location = new Point(28, 317);
            lblPhoneHint.Name = "lblPhoneHint";
            lblPhoneHint.Size = new Size(321, 13);
            lblPhoneHint.TabIndex = 7;
            lblPhoneHint.Text = "Format: +359XXXXXXXXX or 0XXXXXXXXX  (9 digits after prefix)";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(35, 55, 90);
            pnlDivider.Location = new Point(28, 338);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(410, 1);
            pnlDivider.TabIndex = 8;
            // 
            // lblRegisterAs
            // 
            lblRegisterAs.AutoSize = true;
            lblRegisterAs.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRegisterAs.ForeColor = Color.FromArgb(133, 183, 235);
            lblRegisterAs.Location = new Point(28, 350);
            lblRegisterAs.Name = "lblRegisterAs";
            lblRegisterAs.Size = new Size(80, 15);
            lblRegisterAs.TabIndex = 9;
            lblRegisterAs.Text = "REGISTER AS";
            // 
            // cmbRoles
            // 
            cmbRoles.BackColor = Color.FromArgb(15, 27, 45);
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FlatStyle = FlatStyle.Flat;
            cmbRoles.Font = new Font("Segoe UI", 11F);
            cmbRoles.ForeColor = Color.FromArgb(230, 241, 251);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Items.AddRange(new object[] { "Client", "Trainer", "Admin" });
            cmbRoles.Location = new Point(28, 368);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(410, 28);
            cmbRoles.TabIndex = 5;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(26, 39, 64);
            pnlButtons.Controls.Add(btnRegister);
            pnlButtons.Controls.Add(btnLogin);
            pnlButtons.Location = new Point(28, 415);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(410, 108);
            pnlButtons.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(24, 95, 165);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(230, 241, 251);
            btnRegister.Location = new Point(0, 0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(410, 46);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Create Account ";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(26, 39, 64);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(55, 138, 221);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 33, 55);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.FromArgb(133, 183, 235);
            btnLogin.Location = new Point(0, 56);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(410, 42);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Back to Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(540, 660);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Register";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlConfirmPassword.ResumeLayout(false);
            pnlConfirmPassword.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlCard;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private Panel pnlPassword;
        private TextBox txtPassword;
        private Button btnShowPassword;
        private Label lblConfirmPassword;
        private Panel pnlConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnShowConfirm;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblPhoneHint;
        private Panel pnlDivider;
        private Label lblRegisterAs;
        private ComboBox cmbRoles;
        private Panel pnlButtons;
        private Button btnRegister;
        private Button btnLogin;
    }
}