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
            listBox1 = new ListBox();
            btn_BookSession = new Button();
            btn_CancelBooking = new Button();
            chb_ShowPassword_clientform = new CheckBox();
            lbl_Password_clientform = new Label();
            txtb_Password_form = new TextBox();
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
            btn_EditProfile.Click += btn_EditProfile_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Trainer:", "", "", "Date:", "", "", "Time:" });
            listBox1.Location = new Point(420, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 154);
            listBox1.TabIndex = 9;
            // 
            // btn_BookSession
            // 
            btn_BookSession.Location = new Point(420, 243);
            btn_BookSession.Name = "btn_BookSession";
            btn_BookSession.Size = new Size(109, 23);
            btn_BookSession.TabIndex = 10;
            btn_BookSession.Text = "BookSession";
            btn_BookSession.UseVisualStyleBackColor = true;
            btn_BookSession.Click += btn_BookSession_Click;
            // 
            // btn_CancelBooking
            // 
            btn_CancelBooking.Location = new Point(535, 243);
            btn_CancelBooking.Name = "btn_CancelBooking";
            btn_CancelBooking.Size = new Size(109, 23);
            btn_CancelBooking.TabIndex = 11;
            btn_CancelBooking.Text = "CancelBooking";
            btn_CancelBooking.UseVisualStyleBackColor = true;
            btn_CancelBooking.Click += btn_CancelBooking_Click;
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
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtb_Password_form);
            Controls.Add(lbl_Password_clientform);
            Controls.Add(chb_ShowPassword_clientform);
            Controls.Add(btn_CancelBooking);
            Controls.Add(btn_BookSession);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Button btn_BookSession;
        private Button btn_CancelBooking;

        private void btn_BookSession_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_CancelBooking_Click(object sender, EventArgs e)
        {
            
        }


       
        private CheckBox chb_ShowPassword_clientform;
        private Label lbl_Password_clientform;
        private TextBox txtb_Password_form;

    }
}