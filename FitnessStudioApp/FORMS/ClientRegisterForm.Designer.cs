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
            cmbTrainers.Location = new Point(351, 330);
            cmbTrainers.Name = "cmbTrainers";
            cmbTrainers.Size = new Size(169, 23);
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
            lblRegisterAs.Location = new Point(372, 306);
            lblRegisterAs.Name = "lblRegisterAs";
            lblRegisterAs.Size = new Size(114, 21);
            lblRegisterAs.TabIndex = 24;
            lblRegisterAs.Text = "Choose Trainer";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(351, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 37);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "FITNESS APP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(269, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnFinishRegister
            // 
            btnFinishRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinishRegister.Location = new Point(351, 359);
            btnFinishRegister.Name = "btnFinishRegister";
            btnFinishRegister.Size = new Size(169, 76);
            btnFinishRegister.TabIndex = 21;
            btnFinishRegister.Text = "Finish Registering";
            btnFinishRegister.UseVisualStyleBackColor = true;
            btnFinishRegister.Click += btnFinishRegister_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(351, 280);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(169, 23);
            txtWeight.TabIndex = 20;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(351, 230);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(169, 23);
            txtHeight.TabIndex = 19;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(351, 132);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(169, 23);
            txtAge.TabIndex = 17;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(404, 208);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(56, 21);
            lblHeight.TabIndex = 16;
            lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(404, 256);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(59, 21);
            lblWeight.TabIndex = 15;
            lblWeight.Text = "Weight";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(404, 158);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(61, 21);
            lblGender.TabIndex = 14;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(412, 108);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 21);
            lblAge.TabIndex = 13;
            lblAge.Text = "Age";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMale.Location = new Point(351, 186);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(62, 25);
            rdbMale.TabIndex = 28;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbFemale.Location = new Point(442, 186);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(78, 25);
            rdbFemale.TabIndex = 29;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // ClientRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "ClientRegisterForm";
            Text = "ClientRegisterForm";
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