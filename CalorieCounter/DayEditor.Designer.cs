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
            RemoveMealBtn = new Button();
            AddMealBtn = new Button();
            listBoxFood = new ListBox();
            comboBoxMealType = new ComboBox();
            labelCalsConsumed = new Label();
            LabelOverLimit = new Label();
            AddFoodBtn = new Button();
            RemoveFoodBtn = new Button();
            textBoxFood = new TextBox();
            textBoxCalories = new TextBox();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(140, 601);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(198, 61);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // LabelDayInfo
            // 
            LabelDayInfo.AutoSize = true;
            LabelDayInfo.Location = new Point(140, 83);
            LabelDayInfo.Name = "LabelDayInfo";
            LabelDayInfo.Size = new Size(173, 25);
            LabelDayInfo.TabIndex = 5;
            LabelDayInfo.Text = "Thursday 12/5/2024";
            // 
            // listBoxMeals
            // 
            listBoxMeals.FormattingEnabled = true;
            listBoxMeals.ItemHeight = 25;
            listBoxMeals.Location = new Point(140, 193);
            listBoxMeals.Name = "listBoxMeals";
            listBoxMeals.Size = new Size(337, 254);
            listBoxMeals.TabIndex = 6;
            listBoxMeals.SelectedIndexChanged += listBoxMeals_SelectedIndexChanged;
            // 
            // RemoveMealBtn
            // 
            RemoveMealBtn.Location = new Point(483, 233);
            RemoveMealBtn.Name = "RemoveMealBtn";
            RemoveMealBtn.Size = new Size(112, 34);
            RemoveMealBtn.TabIndex = 7;
            RemoveMealBtn.Text = "Remove";
            RemoveMealBtn.UseVisualStyleBackColor = true;
            RemoveMealBtn.Click += RemoveMealBtn_Click;
            // 
            // AddMealBtn
            // 
            AddMealBtn.Location = new Point(483, 193);
            AddMealBtn.Name = "AddMealBtn";
            AddMealBtn.Size = new Size(112, 34);
            AddMealBtn.TabIndex = 8;
            AddMealBtn.Text = "Add";
            AddMealBtn.UseVisualStyleBackColor = true;
            AddMealBtn.Click += AddMealBtn_Click;
            // 
            // listBoxFood
            // 
            listBoxFood.FormattingEnabled = true;
            listBoxFood.ItemHeight = 25;
            listBoxFood.Location = new Point(645, 193);
            listBoxFood.Name = "listBoxFood";
            listBoxFood.Size = new Size(337, 254);
            listBoxFood.TabIndex = 9;
            // 
            // comboBoxMealType
            // 
            comboBoxMealType.FormattingEnabled = true;
            comboBoxMealType.Location = new Point(140, 453);
            comboBoxMealType.Name = "comboBoxMealType";
            comboBoxMealType.Size = new Size(223, 33);
            comboBoxMealType.TabIndex = 10;
            // 
            // labelCalsConsumed
            // 
            labelCalsConsumed.AutoSize = true;
            labelCalsConsumed.Location = new Point(140, 154);
            labelCalsConsumed.Name = "labelCalsConsumed";
            labelCalsConsumed.Size = new Size(107, 25);
            labelCalsConsumed.TabIndex = 11;
            labelCalsConsumed.Text = "Consumed: ";
            // 
            // LabelOverLimit
            // 
            LabelOverLimit.AutoSize = true;
            LabelOverLimit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelOverLimit.ForeColor = Color.Red;
            LabelOverLimit.Location = new Point(411, 9);
            LabelOverLimit.Name = "LabelOverLimit";
            LabelOverLimit.Size = new Size(294, 38);
            LabelOverLimit.TabIndex = 12;
            LabelOverLimit.Text = "OVER CALORIE LIMIT";
            LabelOverLimit.Visible = false;
            // 
            // AddFoodBtn
            // 
            AddFoodBtn.Location = new Point(988, 193);
            AddFoodBtn.Name = "AddFoodBtn";
            AddFoodBtn.Size = new Size(112, 34);
            AddFoodBtn.TabIndex = 13;
            AddFoodBtn.Text = "Add";
            AddFoodBtn.UseVisualStyleBackColor = true;
            AddFoodBtn.Click += AddFoodBtn_Click;
            // 
            // RemoveFoodBtn
            // 
            RemoveFoodBtn.Location = new Point(988, 233);
            RemoveFoodBtn.Name = "RemoveFoodBtn";
            RemoveFoodBtn.Size = new Size(112, 34);
            RemoveFoodBtn.TabIndex = 14;
            RemoveFoodBtn.Text = "Remove";
            RemoveFoodBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxFood
            // 
            textBoxFood.Location = new Point(645, 455);
            textBoxFood.Name = "textBoxFood";
            textBoxFood.PlaceholderText = "Food";
            textBoxFood.Size = new Size(204, 31);
            textBoxFood.TabIndex = 15;
            // 
            // textBoxCalories
            // 
            textBoxCalories.Location = new Point(645, 492);
            textBoxCalories.Name = "textBoxCalories";
            textBoxCalories.PlaceholderText = "Calories";
            textBoxCalories.Size = new Size(150, 31);
            textBoxCalories.TabIndex = 16;
            textBoxCalories.KeyPress += textBoxCalories_KeyPress;
            // 
            // DayEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 742);
            Controls.Add(textBoxCalories);
            Controls.Add(textBoxFood);
            Controls.Add(RemoveFoodBtn);
            Controls.Add(AddFoodBtn);
            Controls.Add(LabelOverLimit);
            Controls.Add(labelCalsConsumed);
            Controls.Add(comboBoxMealType);
            Controls.Add(listBoxFood);
            Controls.Add(AddMealBtn);
            Controls.Add(RemoveMealBtn);
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
        private Button RemoveMealBtn;
        private Button AddMealBtn;
        private ListBox listBoxFood;
        private ComboBox comboBoxMealType;
        private Label labelCalsConsumed;
        private Label LabelOverLimit;
        private Button AddFoodBtn;
        private Button RemoveFoodBtn;
        private TextBox textBoxFood;
        private TextBox textBoxCalories;
    }
}