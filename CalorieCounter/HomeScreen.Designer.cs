namespace CalorieCounter
{
    partial class HomeScreen
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
            NewDayBtn = new Button();
            ViewDaysBtn = new Button();
            NewDayLabel = new Label();
            ViewDayLabel = new Label();
            SuspendLayout();
            // 
            // NewDayBtn
            // 
            NewDayBtn.Location = new Point(126, 156);
            NewDayBtn.Name = "NewDayBtn";
            NewDayBtn.Size = new Size(200, 62);
            NewDayBtn.TabIndex = 0;
            NewDayBtn.Text = "New Day";
            NewDayBtn.UseVisualStyleBackColor = true;
            NewDayBtn.Click += NewDayBtn_Click;
            // 
            // ViewDaysBtn
            // 
            ViewDaysBtn.Location = new Point(126, 348);
            ViewDaysBtn.Name = "ViewDaysBtn";
            ViewDaysBtn.Size = new Size(200, 62);
            ViewDaysBtn.TabIndex = 1;
            ViewDaysBtn.Text = "View Days";
            ViewDaysBtn.UseVisualStyleBackColor = true;
            ViewDaysBtn.Click += ViewDaysBtn_Click;
            // 
            // NewDayLabel
            // 
            NewDayLabel.AutoSize = true;
            NewDayLabel.Location = new Point(355, 175);
            NewDayLabel.Name = "NewDayLabel";
            NewDayLabel.Size = new Size(258, 25);
            NewDayLabel.TabIndex = 2;
            NewDayLabel.Text = "Add a new day to the calendar.";
            // 
            // ViewDayLabel
            // 
            ViewDayLabel.AutoSize = true;
            ViewDayLabel.Location = new Point(355, 367);
            ViewDayLabel.Name = "ViewDayLabel";
            ViewDayLabel.Size = new Size(238, 25);
            ViewDayLabel.TabIndex = 3;
            ViewDayLabel.Text = "View and edit previous days.";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 593);
            Controls.Add(ViewDayLabel);
            Controls.Add(NewDayLabel);
            Controls.Add(ViewDaysBtn);
            Controls.Add(NewDayBtn);
            Name = "HomeScreen";
            Text = "HomeScreen";
            Load += HomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewDayBtn;
        private Button ViewDaysBtn;
        private Label NewDayLabel;
        private Label ViewDayLabel;
    }
}