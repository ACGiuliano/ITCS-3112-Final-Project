namespace CalorieCounter
{
    partial class LoadProfile
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
            ProfileDropdown = new ComboBox();
            LoadBtn = new Button();
            BackBtn = new Button();
            Description = new Label();
            SuspendLayout();
            // 
            // ProfileDropdown
            // 
            ProfileDropdown.FormattingEnabled = true;
            ProfileDropdown.Location = new Point(165, 141);
            ProfileDropdown.Name = "ProfileDropdown";
            ProfileDropdown.Size = new Size(305, 33);
            ProfileDropdown.TabIndex = 0;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(360, 647);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(225, 64);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "Load Profile";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(60, 647);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(225, 64);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description.Location = new Point(60, 55);
            Description.Name = "Description";
            Description.Size = new Size(525, 32);
            Description.TabIndex = 3;
            Description.Text = "Use the dropdown to select a profile to load.";
            // 
            // LoadProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 736);
            Controls.Add(Description);
            Controls.Add(BackBtn);
            Controls.Add(LoadBtn);
            Controls.Add(ProfileDropdown);
            Name = "LoadProfile";
            Text = "LoadProfile";
            Load += LoadProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ProfileDropdown;
        private Button LoadBtn;
        private Button BackBtn;
        private Label Description;
    }
}