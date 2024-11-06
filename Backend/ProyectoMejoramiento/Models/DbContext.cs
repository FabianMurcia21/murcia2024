using Microsoft.EntityFrameworkCore;

namespace ProyectoMejoramiento.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=ProyectoMejoramiento;User=root;Password=murcia21;Port=3306;",
                    new MySqlServerVersion(new Version(8, 0, 39)));
            }

        }
    }
}
