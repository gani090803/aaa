using Commands.GetDataFromDataBase;
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
    public partial class FootballManagerSquadMenu : Form
    {
        public FootballManagerSquadMenu()
        {
            InitializeComponent();
        }

        private void FootballManagerSquadMenu_Load(object sender, EventArgs e)
        {
            Save save = GetEverythingFromDataBase.GetEverythingFromDataBaseCommand(Program.saveContext);
            List<Player> players = new List<Player>();

            if (save.Clubs.LastOrDefault(x => x.Id == 1).Squad.StartingEleven.Players != null)
            {
                foreach (Player player in save.Clubs.LastOrDefault(x => x.Id == 1).Squad.StartingEleven.Players)
                {
                    players.Add(player);
                }
            }
            if (save.Clubs.LastOrDefault(x => x.Id == 1).Squad.Bench.Players != null)
            {
                foreach (Player player in save.Clubs.LastOrDefault(x => x.Id == 1).Squad.Bench.Players)
                {
                    players.Add(player);
                }
            }
            if (save.Clubs.LastOrDefault(x => x.Id == 1).Squad.Reserves.Players != null)
            {
                foreach (Player? player in save.Clubs.LastOrDefault(x => x.Id == 1).Squad.Reserves.Players)
                {
                    players.Add(player);
                }
            }
            squadDataGridView.DataSource = players;
        }
    }
}
