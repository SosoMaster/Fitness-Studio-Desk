namespace FitnessStudioApp.FORMS.АdminForms
{
    partial class EditClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClientForm));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlFields = new Panel();
            label2 = new Label();
            tbxUsername = new TextBox();
            label3 = new Label();
            tbxEmail = new TextBox();
            label4 = new Label();
            tbxPhone = new TextBox();
            label5 = new Label();
            tbxPassword = new TextBox();
            cbxShowPassword = new CheckBox();
            label6 = new Label();
            cbMembershipStatus = new ComboBox();
            btnUpdateData = new Button();
            btnExit = new Button();
            pnlProgress = new Panel();
            lblProgressHeader = new Label();
            lbxProgresses = new ListBox();
            btnDeleteProgress = new Button();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFields.SuspendLayout();
            pnlProgress.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 20);
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
            lblTitle.Location = new Point(98, 20);
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
            lblSubtitle.Location = new Point(100, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(159, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Admin Panel — Edit Client";
            // 
            // pnlFields
            // 
            pnlFields.BackColor = Color.FromArgb(26, 39, 64);
            pnlFields.BorderStyle = BorderStyle.FixedSingle;
            pnlFields.Controls.Add(label2);
            pnlFields.Controls.Add(tbxUsername);
            pnlFields.Controls.Add(label3);
            pnlFields.Controls.Add(tbxEmail);
            pnlFields.Controls.Add(label4);
            pnlFields.Controls.Add(tbxPhone);
            pnlFields.Controls.Add(label5);
            pnlFields.Controls.Add(tbxPassword);
            pnlFields.Controls.Add(cbxShowPassword);
            pnlFields.Controls.Add(label6);
            pnlFields.Controls.Add(cbMembershipStatus);
            pnlFields.Controls.Add(btnUpdateData);
            pnlFields.Controls.Add(btnExit);
            pnlFields.Location = new Point(36, 86);
            pnlFields.Name = "pnlFields";
            pnlFields.Size = new Size(430, 448);
            pnlFields.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(133, 183, 235);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 0;
            label2.Text = "USERNAME";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.FromArgb(15, 27, 45);
            tbxUsername.BorderStyle = BorderStyle.FixedSingle;
            tbxUsername.Font = new Font("Segoe UI", 11F);
            tbxUsername.ForeColor = Color.FromArgb(230, 241, 251);
            tbxUsername.Location = new Point(20, 38);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(380, 27);
            tbxUsername.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(133, 183, 235);
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "EMAIL";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(15, 27, 45);
            tbxEmail.BorderStyle = BorderStyle.FixedSingle;
            tbxEmail.Font = new Font("Segoe UI", 11F);
            tbxEmail.ForeColor = Color.FromArgb(230, 241, 251);
            tbxEmail.Location = new Point(20, 98);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(380, 27);
            tbxEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(133, 183, 235);
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 2;
            label4.Text = "PHONE";
            // 
            // tbxPhone
            // 
            tbxPhone.BackColor = Color.FromArgb(15, 27, 45);
            tbxPhone.BorderStyle = BorderStyle.FixedSingle;
            tbxPhone.Font = new Font("Segoe UI", 11F);
            tbxPhone.ForeColor = Color.FromArgb(230, 241, 251);
            tbxPhone.Location = new Point(20, 158);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(380, 27);
            tbxPhone.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(133, 183, 235);
            label5.Location = new Point(20, 200);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 3;
            label5.Text = "PASSWORD";
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(15, 27, 45);
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Font = new Font("Segoe UI", 11F);
            tbxPassword.ForeColor = Color.FromArgb(230, 241, 251);
            tbxPassword.Location = new Point(20, 218);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(380, 27);
            tbxPassword.TabIndex = 3;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.BackColor = Color.FromArgb(26, 39, 64);
            cbxShowPassword.Font = new Font("Segoe UI", 9F);
            cbxShowPassword.ForeColor = Color.FromArgb(133, 183, 235);
            cbxShowPassword.Location = new Point(20, 254);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(108, 19);
            cbxShowPassword.TabIndex = 4;
            cbxShowPassword.Text = "Show password";
            cbxShowPassword.UseVisualStyleBackColor = false;
            cbxShowPassword.CheckedChanged += cbxShowPassword_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(133, 183, 235);
            label6.Location = new Point(20, 286);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 5;
            label6.Text = "MEMBERSHIP STATUS";
            // 
            // cbMembershipStatus
            // 
            cbMembershipStatus.BackColor = Color.FromArgb(15, 27, 45);
            cbMembershipStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMembershipStatus.FlatStyle = FlatStyle.Flat;
            cbMembershipStatus.Font = new Font("Segoe UI", 11F);
            cbMembershipStatus.ForeColor = Color.FromArgb(230, 241, 251);
            cbMembershipStatus.FormattingEnabled = true;
            cbMembershipStatus.Location = new Point(20, 304);
            cbMembershipStatus.Name = "cbMembershipStatus";
            cbMembershipStatus.Size = new Size(380, 28);
            cbMembershipStatus.TabIndex = 5;
            // 
            // btnUpdateData
            // 
            btnUpdateData.BackColor = Color.FromArgb(24, 95, 165);
            btnUpdateData.Cursor = Cursors.Hand;
            btnUpdateData.FlatAppearance.BorderSize = 0;
            btnUpdateData.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnUpdateData.FlatStyle = FlatStyle.Flat;
            btnUpdateData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateData.ForeColor = Color.FromArgb(230, 241, 251);
            btnUpdateData.Location = new Point(20, 350);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(380, 38);
            btnUpdateData.TabIndex = 6;
            btnUpdateData.Text = "Update Data";
            btnUpdateData.UseVisualStyleBackColor = false;
            btnUpdateData.Click += btnUpdateData_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(26, 39, 64);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(55, 138, 221);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 33, 55);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.FromArgb(133, 183, 235);
            btnExit.Location = new Point(20, 396);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(380, 36);
            btnExit.TabIndex = 7;
            btnExit.Text = "← Back to Admin Panel";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = Color.FromArgb(26, 39, 64);
            pnlProgress.BorderStyle = BorderStyle.FixedSingle;
            pnlProgress.Controls.Add(lblProgressHeader);
            pnlProgress.Controls.Add(lbxProgresses);
            pnlProgress.Controls.Add(btnDeleteProgress);
            pnlProgress.Location = new Point(494, 86);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(330, 410);
            pnlProgress.TabIndex = 5;
            // 
            // lblProgressHeader
            // 
            lblProgressHeader.AutoSize = true;
            lblProgressHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblProgressHeader.ForeColor = Color.FromArgb(133, 183, 235);
            lblProgressHeader.Location = new Point(20, 20);
            lblProgressHeader.Name = "lblProgressHeader";
            lblProgressHeader.Size = new Size(125, 15);
            lblProgressHeader.TabIndex = 0;
            lblProgressHeader.Text = "PROGRESS RECORDS";
            // 
            // lbxProgresses
            // 
            lbxProgresses.BackColor = Color.FromArgb(15, 27, 45);
            lbxProgresses.BorderStyle = BorderStyle.FixedSingle;
            lbxProgresses.Font = new Font("Segoe UI", 10F);
            lbxProgresses.ForeColor = Color.FromArgb(230, 241, 251);
            lbxProgresses.FormattingEnabled = true;
            lbxProgresses.Location = new Point(20, 40);
            lbxProgresses.Name = "lbxProgresses";
            lbxProgresses.Size = new Size(290, 291);
            lbxProgresses.TabIndex = 8;
            lbxProgresses.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnDeleteProgress
            // 
            btnDeleteProgress.BackColor = Color.FromArgb(26, 39, 64);
            btnDeleteProgress.Cursor = Cursors.Hand;
            btnDeleteProgress.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnDeleteProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 40, 40);
            btnDeleteProgress.FlatStyle = FlatStyle.Flat;
            btnDeleteProgress.Font = new Font("Segoe UI", 10F);
            btnDeleteProgress.ForeColor = Color.FromArgb(220, 100, 100);
            btnDeleteProgress.Location = new Point(20, 355);
            btnDeleteProgress.Name = "btnDeleteProgress";
            btnDeleteProgress.Size = new Size(290, 38);
            btnDeleteProgress.TabIndex = 9;
            btnDeleteProgress.Text = "Delete Progress";
            btnDeleteProgress.UseVisualStyleBackColor = false;
            btnDeleteProgress.Click += btnDeleteProgress_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 9.5F);
            lblHeader.ForeColor = Color.FromArgb(55, 138, 221);
            lblHeader.Location = new Point(100, 52);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(0, 17);
            lblHeader.TabIndex = 3;
            lblHeader.Visible = false;
            // 
            // EditClientForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(860, 560);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblHeader);
            Controls.Add(pnlFields);
            Controls.Add(pnlProgress);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Edit Client";
            Load += EditClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFields.ResumeLayout(false);
            pnlFields.PerformLayout();
            pnlProgress.ResumeLayout(false);
            pnlProgress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblHeader;
        private Panel pnlFields;
        private Label label2;
        private TextBox tbxUsername;
        private Label label3;
        private TextBox tbxEmail;
        private Label label4;
        private TextBox tbxPhone;
        private Label label5;
        private TextBox tbxPassword;
        private CheckBox cbxShowPassword;
        private Label label6;
        private ComboBox cbMembershipStatus;
        private Button btnUpdateData;
        private Button btnExit;
        private Panel pnlProgress;
        private Label lblProgressHeader;
        private ListBox lbxProgresses;
        private Button btnDeleteProgress;
    }
}