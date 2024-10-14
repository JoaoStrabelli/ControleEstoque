using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.WebAPI.DataContext
{
    public class ControleEstoqueEFCoreContext : DbContext
    {
        public ControleEstoqueEFCoreContext(DbContextOptions<ControleEstoqueEFCoreContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
