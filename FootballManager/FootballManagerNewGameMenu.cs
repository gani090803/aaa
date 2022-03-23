using Commands.Create.CreateSave;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager
{
    public partial class FootballManagerNewGameMenu : Form
    {
        public FootballManagerPlayMenu refToFootballManagerPlayMenu;

        public FootballManagerNewGameMenu()
        {
            InitializeComponent();
        }

        private void createSaveButton_Click(object sender, EventArgs e)
        {
            Save save = SaveCreate.CreateSave(saveNameTextBox.Text, clubNameTextBox.Text); 
            Program.saveContext.Update(save);
            Program.saveContext.SaveChanges();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            refToFootballManagerPlayMenu.Show();
            this.Close();
        }

        private void FootballManagerNewGameMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            refToFootballManagerPlayMenu.Show();
        }
    }
}
