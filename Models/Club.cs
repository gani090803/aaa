using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Club
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? ClubName { get; set; }

        [DefaultValue(1)]
        public double ClubStrength { get; set; }

        public Squad? Squad { get; set; }
    }
}
