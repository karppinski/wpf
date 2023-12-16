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
            CharNameTB = new TextBox();
            CityTB = new TextBox();
            VocationTB = new TextBox();
            SexTB = new TextBox();
            LevelTB = new TextBox();
            CreatedTB = new TextBox();
            CharacterNameLabel = new Label();
            CityLaber = new Label();
            VocationLabel = new Label();
            SexLabel = new Label();
            LevelLabel = new Label();
            CreatedLabel = new Label();
            SuspendLayout();
            // 
            // CharNameTB
            // 
            CharNameTB.Location = new Point(177, 17);
            CharNameTB.Name = "CharNameTB";
            CharNameTB.Size = new Size(111, 23);
            CharNameTB.TabIndex = 0;
            // 
            // CityTB
            // 
            CityTB.Location = new Point(177, 58);
            CityTB.Name = "CityTB";
            CityTB.Size = new Size(111, 23);
            CityTB.TabIndex = 1;
            // 
            // VocationTB
            // 
            VocationTB.Location = new Point(177, 106);
            VocationTB.Name = "VocationTB";
            VocationTB.Size = new Size(111, 23);
            VocationTB.TabIndex = 2;
            // 
            // SexTB
            // 
            SexTB.Location = new Point(177, 168);
            SexTB.Name = "SexTB";
            SexTB.Size = new Size(111, 23);
            SexTB.TabIndex = 3;
            // 
            // LevelTB
            // 
            LevelTB.Location = new Point(177, 227);
            LevelTB.Name = "LevelTB";
            LevelTB.Size = new Size(111, 23);
            LevelTB.TabIndex = 4;
            // 
            // CreatedTB
            // 
            CreatedTB.Location = new Point(177, 278);
            CreatedTB.Name = "CreatedTB";
            CreatedTB.Size = new Size(111, 23);
            CreatedTB.TabIndex = 5;
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
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 450);
            Controls.Add(CreatedLabel);
            Controls.Add(LevelLabel);
            Controls.Add(SexLabel);
            Controls.Add(VocationLabel);
            Controls.Add(CityLaber);
            Controls.Add(CharacterNameLabel);
            Controls.Add(CreatedTB);
            Controls.Add(LevelTB);
            Controls.Add(SexTB);
            Controls.Add(VocationTB);
            Controls.Add(CityTB);
            Controls.Add(CharNameTB);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CharNameTB;
        private TextBox CityTB;
        private TextBox VocationTB;
        private TextBox SexTB;
        private TextBox LevelTB;
        private TextBox CreatedTB;
        private Label CharacterNameLabel;
        private Label CityLaber;
        private Label VocationLabel;
        private Label SexLabel;
        private Label LevelLabel;
        private Label CreatedLabel;
    }
}