namespace FitnessStudioApp.FORMS
{
    partial class ClientForm
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
            lbl_Name = new Label();
            lbl_Phone = new Label();
            lbl_Email = new Label();
            textBox1 = new TextBox();
            txtb_Email = new TextBox();
            txtb_Phone = new TextBox();
            btn_EditProfile = new Button();
            chb_ShowPassword_clientform = new CheckBox();
            lbl_Password_clientform = new Label();
            txtb_Password_form = new TextBox();
            monthCalendar1 = new MonthCalendar();
            cmb_Trainer = new ComboBox();
            cmb_TrainingSession = new ComboBox();
            btn_Cancel = new Button();
            btn_Create = new Button();
            SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(61, 45);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(39, 15);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "Name";
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new Point(61, 129);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(41, 15);
            lbl_Phone.TabIndex = 1;
            lbl_Phone.Text = "Phone";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(61, 89);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // txtb_Email
            // 
            txtb_Email.Location = new Point(61, 107);
            txtb_Email.Name = "txtb_Email";
            txtb_Email.Size = new Size(100, 23);
            txtb_Email.TabIndex = 5;
            // 
            // txtb_Phone
            // 
            txtb_Phone.Location = new Point(61, 147);
            txtb_Phone.Name = "txtb_Phone";
            txtb_Phone.Size = new Size(100, 23);
            txtb_Phone.TabIndex = 6;
            // 
            // btn_EditProfile
            // 
            btn_EditProfile.Location = new Point(61, 248);
            btn_EditProfile.Name = "btn_EditProfile";
            btn_EditProfile.Size = new Size(100, 26);
            btn_EditProfile.TabIndex = 8;
            btn_EditProfile.Text = "Edit Profile";
            btn_EditProfile.UseVisualStyleBackColor = true;
            // 
            // chb_ShowPassword_clientform
            // 
            chb_ShowPassword_clientform.AutoSize = true;
            chb_ShowPassword_clientform.Location = new Point(61, 223);
            chb_ShowPassword_clientform.Name = "chb_ShowPassword_clientform";
            chb_ShowPassword_clientform.Size = new Size(108, 19);
            chb_ShowPassword_clientform.TabIndex = 12;
            chb_ShowPassword_clientform.Text = "Show Password";
            chb_ShowPassword_clientform.UseVisualStyleBackColor = true;
            chb_ShowPassword_clientform.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lbl_Password_clientform
            // 
            lbl_Password_clientform.AutoSize = true;
            lbl_Password_clientform.Location = new Point(61, 176);
            lbl_Password_clientform.Name = "lbl_Password_clientform";
            lbl_Password_clientform.Size = new Size(52, 15);
            lbl_Password_clientform.TabIndex = 13;
            lbl_Password_clientform.Text = "Pasword";
            // 
            // txtb_Password_form
            // 
            txtb_Password_form.Location = new Point(61, 194);
            txtb_Password_form.Name = "txtb_Password_form";
            txtb_Password_form.Size = new Size(100, 23);
            txtb_Password_form.TabIndex = 14;
            txtb_Password_form.UseSystemPasswordChar = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(464, 130);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 19;
            // 
            // cmb_Trainer
            // 
            cmb_Trainer.FormattingEnabled = true;
            cmb_Trainer.Location = new Point(521, 94);
            cmb_Trainer.Name = "cmb_Trainer";
            cmb_Trainer.Size = new Size(121, 23);
            cmb_Trainer.TabIndex = 18;
            // 
            // cmb_TrainingSession
            // 
            cmb_TrainingSession.FormattingEnabled = true;
            cmb_TrainingSession.Location = new Point(521, 45);
            cmb_TrainingSession.Name = "cmb_TrainingSession";
            cmb_TrainingSession.Size = new Size(121, 23);
            cmb_TrainingSession.TabIndex = 17;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(537, 375);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 16;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(498, 335);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(152, 23);
            btn_Create.TabIndex = 15;
            btn_Create.Text = "Create Reservation";
            btn_Create.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(cmb_Trainer);
            Controls.Add(cmb_TrainingSession);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Create);
            Controls.Add(txtb_Password_form);
            Controls.Add(lbl_Password_clientform);
            Controls.Add(chb_ShowPassword_clientform);
            Controls.Add(btn_EditProfile);
            Controls.Add(txtb_Phone);
            Controls.Add(txtb_Email);
            Controls.Add(textBox1);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Phone);
            Controls.Add(lbl_Name);
            Name = "ClientForm";
            Text = "ClientForm";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion      #endregion  


        private Label lbl_Name;
        private Label lbl_Phone;
        private Label txtb_Membership;
        private Label lbl_Email;
        private TextBox textBox1;
        private TextBox txtb_Email;
        private TextBox txtb_Phone;
        private Button btn_EditProfile;
        private TextBox textBox4;
        private Button button1;

        private void btn_BookSession_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Iskate li da zapazite sesiqta?", 
                "Save session",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // loika za zapazvane
            }
            else
            {

            }
        }
        private void btn_CancelBooking_Click(object sender, EventArgs e)
        {
            
        }


       
        private CheckBox chb_ShowPassword_clientform;
        private Label lbl_Password_clientform;
        private TextBox txtb_Password_form;
        private MonthCalendar monthCalendar1;
        private ComboBox cmb_Trainer;
        private ComboBox cmb_TrainingSession;
        private Button btn_Cancel;
        private Button btn_Create;
    }
}