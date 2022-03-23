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
    public partial class FootballManagerPlayMenu : Form
    {
        public FootballManagerStartMenu refToFootballManagerStartMenu;
        public FootballManagerPlayMenu()
        {
            InitializeComponent();
        }

        private void FootballManagerPlayMenu_Load(object sender, EventArgs e)
        {

        }

        private void FootballManagerPlayMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            refToFootballManagerStartMenu.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            refToFootballManagerStartMenu.Show();
            this.Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            FootballManagerNewGameMenu footballManagerNewGame = new FootballManagerNewGameMenu();
            footballManagerNewGame.refToFootballManagerPlayMenu = this;
            this.Hide();
            footballManagerNewGame.ShowDialog();
        }
    }
}
