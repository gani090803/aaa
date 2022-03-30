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
    public partial class FootballManagerStartMenu : Form
    {
        public FootballManagerStartMenu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            FootballManagerPlayMenu footballManagerPlayMenu = new FootballManagerPlayMenu();
            footballManagerPlayMenu.refToFootballManagerStartMenu = this;
            this.Hide();
            footballManagerPlayMenu.ShowDialog();
        }
    }
}
