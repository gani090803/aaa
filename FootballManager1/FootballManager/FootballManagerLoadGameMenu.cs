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
    public partial class FootballManagerLoadGameMenu : Form
    {
        public FootballManagerLoadGameMenu()
        {
            InitializeComponent();
        }

        private void FootballManagerLoadGameMenu_Load(object sender, EventArgs e)
        {
            List<Save> saves = Program.saveContext.Saves.ToList();
            savesDataGridView.DataSource = saves;
        }

        private void savesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
