namespace FitnessStudioApp.FORMS
{
    partial class ClientRegisterForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegisterForm));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlCard = new Panel();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            pnlGender = new Panel();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            pnlDivider = new Panel();
            lblRegisterAs = new Label();
            cmbTrainers = new ComboBox();
            trainerBindingSource = new BindingSource(components);
            btnFinishRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCard.SuspendLayout();
            pnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
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
            lblSubtitle.Size = new Size(170, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Complete your client profile";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblAge);
            pnlCard.Controls.Add(txtAge);
            pnlCard.Controls.Add(lblGender);
            pnlCard.Controls.Add(pnlGender);
            pnlCard.Controls.Add(lblHeight);
            pnlCard.Controls.Add(txtHeight);
            pnlCard.Controls.Add(lblWeight);
            pnlCard.Controls.Add(txtWeight);
            pnlCard.Controls.Add(pnlDivider);
            pnlCard.Controls.Add(lblRegisterAs);
            pnlCard.Controls.Add(cmbTrainers);
            pnlCard.Controls.Add(btnFinishRegister);
            pnlCard.Location = new Point(36, 88);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(468, 568);
            pnlCard.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(133, 183, 235);
            lblAge.Location = new Point(28, 24);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(30, 15);
            lblAge.TabIndex = 0;
            lblAge.Text = "AGE";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(15, 27, 45);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 11F);
            txtAge.ForeColor = Color.FromArgb(230, 241, 251);
            txtAge.Location = new Point(28, 42);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(410, 27);
            txtAge.TabIndex = 0;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(133, 183, 235);
            lblGender.Location = new Point(28, 86);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 15);
            lblGender.TabIndex = 1;
            lblGender.Text = "GENDER";
            // 
            // pnlGender
            // 
            pnlGender.BackColor = Color.FromArgb(26, 39, 64);
            pnlGender.Controls.Add(rdbMale);
            pnlGender.Controls.Add(rdbFemale);
            pnlGender.Location = new Point(28, 104);
            pnlGender.Name = "pnlGender";
            pnlGender.Size = new Size(205, 36);
            pnlGender.TabIndex = 2;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.BackColor = Color.FromArgb(26, 39, 64);
            rdbMale.Font = new Font("Segoe UI", 11F);
            rdbMale.ForeColor = Color.FromArgb(230, 241, 251);
            rdbMale.Location = new Point(3, 6);
            rdbMale.Margin = new Padding(3, 4, 3, 4);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(60, 24);
            rdbMale.TabIndex = 1;
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
            rdbFemale.Location = new Point(110, 6);
            rdbFemale.Margin = new Padding(3, 4, 3, 4);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(75, 24);
            rdbFemale.TabIndex = 2;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = false;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHeight.ForeColor = Color.FromArgb(133, 183, 235);
            lblHeight.Location = new Point(28, 156);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(79, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "HEIGHT (cm)";
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.FromArgb(15, 27, 45);
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Font = new Font("Segoe UI", 11F);
            txtHeight.ForeColor = Color.FromArgb(230, 241, 251);
            txtHeight.Location = new Point(28, 174);
            txtHeight.Margin = new Padding(3, 4, 3, 4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(410, 27);
            txtHeight.TabIndex = 3;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblWeight.ForeColor = Color.FromArgb(133, 183, 235);
            lblWeight.Location = new Point(28, 218);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(79, 15);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "WEIGHT (kg)";
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.FromArgb(15, 27, 45);
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("Segoe UI", 11F);
            txtWeight.ForeColor = Color.FromArgb(230, 241, 251);
            txtWeight.Location = new Point(28, 236);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(410, 27);
            txtWeight.TabIndex = 4;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(35, 55, 90);
            pnlDivider.Location = new Point(28, 280);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(410, 1);
            pnlDivider.TabIndex = 5;
            // 
            // lblRegisterAs
            // 
            lblRegisterAs.AutoSize = true;
            lblRegisterAs.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRegisterAs.ForeColor = Color.FromArgb(133, 183, 235);
            lblRegisterAs.Location = new Point(28, 292);
            lblRegisterAs.Name = "lblRegisterAs";
            lblRegisterAs.Size = new Size(107, 15);
            lblRegisterAs.TabIndex = 6;
            lblRegisterAs.Text = "CHOOSE TRAINER";
            // 
            // cmbTrainers
            // 
            cmbTrainers.BackColor = Color.FromArgb(15, 27, 45);
            cmbTrainers.DataSource = trainerBindingSource;
            cmbTrainers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrainers.FlatStyle = FlatStyle.Flat;
            cmbTrainers.Font = new Font("Segoe UI", 11F);
            cmbTrainers.ForeColor = Color.FromArgb(230, 241, 251);
            cmbTrainers.FormattingEnabled = true;
            cmbTrainers.Location = new Point(28, 310);
            cmbTrainers.Margin = new Padding(3, 4, 3, 4);
            cmbTrainers.Name = "cmbTrainers";
            cmbTrainers.Size = new Size(410, 28);
            cmbTrainers.TabIndex = 5;
            // 
            // trainerBindingSource
            // 
            trainerBindingSource.DataSource = typeof(MODELS.Trainer);
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
            btnFinishRegister.Location = new Point(28, 360);
            btnFinishRegister.Margin = new Padding(3, 4, 3, 4);
            btnFinishRegister.Name = "btnFinishRegister";
            btnFinishRegister.Size = new Size(410, 52);
            btnFinishRegister.TabIndex = 6;
            btnFinishRegister.Text = "Finish Registering ";
            btnFinishRegister.UseVisualStyleBackColor = false;
            btnFinishRegister.Click += btnFinishRegister_Click;
            // 
            // ClientRegisterForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(540, 680);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ClientRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Complete Profile";
            Load += ClientRegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlCard;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private Panel pnlGender;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private Label lblHeight;
        private TextBox txtHeight;
        private Label lblWeight;
        private TextBox txtWeight;
        private Panel pnlDivider;
        private Label lblRegisterAs;
        private BindingSource trainerBindingSource;
        private ComboBox cmbTrainers;
        private Button btnFinishRegister;
        private TextBox txtEmail;
    }
}