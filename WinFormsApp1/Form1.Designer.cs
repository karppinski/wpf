namespace WinFormsApp1 { 
    partial class Form1
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
            Create = new Button();
            Delete = new Button();
            Search = new Button();
            Change = new Button();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Location = new Point(101, 131);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 0;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(487, 131);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 1;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.Location = new Point(233, 131);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 3;
            Search.Text = "search";
            Search.UseVisualStyleBackColor = true;
            // 
            // Change
            // 
            Change.Location = new Point(373, 131);
            Change.Name = "Change";
            Change.Size = new Size(75, 23);
            Change.TabIndex = 4;
            Change.Text = "Change";
            Change.UseVisualStyleBackColor = true;
            Change.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 372);
            Controls.Add(Change);
            Controls.Add(Search);
            Controls.Add(Delete);
            Controls.Add(Create);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Create;
        private Button Delete;
        private Button Search;
        private Button Change;
    }
}
