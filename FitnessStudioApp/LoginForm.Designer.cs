namespace FitnessStudioApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            cbxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(249, 43);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вход";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(60, 119);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(202, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Потребителско име: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(60, 229);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Парола";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(77, 417);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(60, 173);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(202, 34);
            tbxUsername.TabIndex = 4;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(60, 269);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(125, 34);
            tbxPassword.TabIndex = 5;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.Location = new Point(60, 341);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(144, 32);
            cbxShowPassword.TabIndex = 6;
            cbxShowPassword.Text = "Виж парола";
            cbxShowPassword.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 630);
            Controls.Add(cbxShowPassword);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private CheckBox cbxShowPassword;
    }
}
