using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Save
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DefaultValue($"New Save")]
        public string? SaveName { get; set; }

        public List<Club>? Clubs { get; set; }
    }
}
