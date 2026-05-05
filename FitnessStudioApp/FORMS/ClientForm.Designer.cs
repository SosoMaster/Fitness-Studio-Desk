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
            btn_EditProfile.Location = new Point(61, 191);
            btn_EditProfile.Name = "btn_EditProfile";
            btn_EditProfile.Size = new Size(100, 26);
            btn_EditProfile.TabIndex = 8;
            btn_EditProfile.Text = "Edit Profile";
            btn_EditProfile.UseVisualStyleBackColor = true;
            btn_EditProfile.Click += Btn_EditProfile_Click;
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
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            try
            {
               
                var hasBooking = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    var itemText = (listBox1.Items[i] ?? string.Empty).ToString();
                    if (string.IsNullOrWhiteSpace(itemText))
                        continue;
                    if (itemText == "Trainer:" || itemText == "Date:" || itemText == "Time:")
                        continue;
                    hasBooking = true;
                    break;
                }

                if (hasBooking)
                {
                    var overwrite = MessageBox.Show(this, "You already have a booking. Overwrite it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (overwrite != DialogResult.Yes)
                        return;
                }

              
                var trainer = Microsoft.VisualBasic.Interaction.InputBox("Enter trainer name:", "Book Session", "");
                if (string.IsNullOrWhiteSpace(trainer))
                {
                    MessageBox.Show(this, "Booking cancelled or trainer not provided.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

              
                var dateInput = Microsoft.VisualBasic.Interaction.InputBox("Enter date (e.g. 2026-04-30):", "Book Session - Date", DateTime.Today.ToString("yyyy-MM-dd"));
                if (string.IsNullOrWhiteSpace(dateInput))
                {
                    MessageBox.Show(this, "Booking cancelled or date not provided.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!DateTime.TryParse(dateInput, out var parsedDate))
                {
                    MessageBox.Show(this, "Invalid date format. Please use a valid date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                var timeInput = Microsoft.VisualBasic.Interaction.InputBox("Enter time (e.g. 14:30):", "Book Session - Time", "09:00");
                if (string.IsNullOrWhiteSpace(timeInput))
                {
                    MessageBox.Show(this, "Booking cancelled or time not provided.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                TimeSpan parsedTime;
                if (!TimeSpan.TryParse(timeInput, out parsedTime))
                {
                    
                    if (DateTime.TryParse(timeInput, out var dt))
                    {
                        parsedTime = dt.TimeOfDay;
                    }
                    else
                    {
                        MessageBox.Show(this, "Invalid time format. Please use HH:mm or a valid time.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

               
                listBox1.Items.Clear();
                listBox1.Items.AddRange(new object[]
                {
                    "Trainer:", trainer, "",
                    "Date:", parsedDate.ToString("yyyy-MM-dd"), "",
                    "Time:", parsedTime.ToString(@"hh\:mm")
                });

                MessageBox.Show(this, "Session booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred while booking the session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_CancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
               
                var hasBooking = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    var itemText = (listBox1.Items[i] ?? string.Empty).ToString();
                    if (string.IsNullOrWhiteSpace(itemText))
                        continue;
                    if (itemText == "Trainer:" || itemText == "Date:" || itemText == "Time:")
                        continue;
                    
                    hasBooking = true;
                    break;
                }

                if (!hasBooking)
                {
                    MessageBox.Show(this, "No booking to cancel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show(this, "Are you sure you want to cancel the booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

               
                listBox1.Items.Clear();
                listBox1.Items.AddRange(new object[] { "Trainer:", "", "", "Date:", "", "", "Time:" });

                MessageBox.Show(this, "Booking cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred while cancelling the booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_EditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                
                var isSaveMode = string.Equals(btn_EditProfile.Text, "Save", StringComparison.OrdinalIgnoreCase);

                if (isSaveMode)
                {
                    
                    btn_EditProfile.Text = "Save";

                    textBox1.ReadOnly = false;
                    txtb_Email.ReadOnly = false;
                    txtb_Phone.ReadOnly = false;

                    textBox1.BackColor = SystemColors.Window;
                    txtb_Email.BackColor = SystemColors.Window;
                    txtb_Phone.BackColor = SystemColors.Window;

                    textBox1.Focus();
                    return;
                }

               
                var name = textBox1.Text?.Trim() ?? string.Empty;
                var email = txtb_Email.Text?.Trim() ?? string.Empty;
                var phone = txtb_Phone.Text?.Trim() ?? string.Empty;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show(this, "Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                {
                    MessageBox.Show(this, "Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtb_Email.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show(this, "Please enter a phone number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtb_Phone.Focus();
                    return;
                }

               
                btn_EditProfile.Text = "Edit Profile";

                textBox1.ReadOnly = true;
                txtb_Email.ReadOnly = true;
                txtb_Phone.ReadOnly = true;

                
                textBox1.BackColor = SystemColors.Control;
                txtb_Email.BackColor = SystemColors.Control;
                txtb_Phone.BackColor = SystemColors.Control;

                MessageBox.Show(this, "Profile saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
       
    }
}