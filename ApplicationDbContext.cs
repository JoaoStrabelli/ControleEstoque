using ControleEstoque.WebAPI.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.WebAPI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=estoque.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
