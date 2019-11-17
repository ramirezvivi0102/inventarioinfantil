using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOUTIQUE.Models
{
    public class Producto
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }
}
