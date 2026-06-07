namespace FitnessStudioApp.FORMS
{
    partial class AdminUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersForm));

            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlClients = new Panel();
            lblClientsHeader = new Label();
            lbxClients = new ListBox();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            pnlTrainers = new Panel();
            lblTrainersHeader = new Label();
            lbxTrainers = new ListBox();
            btnEditTrainer = new Button();
            btnDeleteTrainer = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlClients.SuspendLayout();
            pnlTrainers.SuspendLayout();
            SuspendLayout();

            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(980, 520);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminUsersForm";
            Text = "Fitness App — Admin Panel";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminUsersForm_Load;

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabStop = false;

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 241, 251);
            lblTitle.Location = new Point(98, 20);
            lblTitle.Text = "FITNESS APP";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(55, 138, 221);
            lblSubtitle.Location = new Point(100, 52);
            lblSubtitle.Text = "Admin Panel — Manage Users";

            Color cardBg = Color.FromArgb(26, 39, 64);
            Color inputBg = Color.FromArgb(15, 27, 45);
            Color labelClr = Color.FromArgb(133, 183, 235);
            Color textClr = Color.FromArgb(230, 241, 251);
            Color accentClr = Color.FromArgb(55, 138, 221);

            pnlClients.BackColor = cardBg;
            pnlClients.BorderStyle = BorderStyle.FixedSingle;
            pnlClients.Location = new Point(36, 86);
            pnlClients.Name = "pnlClients";
            pnlClients.Size = new Size(430, 400);
            pnlClients.Controls.Add(lblClientsHeader);
            pnlClients.Controls.Add(lbxClients);
            pnlClients.Controls.Add(btnEditClient);
            pnlClients.Controls.Add(btnDeleteClient);

            lblClientsHeader.AutoSize = true;
            lblClientsHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblClientsHeader.ForeColor = labelClr;
            lblClientsHeader.Location = new Point(20, 18);
            lblClientsHeader.Text = "CLIENTS";

            lbxClients.BackColor = inputBg;
            lbxClients.BorderStyle = BorderStyle.FixedSingle;
            lbxClients.ForeColor = textClr;
            lbxClients.Font = new Font("Segoe UI", 10F);
            lbxClients.FormattingEnabled = true;
            lbxClients.Location = new Point(20, 38);
            lbxClients.Name = "lbxClients";
            lbxClients.Size = new Size(390, 270);
            lbxClients.TabIndex = 0;

            btnEditClient.BackColor = Color.FromArgb(24, 95, 165);
            btnEditClient.Cursor = Cursors.Hand;
            btnEditClient.FlatStyle = FlatStyle.Flat;
            btnEditClient.FlatAppearance.BorderSize = 0;
            btnEditClient.FlatAppearance.MouseOverBackColor = accentClr;
            btnEditClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditClient.ForeColor = textClr;
            btnEditClient.Location = new Point(20, 325);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(185, 40);
            btnEditClient.TabIndex = 1;
            btnEditClient.Text = "Edit / Update Client";
            btnEditClient.Click += btnEditClient_Click;

            btnDeleteClient.BackColor = cardBg;
            btnDeleteClient.Cursor = Cursors.Hand;
            btnDeleteClient.FlatStyle = FlatStyle.Flat;
            btnDeleteClient.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnDeleteClient.FlatAppearance.BorderSize = 1;
            btnDeleteClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 40, 40);
            btnDeleteClient.Font = new Font("Segoe UI", 10F);
            btnDeleteClient.ForeColor = Color.FromArgb(220, 100, 100);
            btnDeleteClient.Location = new Point(215, 325);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(185, 40);
            btnDeleteClient.TabIndex = 2;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.Click += btnDeleteClient_Click;

            pnlTrainers.BackColor = cardBg;
            pnlTrainers.BorderStyle = BorderStyle.FixedSingle;
            pnlTrainers.Location = new Point(514, 86);
            pnlTrainers.Name = "pnlTrainers";
            pnlTrainers.Size = new Size(430, 400);
            pnlTrainers.Controls.Add(lblTrainersHeader);
            pnlTrainers.Controls.Add(lbxTrainers);
            pnlTrainers.Controls.Add(btnEditTrainer);
            pnlTrainers.Controls.Add(btnDeleteTrainer);

            lblTrainersHeader.AutoSize = true;
            lblTrainersHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTrainersHeader.ForeColor = labelClr;
            lblTrainersHeader.Location = new Point(20, 18);
            lblTrainersHeader.Text = "TRAINERS";

            lbxTrainers.BackColor = inputBg;
            lbxTrainers.BorderStyle = BorderStyle.FixedSingle;
            lbxTrainers.ForeColor = textClr;
            lbxTrainers.Font = new Font("Segoe UI", 10F);
            lbxTrainers.FormattingEnabled = true;
            lbxTrainers.Location = new Point(20, 38);
            lbxTrainers.Name = "lbxTrainers";
            lbxTrainers.Size = new Size(390, 270);
            lbxTrainers.TabIndex = 3;

            btnEditTrainer.BackColor = Color.FromArgb(24, 95, 165);
            btnEditTrainer.Cursor = Cursors.Hand;
            btnEditTrainer.FlatStyle = FlatStyle.Flat;
            btnEditTrainer.FlatAppearance.BorderSize = 0;
            btnEditTrainer.FlatAppearance.MouseOverBackColor = accentClr;
            btnEditTrainer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditTrainer.ForeColor = textClr;
            btnEditTrainer.Location = new Point(20, 325);
            btnEditTrainer.Name = "btnEditTrainer";
            btnEditTrainer.Size = new Size(185, 40);
            btnEditTrainer.TabIndex = 4;
            btnEditTrainer.Text = "Edit / Update Trainer";
            btnEditTrainer.Click += btnEditTrainer_Click;

            btnDeleteTrainer.BackColor = cardBg;
            btnDeleteTrainer.Cursor = Cursors.Hand;
            btnDeleteTrainer.FlatStyle = FlatStyle.Flat;
            btnDeleteTrainer.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnDeleteTrainer.FlatAppearance.BorderSize = 1;
            btnDeleteTrainer.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 40, 40);
            btnDeleteTrainer.Font = new Font("Segoe UI", 10F);
            btnDeleteTrainer.ForeColor = Color.FromArgb(220, 100, 100);
            btnDeleteTrainer.Location = new Point(215, 325);
            btnDeleteTrainer.Name = "btnDeleteTrainer";
            btnDeleteTrainer.Size = new Size(185, 40);
            btnDeleteTrainer.TabIndex = 5;
            btnDeleteTrainer.Text = "Delete Trainer";
            btnDeleteTrainer.Click += btnDeleteTrainer_Click;

            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlClients);
            Controls.Add(pnlTrainers);

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlClients.ResumeLayout(false);
            pnlClients.PerformLayout();
            pnlTrainers.ResumeLayout(false);
            pnlTrainers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlClients;
        private Label lblClientsHeader;
        private ListBox lbxClients;
        private Button btnEditClient;
        private Button btnDeleteClient;
        private Panel pnlTrainers;
        private Label lblTrainersHeader;
        private ListBox lbxTrainers;
        private Button btnEditTrainer;
        private Button btnDeleteTrainer;
    }
}