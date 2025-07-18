using ControleComercial.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleComercial.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ClienteModel> Clientes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
