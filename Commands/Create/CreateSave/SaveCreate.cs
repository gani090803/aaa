using Commands.Create.CreateClub;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreateSave
{
    public class SaveCreate
    {
        public static Save CreateSave(string saveName, string clubName)
        {
            Save save = new Save();
            save.SaveName = saveName;
            save.Clubs = new List<Club>();
            for(int i = 0; i < 19; i++)
            {
                save.Clubs.Add(ClubCreate.CreateClub(i));
            }
            Club club = ClubCreate.CreateClub(1);
            club.ClubName = clubName;
            save.SaveName = saveName;
            save.Clubs.Add(club);

            return save;
        }
    }
}
