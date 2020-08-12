using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskOKApp.Models
{
    public class Encargados
    {
        [Key]
        public int EncargadoId { get; set; }
        [Required(ErrorMessage ="El nombre es un campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es un campo obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "La cedula es un campo obligatorio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El area es un campo obligatorio")]
        [Display(Name ="Eliga un ")]
        public int AreaId { get; set; }
        public int DepartamentoId { get; set; }
        public int CargoId { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }
}
