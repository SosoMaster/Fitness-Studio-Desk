namespace FitnessStudioApp.FORMS
{
    partial class ClientRegisterForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegisterForm));
            cmbTrainers = new ComboBox();
            trainerBindingSource = new BindingSource(components);
            lblRegisterAs = new Label();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            btnFinishRegister = new Button();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            lblHeight = new Label();
            lblWeight = new Label();
            lblGender = new Label();
            lblAge = new Label();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)trainerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbTrainers
            // 
            cmbTrainers.DataSource = trainerBindingSource;
            cmbTrainers.FormattingEnabled = true;
            cmbTrainers.Location = new Point(401, 440);
            cmbTrainers.Margin = new Padding(3, 4, 3, 4);
            cmbTrainers.Name = "cmbTrainers";
            cmbTrainers.Size = new Size(193, 28);
            cmbTrainers.TabIndex = 25;
            // 
            // trainerBindingSource
            // 
            trainerBindingSource.DataSource = typeof(MODELS.Trainer);
            // 
            // lblRegisterAs
            // 
            lblRegisterAs.AutoSize = true;
            lblRegisterAs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterAs.Location = new Point(425, 408);
            lblRegisterAs.Name = "lblRegisterAs";
            lblRegisterAs.Size = new Size(140, 28);
            lblRegisterAs.TabIndex = 24;
            lblRegisterAs.Text = "Choose Trainer";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(401, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 46);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "FITNESS APP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 43);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnFinishRegister
            // 
            btnFinishRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinishRegister.Location = new Point(401, 479);
            btnFinishRegister.Margin = new Padding(3, 4, 3, 4);
            btnFinishRegister.Name = "btnFinishRegister";
            btnFinishRegister.Size = new Size(193, 101);
            btnFinishRegister.TabIndex = 21;
            btnFinishRegister.Text = "Finish Registering";
            btnFinishRegister.UseVisualStyleBackColor = true;
            btnFinishRegister.Click += btnFinishRegister_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(401, 373);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(193, 27);
            txtWeight.TabIndex = 20;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(401, 307);
            txtHeight.Margin = new Padding(3, 4, 3, 4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(193, 27);
            txtHeight.TabIndex = 19;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(401, 176);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(193, 27);
            txtAge.TabIndex = 17;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(462, 277);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(71, 28);
            lblHeight.TabIndex = 16;
            lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(462, 341);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(75, 28);
            lblWeight.TabIndex = 15;
            lblWeight.Text = "Weight";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(462, 211);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(76, 28);
            lblGender.TabIndex = 14;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(471, 144);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(47, 28);
            lblAge.TabIndex = 13;
            lblAge.Text = "Age";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMale.Location = new Point(401, 248);
            rdbMale.Margin = new Padding(3, 4, 3, 4);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(76, 32);
            rdbMale.TabIndex = 28;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbFemale.Location = new Point(505, 248);
            rdbFemale.Margin = new Padding(3, 4, 3, 4);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(95, 32);
            rdbFemale.TabIndex = 29;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // ClientRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(rdbFemale);
            Controls.Add(rdbMale);
            Controls.Add(cmbTrainers);
            Controls.Add(lblRegisterAs);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(btnFinishRegister);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientRegisterForm";
            Text = "ClientRegisterForm";
            Load += ClientRegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)trainerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTrainers;
        private Label lblRegisterAs;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Button btnFinishRegister;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtEmail;
        private TextBox txtAge;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblGender;
        private Label lblAge;
        private BindingSource trainerBindingSource;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
    }
}