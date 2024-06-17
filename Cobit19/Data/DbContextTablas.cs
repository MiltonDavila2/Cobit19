using Microsoft.EntityFrameworkCore;

namespace Cobit19.Data
{
    public class DbContextTablas:DbContext 
    {
        public DbContextTablas(DbContextOptions<DbContextTablas> options) : base(options) { }

        public DbSet<MetasAlineamiento> MetasAlineamientos { get; set; }

        public DbSet<MetasEmpresariales> MetasEmpresarialess { get; set; }
    }
}
