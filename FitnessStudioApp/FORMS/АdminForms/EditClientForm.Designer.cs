namespace FitnessStudioApp.FORMS.АdminForms
{
    partial class EditClientForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxUsername = new TextBox();
            tbxEmail = new TextBox();
            tbxPhone = new TextBox();
            tbxPassword = new TextBox();
            lbxProgresses = new ListBox();
            btnDeleteProgress = new Button();
            btnExit = new Button();
            btnUpdateData = new Button();
            cbxShowPassword = new CheckBox();
            cbMembershipStatus = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 179);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(80, 49);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(100, 23);
            tbxUsername.TabIndex = 5;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(80, 87);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(100, 23);
            tbxEmail.TabIndex = 6;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(80, 124);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(100, 23);
            tbxPhone.TabIndex = 7;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(80, 171);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(100, 23);
            tbxPassword.TabIndex = 8;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // lbxProgresses
            // 
            lbxProgresses.FormattingEnabled = true;
            lbxProgresses.Location = new Point(505, 55);
            lbxProgresses.Name = "lbxProgresses";
            lbxProgresses.Size = new Size(215, 139);
            lbxProgresses.TabIndex = 9;
            lbxProgresses.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnDeleteProgress
            // 
            btnDeleteProgress.Location = new Point(547, 220);
            btnDeleteProgress.Name = "btnDeleteProgress";
            btnDeleteProgress.Size = new Size(103, 39);
            btnDeleteProgress.TabIndex = 10;
            btnDeleteProgress.Text = "Detete Progress";
            btnDeleteProgress.UseVisualStyleBackColor = true;
            btnDeleteProgress.Click += btnDeleteProgress_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(285, 363);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 40);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Location = new Point(63, 246);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(125, 23);
            btnUpdateData.TabIndex = 12;
            btnUpdateData.Text = "Update data";
            btnUpdateData.UseVisualStyleBackColor = true;
            btnUpdateData.Click += btnUpdateData_Click;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.Location = new Point(80, 209);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(108, 19);
            cbxShowPassword.TabIndex = 13;
            cbxShowPassword.Text = "Show password";
            cbxShowPassword.UseVisualStyleBackColor = true;
            cbxShowPassword.CheckedChanged += cbxShowPassword_CheckedChanged;
            // 
            // cbMembershipStatus
            // 
            cbMembershipStatus.FormattingEnabled = true;
            cbMembershipStatus.Location = new Point(339, 49);
            cbMembershipStatus.Name = "cbMembershipStatus";
            cbMembershipStatus.Size = new Size(121, 23);
            cbMembershipStatus.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 52);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 15;
            label6.Text = "MembershipStatus";
            // 
            // EditClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(cbMembershipStatus);
            Controls.Add(cbxShowPassword);
            Controls.Add(btnUpdateData);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteProgress);
            Controls.Add(lbxProgresses);
            Controls.Add(tbxPassword);
            Controls.Add(tbxPhone);
            Controls.Add(tbxEmail);
            Controls.Add(tbxUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditClientForm";
            Text = "EditClientForm";
            Load += EditClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxUsername;
        private TextBox tbxEmail;
        private TextBox tbxPhone;
        private TextBox tbxPassword;
        private ListBox lbxProgresses;
        private Button btnDeleteProgress;
        private Button btnExit;
        private Button btnUpdateData;
        private CheckBox cbxShowPassword;
        private ComboBox cbMembershipStatus;
        private Label label6;
    }
}