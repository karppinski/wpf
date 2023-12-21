namespace WinFormsApp1
{
    partial class UpdateAccountForm
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
            btnSubmit = new Button();
            CharacterNameLabel = new Label();
            CityLabel = new Label();
            VocationLabel = new Label();
            SexLabel = new Label();
            LevelLabel = new Label();
            CreatedLabel = new Label();
            txtCharacterName = new TextBox();
            txtCity = new TextBox();
            txtVocation = new TextBox();
            txtSex = new TextBox();
            txtLevel = new TextBox();
            txtCreated = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(559, 337);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CharacterNameLabel
            // 
            CharacterNameLabel.AutoSize = true;
            CharacterNameLabel.Location = new Point(87, 58);
            CharacterNameLabel.Name = "CharacterNameLabel";
            CharacterNameLabel.Size = new Size(93, 15);
            CharacterNameLabel.TabIndex = 1;
            CharacterNameLabel.Text = "Character Name";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(87, 98);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "City";
            // 
            // VocationLabel
            // 
            VocationLabel.AutoSize = true;
            VocationLabel.Location = new Point(87, 132);
            VocationLabel.Name = "VocationLabel";
            VocationLabel.Size = new Size(53, 15);
            VocationLabel.TabIndex = 3;
            VocationLabel.Text = "Vocation";
            VocationLabel.Click += label3_Click;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(87, 163);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(25, 15);
            SexLabel.TabIndex = 4;
            SexLabel.Text = "Sex";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(87, 202);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 5;
            LevelLabel.Text = "Level";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(87, 244);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(48, 15);
            CreatedLabel.TabIndex = 6;
            CreatedLabel.Text = "Created";
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(299, 58);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(100, 23);
            txtCharacterName.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(299, 98);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 8;
            // 
            // txtVocation
            // 
            txtVocation.Location = new Point(299, 132);
            txtVocation.Name = "txtVocation";
            txtVocation.Size = new Size(100, 23);
            txtVocation.TabIndex = 9;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(299, 163);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(100, 23);
            txtSex.TabIndex = 10;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(299, 202);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(100, 23);
            txtLevel.TabIndex = 11;
            // 
            // txtCreated
            // 
            txtCreated.Location = new Point(299, 244);
            txtCreated.Name = "txtCreated";
            txtCreated.Size = new Size(100, 23);
            txtCreated.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(299, 313);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtCreated);
            Controls.Add(txtLevel);
            Controls.Add(txtSex);
            Controls.Add(txtVocation);
            Controls.Add(txtCity);
            Controls.Add(txtCharacterName);
            Controls.Add(CreatedLabel);
            Controls.Add(LevelLabel);
            Controls.Add(SexLabel);
            Controls.Add(VocationLabel);
            Controls.Add(CityLabel);
            Controls.Add(CharacterNameLabel);
            Controls.Add(btnSubmit);
            Name = "UpdateAccountForm";
            Text = "UpdateAccountForm";
            Load += UpdateAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label CharacterNameLabel;
        private Label CityLabel;
        private Label VocationLabel;
        private Label SexLabel;
        private Label LevelLabel;
        private Label CreatedLabel;
        private TextBox txtCharacterName;
        private TextBox txtCity;
        private TextBox txtVocation;
        private TextBox txtSex;
        private TextBox txtLevel;
        private TextBox txtCreated;
        private Button button1;
    }
}