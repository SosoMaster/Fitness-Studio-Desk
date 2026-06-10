namespace FitnessStudioApp.FORMS.АdminForms
{
    partial class EditTrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrainerForm));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            label1 = new Label();
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
            lblSpecialty = new Label();
            cbxSpecialty = new ComboBox();
            btnUpdateData = new Button();
            btnExit = new Button();
            pnlClients = new Panel();
            lblClientsHdr = new Label();
            lbClients = new ListBox();
            btnDeleteClient = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFields.SuspendLayout();
            pnlClients.SuspendLayout();
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
            lblSubtitle.Location = new Point(98, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(167, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Admin Panel — Edit Trainer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.ForeColor = Color.FromArgb(55, 138, 221);
            label1.Location = new Point(100, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 3;
            label1.Visible = false;
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
            pnlFields.Controls.Add(lblSpecialty);
            pnlFields.Controls.Add(cbxSpecialty);
            pnlFields.Controls.Add(btnUpdateData);
            pnlFields.Controls.Add(btnExit);
            pnlFields.Location = new Point(36, 86);
            pnlFields.Name = "pnlFields";
            pnlFields.Size = new Size(430, 446);
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
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSpecialty.ForeColor = Color.FromArgb(133, 183, 235);
            lblSpecialty.Location = new Point(20, 286);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(65, 15);
            lblSpecialty.TabIndex = 5;
            lblSpecialty.Text = "SPECIALTY";
            // 
            // cbxSpecialty
            // 
            cbxSpecialty.BackColor = Color.FromArgb(15, 27, 45);
            cbxSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSpecialty.FlatStyle = FlatStyle.Flat;
            cbxSpecialty.Font = new Font("Segoe UI", 11F);
            cbxSpecialty.ForeColor = Color.FromArgb(230, 241, 251);
            cbxSpecialty.FormattingEnabled = true;
            cbxSpecialty.Location = new Point(20, 304);
            cbxSpecialty.Name = "cbxSpecialty";
            cbxSpecialty.Size = new Size(380, 28);
            cbxSpecialty.TabIndex = 5;
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
            // pnlClients
            // 
            pnlClients.BackColor = Color.FromArgb(26, 39, 64);
            pnlClients.BorderStyle = BorderStyle.FixedSingle;
            pnlClients.Controls.Add(lblClientsHdr);
            pnlClients.Controls.Add(lbClients);
            pnlClients.Controls.Add(btnDeleteClient);
            pnlClients.Location = new Point(494, 86);
            pnlClients.Name = "pnlClients";
            pnlClients.Size = new Size(330, 410);
            pnlClients.TabIndex = 5;
            // 
            // lblClientsHdr
            // 
            lblClientsHdr.AutoSize = true;
            lblClientsHdr.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblClientsHdr.ForeColor = Color.FromArgb(133, 183, 235);
            lblClientsHdr.Location = new Point(20, 20);
            lblClientsHdr.Name = "lblClientsHdr";
            lblClientsHdr.Size = new Size(115, 15);
            lblClientsHdr.TabIndex = 0;
            lblClientsHdr.Text = "ASSIGNED CLIENTS";
            // 
            // lbClients
            // 
            lbClients.BackColor = Color.FromArgb(15, 27, 45);
            lbClients.BorderStyle = BorderStyle.FixedSingle;
            lbClients.Font = new Font("Segoe UI", 10F);
            lbClients.ForeColor = Color.FromArgb(230, 241, 251);
            lbClients.FormattingEnabled = true;
            lbClients.Location = new Point(20, 40);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(290, 291);
            lbClients.TabIndex = 8;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.BackColor = Color.FromArgb(26, 39, 64);
            btnDeleteClient.Cursor = Cursors.Hand;
            btnDeleteClient.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnDeleteClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 40, 40);
            btnDeleteClient.FlatStyle = FlatStyle.Flat;
            btnDeleteClient.Font = new Font("Segoe UI", 10F);
            btnDeleteClient.ForeColor = Color.FromArgb(220, 100, 100);
            btnDeleteClient.Location = new Point(20, 355);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(290, 38);
            btnDeleteClient.TabIndex = 9;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = false;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // EditTrainerForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(860, 562);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(label1);
            Controls.Add(pnlFields);
            Controls.Add(pnlClients);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditTrainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Edit Trainer";
            Load += EditTrainerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFields.ResumeLayout(false);
            pnlFields.PerformLayout();
            pnlClients.ResumeLayout(false);
            pnlClients.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label label1;
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
        private Label lblSpecialty;
        private ComboBox cbxSpecialty;
        private Button btnUpdateData;
        private Button btnExit;
        private Panel pnlClients;
        private Label lblClientsHdr;
        private ListBox lbClients;
        private Button btnDeleteClient;
    }
}