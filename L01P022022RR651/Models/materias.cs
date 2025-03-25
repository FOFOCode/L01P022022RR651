using System.ComponentModel.DataAnnotations;

namespace L01P022022RR651.Models
{
    public class materias
    {
        [Key]

        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Materia")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public string materia { get; set; }

        [Display(Name = "Unidades Valorativas")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public int unidades_valorativas { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public char estado { get; set; }
    }
}
