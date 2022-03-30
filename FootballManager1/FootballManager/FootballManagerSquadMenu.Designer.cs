
namespace FootballManager
{
    partial class FootballManagerSquadMenu
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
            this.squadDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.squadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // squadDataGridView
            // 
            this.squadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.squadDataGridView.Location = new System.Drawing.Point(12, 93);
            this.squadDataGridView.Name = "squadDataGridView";
            this.squadDataGridView.RowHeadersWidth = 51;
            this.squadDataGridView.RowTemplate.Height = 29;
            this.squadDataGridView.Size = new System.Drawing.Size(1150, 188);
            this.squadDataGridView.TabIndex = 0;
            // 
            // FootballManagerSquadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.squadDataGridView);
            this.Name = "FootballManagerSquadMenu";
            this.Text = "FootballManagerSquadMenu";
            this.Load += new System.EventHandler(this.FootballManagerSquadMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.squadDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView squadDataGridView;
    }
}