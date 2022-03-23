namespace FootballManager
{
    partial class FootballManagerNewGameMenu
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
            this.saveNameLabel = new System.Windows.Forms.Label();
            this.clubNameLabel = new System.Windows.Forms.Label();
            this.saveNameTextBox = new System.Windows.Forms.TextBox();
            this.clubNameTextBox = new System.Windows.Forms.TextBox();
            this.createSaveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveNameLabel
            // 
            this.saveNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveNameLabel.Location = new System.Drawing.Point(264, 9);
            this.saveNameLabel.Name = "saveNameLabel";
            this.saveNameLabel.Size = new System.Drawing.Size(300, 57);
            this.saveNameLabel.TabIndex = 0;
            this.saveNameLabel.Text = "Save Name:";
            this.saveNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clubNameLabel
            // 
            this.clubNameLabel.AutoEllipsis = true;
            this.clubNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clubNameLabel.Location = new System.Drawing.Point(264, 99);
            this.clubNameLabel.Name = "clubNameLabel";
            this.clubNameLabel.Size = new System.Drawing.Size(300, 60);
            this.clubNameLabel.TabIndex = 1;
            this.clubNameLabel.Text = "Club Name:";
            this.clubNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveNameTextBox
            // 
            this.saveNameTextBox.Location = new System.Drawing.Point(264, 69);
            this.saveNameTextBox.Name = "saveNameTextBox";
            this.saveNameTextBox.Size = new System.Drawing.Size(300, 27);
            this.saveNameTextBox.TabIndex = 2;
            // 
            // clubNameTextBox
            // 
            this.clubNameTextBox.Location = new System.Drawing.Point(264, 162);
            this.clubNameTextBox.Name = "clubNameTextBox";
            this.clubNameTextBox.Size = new System.Drawing.Size(300, 27);
            this.clubNameTextBox.TabIndex = 3;
            // 
            // createSaveButton
            // 
            this.createSaveButton.Font = new System.Drawing.Font("Artifakt Element", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createSaveButton.Location = new System.Drawing.Point(264, 195);
            this.createSaveButton.Name = "createSaveButton";
            this.createSaveButton.Size = new System.Drawing.Size(300, 100);
            this.createSaveButton.TabIndex = 4;
            this.createSaveButton.Text = "Create";
            this.createSaveButton.UseVisualStyleBackColor = true;
            this.createSaveButton.Click += new System.EventHandler(this.createSaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Artifakt Element", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(264, 301);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 100);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FootballManagerNewGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createSaveButton);
            this.Controls.Add(this.clubNameTextBox);
            this.Controls.Add(this.saveNameTextBox);
            this.Controls.Add(this.clubNameLabel);
            this.Controls.Add(this.saveNameLabel);
            this.Name = "FootballManagerNewGameMenu";
            this.Text = "FootballManagerNewGameMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FootballManagerNewGameMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label saveNameLabel;
        private Label clubNameLabel;
        private TextBox saveNameTextBox;
        private TextBox clubNameTextBox;
        private Button createSaveButton;
        private Button backButton;
    }
}