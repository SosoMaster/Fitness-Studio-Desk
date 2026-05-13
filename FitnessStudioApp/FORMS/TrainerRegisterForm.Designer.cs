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
            lblSpecialty = new Label();
            cmbSpecialty = new ComboBox();
            lblExperience = new Label();
            txtExperienceYears = new TextBox();
            lblGender = new Label();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            lblAge = new Label();
            txtAge = new TextBox();
            btnFinishRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BorderStyle = BorderStyle.FixedSingle;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(75, 75);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(100, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "FITNESS APP";
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecialty.Location = new Point(135, 104);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(72, 21);
            lblSpecialty.TabIndex = 2;
            lblSpecialty.Text = "Specialty";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(75, 128);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(200, 23);
            cmbSpecialty.TabIndex = 0;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExperience.Location = new Point(100, 154);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(143, 21);
            lblExperience.TabIndex = 3;
            lblExperience.Text = "Years of Experience";
            // 
            // txtExperienceYears
            // 
            txtExperienceYears.Location = new Point(75, 182);
            txtExperienceYears.Name = "txtExperienceYears";
            txtExperienceYears.Size = new Size(200, 23);
            txtExperienceYears.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(135, 208);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(61, 21);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(75, 232);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(51, 19);
            rdbMale.TabIndex = 2;
            rdbMale.Text = "Male";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(197, 232);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(63, 19);
            rdbFemale.TabIndex = 3;
            rdbFemale.Text = "Female";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(159, 264);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 21);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(75, 288);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 23);
            txtAge.TabIndex = 4;
            // 
            // btnFinishRegister
            // 
            btnFinishRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinishRegister.Location = new Point(56, 330);
            btnFinishRegister.Name = "btnFinishRegister";
            btnFinishRegister.Size = new Size(240, 45);
            btnFinishRegister.TabIndex = 5;
            btnFinishRegister.Text = "Finish Registering";
            btnFinishRegister.UseVisualStyleBackColor = true;
            btnFinishRegister.Click += btnFinishRegister_Click;
            // 
            // TrainerRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 400);
            Controls.Add(pictureLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblSpecialty);
            Controls.Add(cmbSpecialty);
            Controls.Add(lblExperience);
            Controls.Add(txtExperienceYears);
            Controls.Add(lblGender);
            Controls.Add(rdbMale);
            Controls.Add(rdbFemale);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(btnFinishRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrainerRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer Register";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Label lblTitle;
        private Label lblSpecialty;
        private ComboBox cmbSpecialty;
        private Label lblExperience;
        private TextBox txtExperienceYears;
        private Label lblGender;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private Label lblAge;
        private TextBox txtAge;
        private Button btnFinishRegister;
    }
}