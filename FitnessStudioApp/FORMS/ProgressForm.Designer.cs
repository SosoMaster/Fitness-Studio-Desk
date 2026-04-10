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
            lblName.Location = new Point(37, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblTargetedProgress
            // 
            lblTargetedProgress.AutoSize = true;
            lblTargetedProgress.Location = new Point(37, 98);
            lblTargetedProgress.Name = "lblTargetedProgress";
            lblTargetedProgress.Size = new Size(140, 15);
            lblTargetedProgress.TabIndex = 1;
            lblTargetedProgress.Text = "Type of targeted progress";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblTargetedProgress);
            Controls.Add(lblName);
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