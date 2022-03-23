namespace FootballManager
{
    partial class FootballManagerLoadGameMenu
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
            this.savesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.savesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // savesDataGridView
            // 
            this.savesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savesDataGridView.Location = new System.Drawing.Point(52, 37);
            this.savesDataGridView.Name = "savesDataGridView";
            this.savesDataGridView.RowHeadersWidth = 51;
            this.savesDataGridView.RowTemplate.Height = 29;
            this.savesDataGridView.Size = new System.Drawing.Size(300, 188);
            this.savesDataGridView.TabIndex = 0;
            // 
            // FootballManagerLoadGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savesDataGridView);
            this.Name = "FootballManagerLoadGameMenu";
            this.Text = "FootballManagerLoadGameMenu";
            this.Load += new System.EventHandler(this.FootballManagerLoadGameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView savesDataGridView;
    }
}