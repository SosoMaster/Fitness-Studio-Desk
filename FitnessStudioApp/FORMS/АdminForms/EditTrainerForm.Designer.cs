namespace FitnessStudioApp.FORMS.АdminForms
{
    partial class EditTrainerForm
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
            cbxShowPassword = new CheckBox();
            btnUpdateData = new Button();
            tbxPassword = new TextBox();
            tbxPhone = new TextBox();
            tbxEmail = new TextBox();
            tbxUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbxSpecialty = new ComboBox();
            lblSpecialty = new Label();
            lbClients = new ListBox();
            btnDeleteClient = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.Location = new Point(86, 216);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(108, 19);
            cbxShowPassword.TabIndex = 23;
            cbxShowPassword.Text = "Show password";
            cbxShowPassword.UseVisualStyleBackColor = true;
            cbxShowPassword.CheckedChanged += cbxShowPassword_CheckedChanged;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Location = new Point(69, 253);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(125, 23);
            btnUpdateData.TabIndex = 22;
            btnUpdateData.Text = "Update data";
            btnUpdateData.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(86, 178);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(100, 23);
            tbxPassword.TabIndex = 21;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(86, 131);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(100, 23);
            tbxPhone.TabIndex = 20;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(86, 94);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(100, 23);
            tbxEmail.TabIndex = 19;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(86, 56);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(100, 23);
            tbxUsername.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 186);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 17;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 134);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // cbxSpecialty
            // 
            cbxSpecialty.FormattingEnabled = true;
            cbxSpecialty.Location = new Point(313, 56);
            cbxSpecialty.Name = "cbxSpecialty";
            cbxSpecialty.Size = new Size(121, 23);
            cbxSpecialty.TabIndex = 24;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Location = new Point(234, 59);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(54, 15);
            lblSpecialty.TabIndex = 25;
            lblSpecialty.Text = "Specialty";
            // 
            // lbClients
            // 
            lbClients.FormattingEnabled = true;
            lbClients.Location = new Point(459, 59);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(307, 184);
            lbClients.TabIndex = 26;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(574, 262);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(114, 23);
            btnDeleteClient.TabIndex = 27;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(280, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 28;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // EditTrainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteClient);
            Controls.Add(lbClients);
            Controls.Add(lblSpecialty);
            Controls.Add(cbxSpecialty);
            Controls.Add(cbxShowPassword);
            Controls.Add(btnUpdateData);
            Controls.Add(tbxPassword);
            Controls.Add(tbxPhone);
            Controls.Add(tbxEmail);
            Controls.Add(tbxUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditTrainerForm";
            Text = "EditTrainerForm";
            Load += EditTrainerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbxShowPassword;
        private Button btnUpdateData;
        private TextBox tbxPassword;
        private TextBox tbxPhone;
        private TextBox tbxEmail;
        private TextBox tbxUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbxSpecialty;
        private Label lblSpecialty;
        private ListBox lbClients;
        private Button btnDeleteClient;
        private Button btnExit;
    }
}