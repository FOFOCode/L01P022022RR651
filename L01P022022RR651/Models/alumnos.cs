using System.ComponentModel.DataAnnotations;

namespace L01P022022RR651.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "Id Alumnos")]
        public int id { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public string codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public string nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public string apellidos { get; set; }

        [Display(Name = "Dui")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public int dui { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public int estado { get; set; }
    }
}
