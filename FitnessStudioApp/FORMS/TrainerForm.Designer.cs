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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureLogo = new PictureBox();
            lblTitle = new Label();
            lblWelcome = new Label();
            pnlSessions = new Panel();
            lblSessionsHeader = new Label();
            lblFilterSessions = new Label();
            cmbFilter = new ComboBox();
            dgvSessions = new DataGridView();
            btnAddSession = new Button();
            btnDeleteSession = new Button();
            pnlBookings = new Panel();
            lblBookingsHeader = new Label();
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
            pnlSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).BeginInit();
            pnlBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            grpAddSession.SuspendLayout();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(20, 16);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(50, 48);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 241, 251);
            lblTitle.Location = new Point(78, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "FITNESS APP";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblWelcome.ForeColor = Color.FromArgb(55, 138, 221);
            lblWelcome.Location = new Point(80, 48);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(97, 15);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, Trainer";
            // 
            // pnlSessions
            // 
            pnlSessions.BackColor = Color.FromArgb(26, 39, 64);
            pnlSessions.BorderStyle = BorderStyle.FixedSingle;
            pnlSessions.Controls.Add(lblSessionsHeader);
            pnlSessions.Controls.Add(lblFilterSessions);
            pnlSessions.Controls.Add(cmbFilter);
            pnlSessions.Controls.Add(dgvSessions);
            pnlSessions.Controls.Add(btnAddSession);
            pnlSessions.Controls.Add(btnDeleteSession);
            pnlSessions.Location = new Point(16, 76);
            pnlSessions.Name = "pnlSessions";
            pnlSessions.Size = new Size(530, 400);
            pnlSessions.TabIndex = 3;
            // 
            // lblSessionsHeader
            // 
            lblSessionsHeader.AutoSize = true;
            lblSessionsHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSessionsHeader.ForeColor = Color.FromArgb(133, 183, 235);
            lblSessionsHeader.Location = new Point(12, 14);
            lblSessionsHeader.Name = "lblSessionsHeader";
            lblSessionsHeader.Size = new Size(145, 15);
            lblSessionsHeader.TabIndex = 0;
            lblSessionsHeader.Text = "MY TRAINING SESSIONS";
            // 
            // lblFilterSessions
            // 
            lblFilterSessions.AutoSize = true;
            lblFilterSessions.Font = new Font("Segoe UI", 9F);
            lblFilterSessions.ForeColor = Color.FromArgb(133, 183, 235);
            lblFilterSessions.Location = new Point(12, 36);
            lblFilterSessions.Name = "lblFilterSessions";
            lblFilterSessions.Size = new Size(39, 15);
            lblFilterSessions.TabIndex = 1;
            lblFilterSessions.Text = "Show:";
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = Color.FromArgb(15, 27, 45);
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FlatStyle = FlatStyle.Flat;
            cmbFilter.Font = new Font("Segoe UI", 9.5F);
            cmbFilter.ForeColor = Color.FromArgb(230, 241, 251);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All Sessions", "Upcoming Only" });
            cmbFilter.Location = new Point(58, 33);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(150, 25);
            cmbFilter.TabIndex = 0;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // dgvSessions
            // 
            dgvSessions.AllowUserToAddRows = false;
            dgvSessions.AllowUserToDeleteRows = false;
            dgvSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSessions.BackgroundColor = Color.FromArgb(15, 27, 45);
            dgvSessions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 35, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(133, 183, 235);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 27, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 241, 251);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 95, 165);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(230, 241, 251);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSessions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSessions.EnableHeadersVisualStyles = false;
            dgvSessions.GridColor = Color.FromArgb(35, 55, 90);
            dgvSessions.Location = new Point(12, 64);
            dgvSessions.MultiSelect = false;
            dgvSessions.Name = "dgvSessions";
            dgvSessions.ReadOnly = true;
            dgvSessions.RowHeadersVisible = false;
            dgvSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSessions.Size = new Size(506, 278);
            dgvSessions.TabIndex = 1;
            dgvSessions.SelectionChanged += dgvSessions_SelectionChanged;
            // 
            // btnAddSession
            // 
            btnAddSession.BackColor = Color.FromArgb(24, 95, 165);
            btnAddSession.Cursor = Cursors.Hand;
            btnAddSession.FlatAppearance.BorderSize = 0;
            btnAddSession.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnAddSession.FlatStyle = FlatStyle.Flat;
            btnAddSession.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddSession.ForeColor = Color.FromArgb(230, 241, 251);
            btnAddSession.Location = new Point(12, 352);
            btnAddSession.Name = "btnAddSession";
            btnAddSession.Size = new Size(240, 36);
            btnAddSession.TabIndex = 2;
            btnAddSession.Text = "＋ Add Session";
            btnAddSession.UseVisualStyleBackColor = false;
            btnAddSession.Click += btnAddSession_Click;
            // 
            // btnDeleteSession
            // 
            btnDeleteSession.BackColor = Color.FromArgb(26, 39, 64);
            btnDeleteSession.Cursor = Cursors.Hand;
            btnDeleteSession.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnDeleteSession.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 40, 40);
            btnDeleteSession.FlatStyle = FlatStyle.Flat;
            btnDeleteSession.Font = new Font("Segoe UI", 9.5F);
            btnDeleteSession.ForeColor = Color.FromArgb(220, 100, 100);
            btnDeleteSession.Location = new Point(262, 352);
            btnDeleteSession.Name = "btnDeleteSession";
            btnDeleteSession.Size = new Size(240, 36);
            btnDeleteSession.TabIndex = 3;
            btnDeleteSession.Text = "🗑 Delete Session";
            btnDeleteSession.UseVisualStyleBackColor = false;
            btnDeleteSession.Click += btnDeleteSession_Click;
            // 
            // pnlBookings
            // 
            pnlBookings.BackColor = Color.FromArgb(26, 39, 64);
            pnlBookings.BorderStyle = BorderStyle.FixedSingle;
            pnlBookings.Controls.Add(lblBookingsHeader);
            pnlBookings.Controls.Add(lblSelectedSession);
            pnlBookings.Controls.Add(dgvBookings);
            pnlBookings.Location = new Point(558, 76);
            pnlBookings.Name = "pnlBookings";
            pnlBookings.Size = new Size(414, 400);
            pnlBookings.TabIndex = 4;
            // 
            // lblBookingsHeader
            // 
            lblBookingsHeader.AutoSize = true;
            lblBookingsHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblBookingsHeader.ForeColor = Color.FromArgb(133, 183, 235);
            lblBookingsHeader.Location = new Point(12, 14);
            lblBookingsHeader.Name = "lblBookingsHeader";
            lblBookingsHeader.Size = new Size(240, 15);
            lblBookingsHeader.TabIndex = 0;
            lblBookingsHeader.Text = "CLIENTS BOOKED FOR SELECTED SESSION";
            // 
            // lblSelectedSession
            // 
            lblSelectedSession.AutoSize = true;
            lblSelectedSession.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblSelectedSession.ForeColor = Color.FromArgb(80, 120, 170);
            lblSelectedSession.Location = new Point(12, 34);
            lblSelectedSession.Name = "lblSelectedSession";
            lblSelectedSession.Size = new Size(198, 15);
            lblSelectedSession.TabIndex = 1;
            lblSelectedSession.Text = "← Select a session to see its bookings";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.FromArgb(15, 27, 45);
            dgvBookings.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 35, 58);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(133, 183, 235);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 27, 45);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 241, 251);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(24, 95, 165);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(230, 241, 251);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(35, 55, 90);
            dgvBookings.Location = new Point(12, 58);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(390, 330);
            dgvBookings.TabIndex = 4;
            // 
            // grpAddSession
            // 
            grpAddSession.BackColor = Color.FromArgb(26, 39, 64);
            grpAddSession.Controls.Add(lblDescription);
            grpAddSession.Controls.Add(txtDescription);
            grpAddSession.Controls.Add(lblStartTime);
            grpAddSession.Controls.Add(dtpStartTime);
            grpAddSession.Controls.Add(lblEndTime);
            grpAddSession.Controls.Add(dtpEndTime);
            grpAddSession.Controls.Add(lblCapacity);
            grpAddSession.Controls.Add(txtCapacity);
            grpAddSession.Controls.Add(btnConfirmAdd);
            grpAddSession.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            grpAddSession.ForeColor = Color.FromArgb(133, 183, 235);
            grpAddSession.Location = new Point(16, 488);
            grpAddSession.Name = "grpAddSession";
            grpAddSession.Size = new Size(956, 90);
            grpAddSession.TabIndex = 5;
            grpAddSession.TabStop = false;
            grpAddSession.Text = "NEW SESSION DETAILS";
            grpAddSession.Visible = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(133, 183, 235);
            lblDescription.Location = new Point(10, 32);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(15, 27, 45);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.FromArgb(230, 241, 251);
            txtDescription.Location = new Point(90, 29);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 25);
            txtDescription.TabIndex = 5;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 9F);
            lblStartTime.ForeColor = Color.FromArgb(133, 183, 235);
            lblStartTime.Location = new Point(322, 32);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(34, 15);
            lblStartTime.TabIndex = 6;
            lblStartTime.Text = "Start:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CalendarForeColor = Color.FromArgb(230, 241, 251);
            dtpStartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpStartTime.Font = new Font("Segoe UI", 10F);
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(362, 29);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(160, 25);
            dtpStartTime.TabIndex = 6;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 9F);
            lblEndTime.ForeColor = Color.FromArgb(133, 183, 235);
            lblEndTime.Location = new Point(532, 32);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(30, 15);
            lblEndTime.TabIndex = 7;
            lblEndTime.Text = "End:";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEndTime.Font = new Font("Segoe UI", 10F);
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(562, 29);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(160, 25);
            dtpEndTime.TabIndex = 7;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F);
            lblCapacity.ForeColor = Color.FromArgb(133, 183, 235);
            lblCapacity.Location = new Point(732, 32);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 8;
            lblCapacity.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.FromArgb(15, 27, 45);
            txtCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtCapacity.Font = new Font("Segoe UI", 10F);
            txtCapacity.ForeColor = Color.FromArgb(230, 241, 251);
            txtCapacity.Location = new Point(796, 29);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(60, 25);
            txtCapacity.TabIndex = 8;
            // 
            // btnConfirmAdd
            // 
            btnConfirmAdd.BackColor = Color.FromArgb(24, 95, 165);
            btnConfirmAdd.Cursor = Cursors.Hand;
            btnConfirmAdd.FlatAppearance.BorderSize = 0;
            btnConfirmAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnConfirmAdd.FlatStyle = FlatStyle.Flat;
            btnConfirmAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmAdd.ForeColor = Color.FromArgb(230, 241, 251);
            btnConfirmAdd.Location = new Point(866, 24);
            btnConfirmAdd.Name = "btnConfirmAdd";
            btnConfirmAdd.Size = new Size(82, 34);
            btnConfirmAdd.TabIndex = 9;
            btnConfirmAdd.Text = "✔";
            btnConfirmAdd.UseVisualStyleBackColor = false;
            btnConfirmAdd.Click += btnConfirmAdd_Click;
            // 
            // TrainerForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(990, 602);
            Controls.Add(pictureLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblWelcome);
            Controls.Add(pnlSessions);
            Controls.Add(pnlBookings);
            Controls.Add(grpAddSession);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Trainer Dashboard";
            Load += TrainerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            pnlSessions.ResumeLayout(false);
            pnlSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).EndInit();
            pnlBookings.ResumeLayout(false);
            pnlBookings.PerformLayout();
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
        private Panel pnlSessions;
        private Label lblSessionsHeader;
        private Label lblFilterSessions;
        private ComboBox cmbFilter;
        private DataGridView dgvSessions;
        private Button btnAddSession;
        private Button btnDeleteSession;
        private Panel pnlBookings;
        private Label lblBookingsHeader;
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