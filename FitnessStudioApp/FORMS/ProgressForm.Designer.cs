namespace FitnessStudioApp.FORMS
{
    partial class ProgressForm
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
            lblName = new Label();
            lblTargetedProgress = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(42, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblTargetedProgress
            // 
            lblTargetedProgress.AutoSize = true;
            lblTargetedProgress.Location = new Point(42, 131);
            lblTargetedProgress.Name = "lblTargetedProgress";
            lblTargetedProgress.Size = new Size(180, 20);
            lblTargetedProgress.TabIndex = 1;
            lblTargetedProgress.Text = "Type of targeted progress";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 77);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(lblTargetedProgress);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProgressForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTargetedProgress;
        private TextBox textBox1;
    }
}