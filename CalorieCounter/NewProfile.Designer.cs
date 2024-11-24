namespace CalorieCounter
{
    partial class NewProfile
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
            Label Heading;
            userNameLabel = new Label();
            UsernameBox = new TextBox();
            userHeightLabel = new Label();
            HeightBox = new TextBox();
            CurrWeight = new Label();
            CurrWeightBox = new TextBox();
            GoalWeight = new Label();
            GoalWeightBox = new TextBox();
            BackButton = new Button();
            CreateButton = new Button();
            Heading = new Label();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading.Location = new Point(57, 70);
            Heading.Name = "Heading";
            Heading.Size = new Size(476, 32);
            Heading.TabIndex = 10;
            Heading.Text = "Enter information to create your profile.";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(105, 188);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(103, 25);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(226, 188);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(217, 31);
            UsernameBox.TabIndex = 1;
            // 
            // userHeightLabel
            // 
            userHeightLabel.AutoSize = true;
            userHeightLabel.Location = new Point(75, 271);
            userHeightLabel.Name = "userHeightLabel";
            userHeightLabel.Size = new Size(133, 25);
            userHeightLabel.TabIndex = 2;
            userHeightLabel.Text = "Height (inches):";
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(226, 271);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(217, 31);
            HeightBox.TabIndex = 3;
            // 
            // CurrWeight
            // 
            CurrWeight.AutoSize = true;
            CurrWeight.Location = new Point(35, 355);
            CurrWeight.Name = "CurrWeight";
            CurrWeight.Size = new Size(173, 25);
            CurrWeight.TabIndex = 4;
            CurrWeight.Text = "Current Weight (lbs):";
            // 
            // CurrWeightBox
            // 
            CurrWeightBox.Location = new Point(226, 355);
            CurrWeightBox.Name = "CurrWeightBox";
            CurrWeightBox.Size = new Size(217, 31);
            CurrWeightBox.TabIndex = 5;
            // 
            // GoalWeight
            // 
            GoalWeight.AutoSize = true;
            GoalWeight.Location = new Point(57, 443);
            GoalWeight.Name = "GoalWeight";
            GoalWeight.Size = new Size(151, 25);
            GoalWeight.TabIndex = 6;
            GoalWeight.Text = "Goal Weight (lbs):";
            // 
            // GoalWeightBox
            // 
            GoalWeightBox.Location = new Point(226, 443);
            GoalWeightBox.Name = "GoalWeightBox";
            GoalWeightBox.Size = new Size(217, 31);
            GoalWeightBox.TabIndex = 7;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(66, 620);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(199, 50);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(310, 620);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(199, 50);
            CreateButton.TabIndex = 9;
            CreateButton.Text = "Create Profile";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // NewProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(584, 694);
            Controls.Add(Heading);
            Controls.Add(CreateButton);
            Controls.Add(BackButton);
            Controls.Add(GoalWeightBox);
            Controls.Add(GoalWeight);
            Controls.Add(CurrWeightBox);
            Controls.Add(CurrWeight);
            Controls.Add(HeightBox);
            Controls.Add(userHeightLabel);
            Controls.Add(UsernameBox);
            Controls.Add(userNameLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(606, 750);
            MinimumSize = new Size(606, 750);
            Name = "NewProfile";
            Text = "NewProfile";
            Load += NewProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private TextBox UsernameBox;
        private Label userHeightLabel;
        private TextBox HeightBox;
        private Label CurrWeight;
        private TextBox CurrWeightBox;
        private Label GoalWeight;
        private TextBox GoalWeightBox;
        private Button BackButton;
        private Button CreateButton;
    }
}