using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskOKApp.Models
{
    public class Cargos
    {
        [Key]
        public int CargoId { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Nombre { get; set; }

    }
}
