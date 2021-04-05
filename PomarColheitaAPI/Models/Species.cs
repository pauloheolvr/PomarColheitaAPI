using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PomarFrutasAPI.Models
{
    public class Species
    {
        [Key]

        public int Code { get; set; }


        [Required(ErrorMessage = "Required field")]
        [MaxLength(60, ErrorMessage = "The must field contain between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "The must field contain between 3 and 60 characters")]

        public string Description { get; set; }



    }
}
