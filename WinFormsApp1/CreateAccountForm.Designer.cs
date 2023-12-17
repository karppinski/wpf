namespace WinFormsApp1
{
    partial class CreateAccountForm
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
            txtCharacterName = new TextBox();
            txtCity = new TextBox();
            txtVocation = new TextBox();
            txtSex = new TextBox();
            txtLevel = new TextBox();
            txtCreated = new TextBox();
            CharacterNameLabel = new Label();
            CityLaber = new Label();
            VocationLabel = new Label();
            SexLabel = new Label();
            LevelLabel = new Label();
            CreatedLabel = new Label();
            BtnCreateCharacter = new Button();
            SuspendLayout();
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(177, 17);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(111, 23);
            txtCharacterName.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(177, 58);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(111, 23);
            txtCity.TabIndex = 1;
            // 
            // txtVocation
            // 
            txtVocation.Location = new Point(177, 106);
            txtVocation.Name = "txtVocation";
            txtVocation.Size = new Size(111, 23);
            txtVocation.TabIndex = 2;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(177, 168);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(111, 23);
            txtSex.TabIndex = 3;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(177, 227);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(111, 23);
            txtLevel.TabIndex = 4;
            // 
            // txtCreated
            // 
            txtCreated.Location = new Point(177, 278);
            txtCreated.Name = "txtCreated";
            txtCreated.Size = new Size(111, 23);
            txtCreated.TabIndex = 5;
            // 
            // CharacterNameLabel
            // 
            CharacterNameLabel.AutoSize = true;
            CharacterNameLabel.Location = new Point(58, 20);
            CharacterNameLabel.Name = "CharacterNameLabel";
            CharacterNameLabel.Size = new Size(93, 15);
            CharacterNameLabel.TabIndex = 6;
            CharacterNameLabel.Text = "Character Name";
            // 
            // CityLaber
            // 
            CityLaber.AutoSize = true;
            CityLaber.Location = new Point(61, 66);
            CityLaber.Name = "CityLaber";
            CityLaber.Size = new Size(28, 15);
            CityLaber.TabIndex = 7;
            CityLaber.Text = "City";
            // 
            // VocationLabel
            // 
            VocationLabel.AutoSize = true;
            VocationLabel.Location = new Point(61, 114);
            VocationLabel.Name = "VocationLabel";
            VocationLabel.Size = new Size(53, 15);
            VocationLabel.TabIndex = 8;
            VocationLabel.Text = "Vocation";
            VocationLabel.Click += label3_Click;
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Location = new Point(61, 176);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(25, 15);
            SexLabel.TabIndex = 9;
            SexLabel.Text = "Sex";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(61, 230);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 10;
            LevelLabel.Text = "Level";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(61, 286);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(48, 15);
            CreatedLabel.TabIndex = 11;
            CreatedLabel.Text = "Created";
            // 
            // BtnCreateCharacter
            // 
            BtnCreateCharacter.Location = new Point(197, 336);
            BtnCreateCharacter.Name = "BtnCreateCharacter";
            BtnCreateCharacter.Size = new Size(75, 23);
            BtnCreateCharacter.TabIndex = 12;
            BtnCreateCharacter.Text = "Create";
            BtnCreateCharacter.UseVisualStyleBackColor = true;
            BtnCreateCharacter.Click += BtnCreateCharacter_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 450);
            Controls.Add(BtnCreateCharacter);
            Controls.Add(CreatedLabel);
            Controls.Add(LevelLabel);
            Controls.Add(SexLabel);
            Controls.Add(VocationLabel);
            Controls.Add(CityLaber);
            Controls.Add(CharacterNameLabel);
            Controls.Add(txtCreated);
            Controls.Add(txtLevel);
            Controls.Add(txtSex);
            Controls.Add(txtVocation);
            Controls.Add(txtCity);
            Controls.Add(txtCharacterName);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            Load += CreateAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCharacterName;
        private TextBox txtCity;
        private TextBox txtVocation;
        private TextBox txtSex;
        private TextBox txtLevel;
        private TextBox txtCreated;
        private Label CharacterNameLabel;
        private Label CityLaber;
        private Label VocationLabel;
        private Label SexLabel;
        private Label LevelLabel;
        private Label CreatedLabel;
        private Button BtnCreateCharacter;
    }
}