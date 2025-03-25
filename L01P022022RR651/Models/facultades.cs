using System.ComponentModel.DataAnnotations;

namespace L01P022022RR651.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        [Required(ErrorMessage = "Campo NO opcional")]
        public string facultad { get; set; }
    }
}
