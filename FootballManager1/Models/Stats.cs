using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Stats
    {
        public int Id { get; set; }
        [DefaultValue(0)]
        public int GamesPlayedCurrentSeason { get; set; }


        [DefaultValue(0)]
        public int GamesPlayedAllTime { get; set; }


        [DefaultValue(0)]
        public int GoalsScoredCurrentSeason { get; set; }


        [DefaultValue(0)]
        public int GoalsScoredAllTime { get; set; }


        [DefaultValue(0)]
        public int CleanSheetsCurrentSeason { get; set; }


        [DefaultValue(0)]
        public int CleanSheetsAllTime { get; set; }


        [DefaultValue(0)]
        public int AssistsCurrentSeason { get; set; }


        [DefaultValue(0)]
        public int AssistsAllTime { get; set; }

        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}