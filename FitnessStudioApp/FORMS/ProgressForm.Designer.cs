namespace FitnessStudioApp.FORMS
{
    partial class ProgressForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureLogo = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlInputCard = new Panel();
            lblCurrentWeight = new Label();
            txtCurrentWeight = new TextBox();
            lblCurrentHeight = new Label();
            txtCurrentHeight = new TextBox();
            pnlDivider = new Panel();
            lblGoalHeader = new Label();
            btnLoseFat = new Button();
            btnGainMuscle = new Button();
            btnSaveProgress = new Button();
            btnBack = new Button();
            pnlResultCard = new Panel();
            lblResultHeader = new Label();
            lblBMI = new Label();
            lblBodyFat = new Label();
            lblRecommendation = new Label();
            txtResult = new RichTextBox();
            pnlHistoryCard = new Panel();
            lblHistoryHeader = new Label();
            dgvHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            pnlInputCard.SuspendLayout();
            pnlResultCard.SuspendLayout();
            pnlHistoryCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.logo;
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
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(55, 138, 221);
            lblSubtitle.Location = new Point(80, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(106, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Progress Tracker";
            // 
            // pnlInputCard
            // 
            pnlInputCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlInputCard.BorderStyle = BorderStyle.FixedSingle;
            pnlInputCard.Controls.Add(lblCurrentWeight);
            pnlInputCard.Controls.Add(txtCurrentWeight);
            pnlInputCard.Controls.Add(lblCurrentHeight);
            pnlInputCard.Controls.Add(txtCurrentHeight);
            pnlInputCard.Controls.Add(pnlDivider);
            pnlInputCard.Controls.Add(lblGoalHeader);
            pnlInputCard.Controls.Add(btnLoseFat);
            pnlInputCard.Controls.Add(btnGainMuscle);
            pnlInputCard.Controls.Add(btnSaveProgress);
            pnlInputCard.Controls.Add(btnBack);
            pnlInputCard.Location = new Point(16, 76);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Size = new Size(280, 510);
            pnlInputCard.TabIndex = 3;
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCurrentWeight.ForeColor = Color.FromArgb(133, 183, 235);
            lblCurrentWeight.Location = new Point(20, 20);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(136, 15);
            lblCurrentWeight.TabIndex = 0;
            lblCurrentWeight.Text = "CURRENT WEIGHT (kg)";
            // 
            // txtCurrentWeight
            // 
            txtCurrentWeight.BackColor = Color.FromArgb(15, 27, 45);
            txtCurrentWeight.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentWeight.Font = new Font("Segoe UI", 11F);
            txtCurrentWeight.ForeColor = Color.FromArgb(230, 241, 251);
            txtCurrentWeight.Location = new Point(20, 38);
            txtCurrentWeight.Name = "txtCurrentWeight";
            txtCurrentWeight.Size = new Size(238, 27);
            txtCurrentWeight.TabIndex = 0;
            // 
            // lblCurrentHeight
            // 
            lblCurrentHeight.AutoSize = true;
            lblCurrentHeight.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCurrentHeight.ForeColor = Color.FromArgb(133, 183, 235);
            lblCurrentHeight.Location = new Point(20, 82);
            lblCurrentHeight.Name = "lblCurrentHeight";
            lblCurrentHeight.Size = new Size(136, 15);
            lblCurrentHeight.TabIndex = 1;
            lblCurrentHeight.Text = "CURRENT HEIGHT (cm)";
            // 
            // txtCurrentHeight
            // 
            txtCurrentHeight.BackColor = Color.FromArgb(15, 27, 45);
            txtCurrentHeight.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentHeight.Font = new Font("Segoe UI", 11F);
            txtCurrentHeight.ForeColor = Color.FromArgb(230, 241, 251);
            txtCurrentHeight.Location = new Point(20, 100);
            txtCurrentHeight.Name = "txtCurrentHeight";
            txtCurrentHeight.Size = new Size(238, 27);
            txtCurrentHeight.TabIndex = 1;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(35, 55, 90);
            pnlDivider.Location = new Point(20, 146);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(238, 1);
            pnlDivider.TabIndex = 2;
            // 
            // lblGoalHeader
            // 
            lblGoalHeader.AutoSize = true;
            lblGoalHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblGoalHeader.ForeColor = Color.FromArgb(133, 183, 235);
            lblGoalHeader.Location = new Point(20, 158);
            lblGoalHeader.Name = "lblGoalHeader";
            lblGoalHeader.Size = new Size(81, 15);
            lblGoalHeader.TabIndex = 3;
            lblGoalHeader.Text = "SELECT GOAL";
            // 
            // btnLoseFat
            // 
            btnLoseFat.BackColor = Color.FromArgb(24, 95, 165);
            btnLoseFat.Cursor = Cursors.Hand;
            btnLoseFat.FlatAppearance.BorderSize = 0;
            btnLoseFat.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnLoseFat.FlatStyle = FlatStyle.Flat;
            btnLoseFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoseFat.ForeColor = Color.FromArgb(230, 241, 251);
            btnLoseFat.Location = new Point(20, 178);
            btnLoseFat.Name = "btnLoseFat";
            btnLoseFat.Size = new Size(238, 42);
            btnLoseFat.TabIndex = 2;
            btnLoseFat.Text = "🔥 Lose Fat";
            btnLoseFat.UseVisualStyleBackColor = false;
            btnLoseFat.Click += btnLoseFat_Click;
            // 
            // btnGainMuscle
            // 
            btnGainMuscle.BackColor = Color.FromArgb(24, 95, 165);
            btnGainMuscle.Cursor = Cursors.Hand;
            btnGainMuscle.FlatAppearance.BorderSize = 0;
            btnGainMuscle.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 138, 221);
            btnGainMuscle.FlatStyle = FlatStyle.Flat;
            btnGainMuscle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGainMuscle.ForeColor = Color.FromArgb(230, 241, 251);
            btnGainMuscle.Location = new Point(20, 230);
            btnGainMuscle.Name = "btnGainMuscle";
            btnGainMuscle.Size = new Size(238, 42);
            btnGainMuscle.TabIndex = 3;
            btnGainMuscle.Text = "💪 Gain Muscle";
            btnGainMuscle.UseVisualStyleBackColor = false;
            btnGainMuscle.Click += btnGainMuscle_Click;
            // 
            // btnSaveProgress
            // 
            btnSaveProgress.BackColor = Color.FromArgb(20, 110, 70);
            btnSaveProgress.Cursor = Cursors.Hand;
            btnSaveProgress.FlatAppearance.BorderSize = 0;
            btnSaveProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 150, 100);
            btnSaveProgress.FlatStyle = FlatStyle.Flat;
            btnSaveProgress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveProgress.ForeColor = Color.FromArgb(230, 241, 251);
            btnSaveProgress.Location = new Point(20, 300);
            btnSaveProgress.Name = "btnSaveProgress";
            btnSaveProgress.Size = new Size(238, 42);
            btnSaveProgress.TabIndex = 4;
            btnSaveProgress.Text = "💾 Save Progress Entry";
            btnSaveProgress.UseVisualStyleBackColor = false;
            btnSaveProgress.Click += btnSaveProgress_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 39, 64);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(55, 138, 221);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 33, 55);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.FromArgb(133, 183, 235);
            btnBack.Location = new Point(20, 458);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(238, 38);
            btnBack.TabIndex = 5;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlResultCard
            // 
            pnlResultCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlResultCard.BorderStyle = BorderStyle.FixedSingle;
            pnlResultCard.Controls.Add(lblResultHeader);
            pnlResultCard.Controls.Add(lblBMI);
            pnlResultCard.Controls.Add(lblBodyFat);
            pnlResultCard.Controls.Add(lblRecommendation);
            pnlResultCard.Controls.Add(txtResult);
            pnlResultCard.Location = new Point(310, 76);
            pnlResultCard.Name = "pnlResultCard";
            pnlResultCard.Size = new Size(420, 510);
            pnlResultCard.TabIndex = 4;
            // 
            // lblResultHeader
            // 
            lblResultHeader.AutoSize = true;
            lblResultHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblResultHeader.ForeColor = Color.FromArgb(133, 183, 235);
            lblResultHeader.Location = new Point(16, 16);
            lblResultHeader.Name = "lblResultHeader";
            lblResultHeader.Size = new Size(114, 15);
            lblResultHeader.TabIndex = 0;
            lblResultHeader.Text = "ANALYSIS RESULTS";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBMI.ForeColor = Color.FromArgb(230, 241, 251);
            lblBMI.Location = new Point(16, 40);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(57, 19);
            lblBMI.TabIndex = 1;
            lblBMI.Text = "BMI: —";
            // 
            // lblBodyFat
            // 
            lblBodyFat.AutoSize = true;
            lblBodyFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBodyFat.ForeColor = Color.FromArgb(230, 241, 251);
            lblBodyFat.Location = new Point(16, 64);
            lblBodyFat.Name = "lblBodyFat";
            lblBodyFat.Size = new Size(90, 19);
            lblBodyFat.TabIndex = 2;
            lblBodyFat.Text = "Body Fat: —";
            // 
            // lblRecommendation
            // 
            lblRecommendation.AutoSize = true;
            lblRecommendation.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecommendation.ForeColor = Color.FromArgb(133, 183, 235);
            lblRecommendation.Location = new Point(16, 96);
            lblRecommendation.Name = "lblRecommendation";
            lblRecommendation.Size = new Size(119, 15);
            lblRecommendation.TabIndex = 3;
            lblRecommendation.Text = "RECOMMENDATION";
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(15, 27, 45);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Segoe UI", 10F);
            txtResult.ForeColor = Color.FromArgb(230, 241, 251);
            txtResult.Location = new Point(16, 116);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtResult.Size = new Size(388, 376);
            txtResult.TabIndex = 4;
            txtResult.TabStop = false;
            txtResult.Text = "";
            // 
            // pnlHistoryCard
            // 
            pnlHistoryCard.BackColor = Color.FromArgb(26, 39, 64);
            pnlHistoryCard.BorderStyle = BorderStyle.FixedSingle;
            pnlHistoryCard.Controls.Add(lblHistoryHeader);
            pnlHistoryCard.Controls.Add(dgvHistory);
            pnlHistoryCard.Location = new Point(744, 76);
            pnlHistoryCard.Name = "pnlHistoryCard";
            pnlHistoryCard.Size = new Size(300, 510);
            pnlHistoryCard.TabIndex = 5;
            // 
            // lblHistoryHeader
            // 
            lblHistoryHeader.AutoSize = true;
            lblHistoryHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHistoryHeader.ForeColor = Color.FromArgb(133, 183, 235);
            lblHistoryHeader.Location = new Point(12, 16);
            lblHistoryHeader.Name = "lblHistoryHeader";
            lblHistoryHeader.Size = new Size(162, 15);
            lblHistoryHeader.TabIndex = 0;
            lblHistoryHeader.Text = "SAVED PROGRESS HISTORY";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.FromArgb(15, 27, 45);
            dgvHistory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 35, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(133, 183, 235);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 27, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 241, 251);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 95, 165);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(230, 241, 251);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.FromArgb(35, 55, 90);
            dgvHistory.Location = new Point(12, 38);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(276, 458);
            dgvHistory.TabIndex = 1;
            dgvHistory.TabStop = false;
            // 
            // ProgressForm
            // 
            BackColor = Color.FromArgb(15, 27, 45);
            ClientSize = new Size(1060, 620);
            Controls.Add(pictureLogo);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlResultCard);
            Controls.Add(pnlHistoryCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProgressForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness App — Progress Tracker";
            Load += ProgressForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlResultCard.ResumeLayout(false);
            pnlResultCard.PerformLayout();
            pnlHistoryCard.ResumeLayout(false);
            pnlHistoryCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlInputCard;
        private Label lblCurrentWeight;
        private TextBox txtCurrentWeight;
        private Label lblCurrentHeight;
        private TextBox txtCurrentHeight;
        private Panel pnlDivider;
        private Label lblGoalHeader;
        private Button btnLoseFat;
        private Button btnGainMuscle;
        private Button btnSaveProgress;
        private Button btnBack;
        private Panel pnlResultCard;
        private Label lblResultHeader;
        private Label lblBMI;
        private Label lblBodyFat;
        private Label lblRecommendation;
        private RichTextBox txtResult;
        private Panel pnlHistoryCard;
        private Label lblHistoryHeader;
        private DataGridView dgvHistory;
    }
}