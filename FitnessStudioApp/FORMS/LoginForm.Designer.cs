namespace FitnessStudioApp.FORMS
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblUser = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            chbShowPassword = new CheckBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15F);
            lblLogin.Location = new Point(415, 27);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(61, 28);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 15F);
            lblUser.Location = new Point(360, 82);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            lblUser.Click += lblUser_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.Location = new Point(360, 181);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(360, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(360, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(177, 23);
            txtUsername.TabIndex = 5;
            txtUsername.UseSystemPasswordChar = true;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Segoe UI", 12F);
            chbShowPassword.Location = new Point(360, 246);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(134, 25);
            chbShowPassword.TabIndex = 6;
            chbShowPassword.Text = "ShowPassword";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ScrollBar;
            btnLogin.ForeColor = SystemColors.ControlDarkDark;
            btnLogin.Location = new Point(360, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(935, 450);
            Controls.Add(btnLogin);
            Controls.Add(chbShowPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(lblLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private CheckBox chbShowPassword;
        private Button btnLogin;
    }
}