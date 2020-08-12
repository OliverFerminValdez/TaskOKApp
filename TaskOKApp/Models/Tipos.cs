using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskOKApp.Models
{
    public class Tipos
    {
        [Key]
        public int TipoId { get; set; }
        [Required(ErrorMessage ="Se requiere una descripcion")]
        public string Descripcion { get; set; }

    }
}
