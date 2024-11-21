namespace CalorieCounter
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 225);
            button1.Name = "button1";
            button1.Size = new Size(208, 54);
            button1.TabIndex = 0;
            button1.Text = "New Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 397);
            button2.Name = "button2";
            button2.Size = new Size(208, 54);
            button2.TabIndex = 1;
            button2.Text = "Load Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 240);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 2;
            label1.Text = "Create a new profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 412);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 3;
            label2.Text = "Load an existing profile";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 656);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(760, 712);
            MinimumSize = new Size(760, 712);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}