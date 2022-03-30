using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Reserves
    {
        public int Id { get; set; }

        public List<Player> Players { get; set; }

        [ForeignKey("Squad")]
        public int SquadId { get; set; }
        public Squad Squad { get; set; }
    }
}