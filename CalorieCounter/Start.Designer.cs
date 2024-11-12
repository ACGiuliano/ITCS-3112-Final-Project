namespace CalorieCounter
{
    partial class CalorieCounter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Font = new Font("Segoe UI", 12F);
            btnStart.Location = new Point(232, 531);
            btnStart.MaximumSize = new Size(280, 55);
            btnStart.MinimumSize = new Size(100, 55);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(242, 55);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button1_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Exit.Font = new Font("Segoe UI", 12F);
            Exit.Location = new Point(581, 531);
            Exit.MaximumSize = new Size(280, 55);
            Exit.MinimumSize = new Size(100, 55);
            Exit.Name = "Exit";
            Exit.Size = new Size(242, 55);
            Exit.TabIndex = 1;
            Exit.Text = "Quit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button2_Click;
            // 
            // CalorieCounter
            // 
            AcceptButton = btnStart;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 844);
            Controls.Add(Exit);
            Controls.Add(btnStart);
            MaximumSize = new Size(1100, 900);
            MinimumSize = new Size(1100, 900);
            Name = "CalorieCounter";
            Text = "Calorie Counter";
            Load += CalorieCounter_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button Exit;
    }
}
