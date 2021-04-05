using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PomarFrutasAPI.Models
{
    public class Trees
    {
        [Key]

        public int Code { get; set; }
        [Required(ErrorMessage = "Required field")]


        [MaxLength(500, ErrorMessage = "The must field containt maximum of 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required field")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Required field")]
        public int SpeciesId { get; set; }
        public Species Species { get; set; }

    }
}
