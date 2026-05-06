namespace FitnessStudioApp.FORMS
{
    partial class AdminUsersForm
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
            lblHeader = new Label();
            lbxTrainers = new ListBox();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            lbxClients = new ListBox();
            btnEditTrainer = new Button();
            btnDeleteTrainer = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(371, 30);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(114, 15);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Admin panel - Users";
            // 
            // lbxTrainers
            // 
            lbxTrainers.FormattingEnabled = true;
            lbxTrainers.Location = new Point(534, 92);
            lbxTrainers.Name = "lbxTrainers";
            lbxTrainers.Size = new Size(407, 199);
            lbxTrainers.TabIndex = 2;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(40, 318);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(135, 35);
            btnEditClient.TabIndex = 3;
            btnEditClient.Text = "Edit or Update Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(40, 359);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(95, 35);
            btnDeleteClient.TabIndex = 4;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // lbxClients
            // 
            lbxClients.FormattingEnabled = true;
            lbxClients.Location = new Point(40, 92);
            lbxClients.Name = "lbxClients";
            lbxClients.Size = new Size(375, 199);
            lbxClients.TabIndex = 5;
            lbxClients.SelectedIndexChanged += lbxClients_SelectedIndexChanged;
            // 
            // btnEditTrainer
            // 
            btnEditTrainer.Location = new Point(534, 318);
            btnEditTrainer.Name = "btnEditTrainer";
            btnEditTrainer.Size = new Size(135, 35);
            btnEditTrainer.TabIndex = 6;
            btnEditTrainer.Text = "Edit or Update Trainer";
            btnEditTrainer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTrainer
            // 
            btnDeleteTrainer.Location = new Point(534, 359);
            btnDeleteTrainer.Name = "btnDeleteTrainer";
            btnDeleteTrainer.Size = new Size(95, 35);
            btnDeleteTrainer.TabIndex = 7;
            btnDeleteTrainer.Text = "Delete Trainer";
            btnDeleteTrainer.UseVisualStyleBackColor = true;
            // 
            // AdminUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 494);
            Controls.Add(btnDeleteTrainer);
            Controls.Add(btnEditTrainer);
            Controls.Add(lbxClients);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(lbxTrainers);
            Controls.Add(lblHeader);
            Name = "AdminUsersForm";
            Text = "AdminUsersForm";
            Load += AdminUsersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private ListBox lbxTrainers;
        private Button btnEditClient;
        private Button btnDeleteClient;
        private ListBox lbxClients;
        private Button btnEditTrainer;
        private Button btnDeleteTrainer;
    }
}