using System.ComponentModel.DataAnnotations;

namespace L01P022022RR651.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public string departamento { get; set; }
    }
}
