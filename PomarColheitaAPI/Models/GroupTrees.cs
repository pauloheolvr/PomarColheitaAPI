using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PomarFrutasAPI.Models
{
    public class GroupTrees
    {
        [Key]

        public int Code { get; set; }
        [Required(ErrorMessage = "Required field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Trees { get; set; }
    }
}
