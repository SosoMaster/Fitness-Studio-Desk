namespace FitnessStudioApp.FORMS
{
    partial class TrainerRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerRegisterForm));
            pictureLogo = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlCard = new Panel();
            lblSpecialty = new Label();
            cmbSpecialty = new ComboBox();
            lblExperience = new Label();
            txtExperienceYears = new TextBox();
            lblGender = new Label();
            pnlGender = new Panel();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            lblAge = new Label();
            txtAge = new TextBox();
            btnFinishRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            pnlCard.SuspendLayout();
            pnlGender.SuspendLayout();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(36, 24);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(52, 50);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 241, 251);
            lblTitle.Location = new Point(98, 24);
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
            lblSubtitle.Location = new Point(100, 56);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(178, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Complete your trainer profile";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblSpecialty);
            pnlCard.Controls.Add(cmbSpecialty);
            pnlCard.Controls.Add(lblExperience);
            pnlCard.Controls.Add(txtExperienceYears);
            pnlCard.Controls.Add(lblGender);
            pnlCard.Controls.Add(pnlGender);
            pnlCard.Controls.Add(lblAge);
            pnlCard.Controls.Add(txtAge);
            pnlCard.Controls.Add(btnFinishRegister);
            pnlCard.Location = new Point(36, 88);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(468, 448);
            pnlCard.TabIndex = 3;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSpecialty.ForeColor = Color.FromArgb(133, 183, 235);
            lblSpecialty.Location = new Point(28, 24);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(65, 15);
            lblSpecialty.TabIndex = 0;
            lblSpecialty.Text = "SPECIALTY";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.BackColor = Color.FromArgb(15, 27, 45);
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.FlatStyle = FlatStyle.Flat;
            cmbSpecialty.Font = new Font("Segoe UI", 11F);
            cmbSpecialty.ForeColor = Color.FromArgb(230, 241, 251);
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(28, 42);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(410, 28);
            cmbSpecialty.TabIndex = 0;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblExperience.ForeColor = Color.FromArgb(133, 183, 235);
            lblExperience.Location = new Point(28, 86);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(131, 15);
            lblExperience.TabIndex = 1;
            lblExperience.Text = "YEARS OF EXPERIENCE";
            // 
            // txtExperienceYears
            // 
            txtExperienceYears.BackColor = Color.FromArgb(15, 27, 45);
            txtExperienceYears.BorderStyle = BorderStyle.FixedSingle;
            txtExperienceYears.Font = new Font("Segoe UI", 11F);
            txtExperienceYears.ForeColor = Color.FromArgb(230, 241, 251);
            txtExperienceYears.Location = new Point(28, 104);
            txtExperienceYears.Name = "txtExperienceYears";
            txtExperienceYears.Size = new Size(410, 27);
            txtExperienceYears.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(133, 183, 235);
            lblGender.Location = new Point(28, 148);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 15);
            lblGender.TabIndex = 2;
            lblGender.Text = "GENDER";
            // 
            // pnlGender
            // 
            pnlGender.BackColor = Color.FromArgb(26, 39, 64);
            pnlGender.Controls.Add(rdbMale);
            pnlGender.Controls.Add(rdbFemale);
            pnlGender.Location = new Point(28, 166);
            pnlGender.Name = "pnlGender";
            pnlGender.Size = new Size(410, 36);
            pnlGender.TabIndex = 3;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.BackColor = Color.FromArgb(26, 39, 64);
            rdbMale.Font = new Font("Segoe UI", 11F);
            rdbMale.ForeColor = Color.FromArgb(230, 241, 251);
            rdbMale.Location = new Point(5, 6);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(60, 24);
            rdbMale.TabIndex = 2;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = false;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.BackColor = Color.FromArgb(26, 39, 64);
            rdbFemale.Font = new Font("Segoe UI", 11F);
            rdbFemale.ForeColor = Color.FromArgb(230, 241, 251);
            rdbFemale.Location = new Point(108, 6);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(75, 24);
            rdbFemale.TabIndex = 3;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = false;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(133, 183, 235);
            lblAge.Location = new Point(28, 218);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(30, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "AGE";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(15, 27, 45);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 11F);
            txtAge.ForeColor = Color.FromArgb(230, 241, 251);
            txtAge.Location = new Point(28, 236);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(410, 27);
            txtAge.TabIndex = 4;
            // 
            // btnFinishRegister
            // 
            btnFinishRegister.BackColor = Color.FromArgb(24, 95, 165);
            btnFinishRegister.Cursor = Cursors.Hand;
            btnFinishRegister.FlatAppearance.BorderSize = 0;
            btnFinishRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnFinishRegister.FlatStyle = FlatStyle.Flat;
            btnFinishRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFinishRegister.ForeColor = Color.FromArgb(230, 241, 251);
            btnFinishRegister.Location = new Point(28, 288);
            btnFinishRegister.Name = "btnFinishRegister";
            btnFinishRegister.Size = new Size(410, 52);
            btnFinishRegister.TabIndex = 5;
            btnFinishRegister.Text = "Finish Registering";
            btnFinishRegister.UseVisualStyleBackColor = false;
            btnFinishRegister.Click += btnFinishRegister_Click;
            // 
            // TrainerRegisterForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(540, 560);
            Controls.Add(pictureLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrainerRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Trainer Register";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlCard;
        private Label lblSpecialty;
        private ComboBox cmbSpecialty;
        private Label lblExperience;
        private TextBox txtExperienceYears;
        private Label lblGender;
        private Panel pnlGender;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private Label lblAge;
        private TextBox txtAge;
        private Button btnFinishRegister;
    }
}