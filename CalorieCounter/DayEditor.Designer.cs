namespace CalorieCounter
{
    partial class DayEditor
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
            BackBtn = new Button();
            LabelDayInfo = new Label();
            listBoxMeals = new ListBox();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(115, 495);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(198, 61);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // LabelDayInfo
            // 
            LabelDayInfo.AutoSize = true;
            LabelDayInfo.Location = new Point(140, 81);
            LabelDayInfo.Name = "LabelDayInfo";
            LabelDayInfo.Size = new Size(173, 25);
            LabelDayInfo.TabIndex = 5;
            LabelDayInfo.Text = "Thursday 12/5/2024";
            // 
            // listBoxMeals
            // 
            listBoxMeals.FormattingEnabled = true;
            listBoxMeals.ItemHeight = 25;
            listBoxMeals.Location = new Point(140, 152);
            listBoxMeals.Name = "listBoxMeals";
            listBoxMeals.Size = new Size(337, 254);
            listBoxMeals.TabIndex = 6;
            // 
            // DayEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 650);
            Controls.Add(listBoxMeals);
            Controls.Add(LabelDayInfo);
            Controls.Add(BackBtn);
            Name = "DayEditor";
            Text = "DayEditor";
            Load += DayEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackBtn;
        private Label LabelDayInfo;
        private ListBox listBoxMeals;
    }
}