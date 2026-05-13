namespace FitnessStudioApp.FORMS
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            pictureLogo = new PictureBox();
            lblTitle = new Label();
            lblWelcome = new Label();
            grpSessions = new GroupBox();
            lblFilterSessions = new Label();
            cmbFilter = new ComboBox();
            dgvSessions = new DataGridView();
            btnAddSession = new Button();
            btnDeleteSession = new Button();
            grpBookings = new GroupBox();
            lblSelectedSession = new Label();
            dgvBookings = new DataGridView();
            grpAddSession = new GroupBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            lblCapacity = new Label();
            txtCapacity = new TextBox();
            btnConfirmAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            grpSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).BeginInit();
            grpBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            grpAddSession.SuspendLayout();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BorderStyle = BorderStyle.FixedSingle;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(55, 55);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(75, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "FITNESS APP";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblWelcome.Location = new Point(75, 46);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(97, 15);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, Trainer";
            // 
            // grpSessions
            // 
            grpSessions.Controls.Add(lblFilterSessions);
            grpSessions.Controls.Add(cmbFilter);
            grpSessions.Controls.Add(dgvSessions);
            grpSessions.Controls.Add(btnAddSession);
            grpSessions.Controls.Add(btnDeleteSession);
            grpSessions.Location = new Point(12, 80);
            grpSessions.Name = "grpSessions";
            grpSessions.Size = new Size(520, 340);
            grpSessions.TabIndex = 3;
            grpSessions.TabStop = false;
            grpSessions.Text = "My Training Sessions";
            // 
            // lblFilterSessions
            // 
            lblFilterSessions.AutoSize = true;
            lblFilterSessions.Location = new Point(10, 24);
            lblFilterSessions.Name = "lblFilterSessions";
            lblFilterSessions.Size = new Size(39, 15);
            lblFilterSessions.TabIndex = 0;
            lblFilterSessions.Text = "Show:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All Sessions", "Upcoming Only" });
            cmbFilter.Location = new Point(55, 21);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(140, 23);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // dgvSessions
            // 
            dgvSessions.AllowUserToAddRows = false;
            dgvSessions.AllowUserToDeleteRows = false;
            dgvSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSessions.BackgroundColor = SystemColors.Control;
            dgvSessions.Location = new Point(10, 52);
            dgvSessions.MultiSelect = false;
            dgvSessions.Name = "dgvSessions";
            dgvSessions.ReadOnly = true;
            dgvSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSessions.Size = new Size(500, 230);
            dgvSessions.TabIndex = 2;
            dgvSessions.SelectionChanged += dgvSessions_SelectionChanged;
            // 
            // btnAddSession
            // 
            btnAddSession.Location = new Point(10, 295);
            btnAddSession.Name = "btnAddSession";
            btnAddSession.Size = new Size(130, 32);
            btnAddSession.TabIndex = 3;
            btnAddSession.Text = "＋ Add Session";
            btnAddSession.Click += btnAddSession_Click;
            // 
            // btnDeleteSession
            // 
            btnDeleteSession.Location = new Point(150, 295);
            btnDeleteSession.Name = "btnDeleteSession";
            btnDeleteSession.Size = new Size(130, 32);
            btnDeleteSession.TabIndex = 4;
            btnDeleteSession.Text = "🗑 Delete Session";
            btnDeleteSession.Click += btnDeleteSession_Click;
            // 
            // grpBookings
            // 
            grpBookings.Controls.Add(lblSelectedSession);
            grpBookings.Controls.Add(dgvBookings);
            grpBookings.Location = new Point(545, 80);
            grpBookings.Name = "grpBookings";
            grpBookings.Size = new Size(430, 340);
            grpBookings.TabIndex = 4;
            grpBookings.TabStop = false;
            grpBookings.Text = "Clients Booked for Selected Session";
            // 
            // lblSelectedSession
            // 
            lblSelectedSession.AutoSize = true;
            lblSelectedSession.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblSelectedSession.Location = new Point(10, 24);
            lblSelectedSession.Name = "lblSelectedSession";
            lblSelectedSession.Size = new Size(198, 15);
            lblSelectedSession.TabIndex = 0;
            lblSelectedSession.Text = "← Select a session to see its bookings";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = SystemColors.Control;
            dgvBookings.Location = new Point(10, 48);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(410, 275);
            dgvBookings.TabIndex = 1;
            // 
            // grpAddSession
            // 
            grpAddSession.Controls.Add(lblDescription);
            grpAddSession.Controls.Add(txtDescription);
            grpAddSession.Controls.Add(lblStartTime);
            grpAddSession.Controls.Add(dtpStartTime);
            grpAddSession.Controls.Add(lblEndTime);
            grpAddSession.Controls.Add(dtpEndTime);
            grpAddSession.Controls.Add(lblCapacity);
            grpAddSession.Controls.Add(txtCapacity);
            grpAddSession.Controls.Add(btnConfirmAdd);
            grpAddSession.Location = new Point(12, 435);
            grpAddSession.Name = "grpAddSession";
            grpAddSession.Size = new Size(963, 110);
            grpAddSession.TabIndex = 5;
            grpAddSession.TabStop = false;
            grpAddSession.Text = "New Session Details";
            grpAddSession.Visible = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(10, 28);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(85, 25);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 23);
            txtDescription.TabIndex = 1;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(320, 28);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(34, 15);
            lblStartTime.TabIndex = 2;
            lblStartTime.Text = "Start:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(360, 25);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(155, 23);
            dtpStartTime.TabIndex = 3;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(525, 28);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(30, 15);
            lblEndTime.TabIndex = 4;
            lblEndTime.Text = "End:";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(558, 25);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(155, 23);
            dtpEndTime.TabIndex = 5;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(725, 28);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 6;
            lblCapacity.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(785, 25);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(60, 23);
            txtCapacity.TabIndex = 7;
            // 
            // btnConfirmAdd
            // 
            btnConfirmAdd.Font = new Font("Segoe UI", 9.5F);
            btnConfirmAdd.Location = new Point(860, 20);
            btnConfirmAdd.Name = "btnConfirmAdd";
            btnConfirmAdd.Size = new Size(90, 32);
            btnConfirmAdd.TabIndex = 8;
            btnConfirmAdd.Text = "✔ Confirm";
            btnConfirmAdd.Click += btnConfirmAdd_Click;
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 560);
            Controls.Add(pictureLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblWelcome);
            Controls.Add(grpSessions);
            Controls.Add(grpBookings);
            Controls.Add(grpAddSession);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer Dashboard";
            Load += TrainerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            grpSessions.ResumeLayout(false);
            grpSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).EndInit();
            grpBookings.ResumeLayout(false);
            grpBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            grpAddSession.ResumeLayout(false);
            grpAddSession.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Label lblTitle;
        private Label lblWelcome;

        private GroupBox grpSessions;
        private Label lblFilterSessions;
        private ComboBox cmbFilter;
        private DataGridView dgvSessions;
        private Button btnAddSession;
        private Button btnDeleteSession;

        private GroupBox grpBookings;
        private Label lblSelectedSession;
        private DataGridView dgvBookings;

        private GroupBox grpAddSession;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblEndTime;
        private DateTimePicker dtpEndTime;
        private Label lblCapacity;
        private TextBox txtCapacity;
        private Button btnConfirmAdd;
    }
}