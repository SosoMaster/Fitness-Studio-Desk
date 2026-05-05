namespace FitnessStudioApp.FORMS
{
    partial class BookingForm
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
            btn_Create = new Button();
            btn_Cancel = new Button();
            cmb_TrainingType = new ComboBox();
            cmb_Trainer = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(200, 327);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(75, 23);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "button1";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(200, 367);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "button1";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // cmb_TrainingType
            // 
            cmb_TrainingType.FormattingEnabled = true;
            cmb_TrainingType.Location = new Point(184, 37);
            cmb_TrainingType.Name = "cmb_TrainingType";
            cmb_TrainingType.Size = new Size(121, 23);
            cmb_TrainingType.TabIndex = 2;
            cmb_TrainingType.SelectedIndexChanged += cmb_TrainingType_SelectedIndexChanged;
            // 
            // cmb_Trainer
            // 
            cmb_Trainer.FormattingEnabled = true;
            cmb_Trainer.Location = new Point(184, 86);
            cmb_Trainer.Name = "cmb_Trainer";
            cmb_Trainer.Size = new Size(121, 23);
            cmb_Trainer.TabIndex = 3;
            cmb_Trainer.SelectedIndexChanged += cmb_Trainer_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(127, 122);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(cmb_Trainer);
            Controls.Add(cmb_TrainingType);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Create);
            Name = "BookingForm";
            Text = "BookingForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Create;
        private Button btn_Cancel;
        private ComboBox cmb_TrainingType;
        private ComboBox cmb_Trainer;
        private MonthCalendar monthCalendar1;
    }
}