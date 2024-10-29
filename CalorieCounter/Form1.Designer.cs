﻿namespace CalorieCounter
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
            Enter = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Enter.Font = new Font("Segoe UI", 12F);
            Enter.Location = new Point(165, 531);
            Enter.Name = "Enter";
            Enter.Size = new Size(249, 55);
            Enter.TabIndex = 0;
            Enter.Text = "Start";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += button1_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Exit.Font = new Font("Segoe UI", 12F);
            Exit.Location = new Point(604, 531);
            Exit.Name = "Exit";
            Exit.Size = new Size(249, 55);
            Exit.TabIndex = 1;
            Exit.Text = "Quit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button2_Click;
            // 
            // CalorieCounter
            // 
            AcceptButton = Enter;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 903);
            Controls.Add(Exit);
            Controls.Add(Enter);
            Name = "CalorieCounter";
            Text = "Calorie Counter";
            ResumeLayout(false);
        }

        #endregion

        private Button Enter;
        private Button Exit;
    }
}