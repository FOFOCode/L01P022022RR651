using System.ComponentModel.DataAnnotations;

namespace L01P022022RR651.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }
        public string codigo { get; set; } = string.Empty;
        public string nombre { get; set; } = string.Empty;
        public string apellidos { get; set; } = string.Empty;
        public int dui { get; set; }
        public int estado { get; set; }
    }
}
