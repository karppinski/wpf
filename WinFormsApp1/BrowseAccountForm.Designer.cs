namespace WinFormsApp1
{
    partial class BrowseAccountForm
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
            CharacterNameLabel = new Label();
            CityLabel = new Label();
            VocationLabel = new Label();
            SexLabel = new Label();
            LevelLabel = new Label();
            CreatedLabel = new Label();
            button1 = new Button();
            BtnNext = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            DeletBtn = new Button();
            SuspendLayout();
            // 
            // CharacterNameLabel
            // 
            CharacterNameLabel.AutoSize = true;
            CharacterNameLabel.Location = new Point(489, 76);
            CharacterNameLabel.Name = "CharacterNameLabel";
            CharacterNameLabel.Size = new Size(90, 15);
            CharacterNameLabel.TabIndex = 0;
            CharacterNameLabel.Text = "CharacterName";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(489, 133);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 15);
            CityLabel.TabIndex = 1;
            CityLabel.Text = "City: ";
            // 
            // VocationLabel
            // 
            VocationLabel.AutoSize = true;
            VocationLabel.Location = new Point(489, 198);
            VocationLabel.Name = "VocationLabel";
            VocationLabel.Size = new Size(53, 15);
            VocationLabel.TabIndex = 2;
            VocationLabel.Text = "Vocation";
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(489, 251);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(25, 15);
            SexLabel.TabIndex = 3;
            SexLabel.Text = "Sex";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(489, 304);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 4;
            LevelLabel.Text = "Level";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(489, 354);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(48, 15);
            CreatedLabel.TabIndex = 5;
            CreatedLabel.Text = "Created";
            // 
            // button1
            // 
            button1.Location = new Point(48, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(646, 189);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(75, 23);
            BtnNext.TabIndex = 13;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 76);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 6;
            label7.Text = "CharacterName";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 133);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 7;
            label8.Text = "City";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 198);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 8;
            label9.Text = "Vocation";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(202, 251);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 9;
            label10.Text = "Sex";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(202, 304);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 10;
            label11.Text = "Level";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(196, 354);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 11;
            label12.Text = "Created";
            label12.Click += label12_Click;
            // 
            // DeletBtn
            // 
            DeletBtn.Location = new Point(667, 329);
            DeletBtn.Name = "DeletBtn";
            DeletBtn.Size = new Size(75, 23);
            DeletBtn.TabIndex = 14;
            DeletBtn.Text = "Delete";
            DeletBtn.UseVisualStyleBackColor = true;
            DeletBtn.Click += DeletBtn_Click;
            // 
            // BrowseAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeletBtn);
            Controls.Add(BtnNext);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CreatedLabel);
            Controls.Add(LevelLabel);
            Controls.Add(SexLabel);
            Controls.Add(VocationLabel);
            Controls.Add(CityLabel);
            Controls.Add(CharacterNameLabel);
            Name = "BrowseAccountForm";
            RightToLeftLayout = true;
            Text = "BrowseAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CharacterNameLabel;
        private Label CityLabel;
        private Label VocationLabel;
        private Label SexLabel;
        private Label LevelLabel;
        private Label CreatedLabel;
        private Button button1;
        private Button BtnNext;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button DeletBtn;
    }
}