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
            label1 = new Label();
            ContinueBtn = new Button();
            BackBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 66);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Select a day below";
            // 
            // ContinueBtn
            // 
            ContinueBtn.Location = new Point(374, 489);
            ContinueBtn.Name = "ContinueBtn";
            ContinueBtn.Size = new Size(203, 63);
            ContinueBtn.TabIndex = 2;
            ContinueBtn.Text = "Continue";
            ContinueBtn.UseVisualStyleBackColor = true;
            ContinueBtn.Click += ContinueBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(74, 489);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(203, 63);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(325, 31);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 593);
            Controls.Add(dateTimePicker1);
            Controls.Add(BackBtn);
            Controls.Add(ContinueBtn);
            Controls.Add(label1);
            Name = "HomeScreen";
            Text = "HomeScreen";
            Load += HomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ContinueBtn;
        private Button BackBtn;
        private DateTimePicker dateTimePicker1;
    }
}