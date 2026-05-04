namespace FitnessStudioApp.FORMS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblUsername = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblRegisterAs = new Label();
            cmbRoles = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(338, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(346, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(346, 275);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 21);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(338, 227);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(297, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(157, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(297, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(297, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(297, 299);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 23);
            txtPhone.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(297, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(157, 57);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(285, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 37);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "FITNESS APP";
            // 
            // lblRegisterAs
            // 
            lblRegisterAs.AutoSize = true;
            lblRegisterAs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterAs.Location = new Point(331, 325);
            lblRegisterAs.Name = "lblRegisterAs";
            lblRegisterAs.Size = new Size(88, 21);
            lblRegisterAs.TabIndex = 11;
            lblRegisterAs.Text = "Register As";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Items.AddRange(new object[] { "Client", "Trainer", "Admin" });
            cmbRoles.Location = new Point(297, 349);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(157, 23);
            cmbRoles.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRoles);
            Controls.Add(lblRegisterAs);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblRegisterAs;
        private ComboBox cmbRoles;
    }
}