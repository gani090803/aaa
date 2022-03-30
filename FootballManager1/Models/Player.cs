using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Nation { get; set; }

        [Range(1, 99)]
        [DefaultValue(60)]
        public int Rating { get; set; }

        [Range(1, 99)]
        [DefaultValue(60)]
        public int Potential { get; set; }

        [Range(14, 99)]
        [DefaultValue(18)]
        public int Age { get; set; }

        public Stats? Stats { get; set; }

        public double Value { get; set; }

        [Required]
        [MaxLength(3)]
        [DefaultValue(" ")]
        public string? Position1 { get; set; }

        [Required]
        [MaxLength(3)]
        [DefaultValue(" ")]
        public string? Position2 { get; set; }

        [Required]
        [MaxLength(3)]
        [DefaultValue(" ")]
        public string? Position3 { get; set; }



        [ForeignKey("StartingEleven")]
        public int? StartingElevenId { get; set; }
        public StartingEleven? StartingEleven { get; set; }

        [ForeignKey("Bench")]
        public int? BenchId { get; set; }
        public Bench? Bench { get; set; }

        [ForeignKey("Reserves")]
        public int? ReservesId { get; set; }
        public Reserves? Reserves { get; set; }
    }
}