using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace L01P022022RR651.Models
{
    public class notasDBContext: DbContext
    {
        public notasDBContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }

    }
}
