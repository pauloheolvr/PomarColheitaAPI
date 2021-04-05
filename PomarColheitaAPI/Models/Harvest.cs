using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PomarFrutasAPI.Models
{
    public class Harvest
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "Required field")]
        public string Information { get; set; }

        [Required(ErrorMessage = "Required field")]
        public int HarvestDate { get; set; }

        [Required(ErrorMessage = "Required field")]
        public decimal GrossWeight { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string TreeId { get; set; }

        public Trees Trees { get; set; }
    }
}
