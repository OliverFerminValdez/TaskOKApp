using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskOKApp.Models
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public DateTime Publicacion { get; set; } = DateTime.Today;
        public DateTime Entrega { get; set; } = DateTime.Today;
        [Required(ErrorMessage ="Es obligatorio introducir el tipo de tarea")]
        [Display(Name ="Elija un tipo")]
        public int TipoId { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir el nombre de la tarea")]
        [StringLength(maximumLength: 40, MinimumLength = 4, ErrorMessage ="El nombre de la tarea es muy corto")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir la descripcion de la tarea")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir un estado")]
        [Display(Name ="Elija un estado")]
        public int Estado { get; set; }
        [Required(ErrorMessage ="Debe señalar una area requerida")]
        [Display(Name ="Elija un area requerida")]
        public int AreaId { get; set; }
        [Required(ErrorMessage = "Debe señalar un cargo requerido")]
        [Display(Name = "Elija un cargo requerido")]
        public int CargoId { get; set; }
    }
}
