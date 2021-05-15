using Microsoft.EntityFrameworkCore;

namespace Appweb1.Models
{
  public class Context : DbContext
  {
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("Host=localhost;port=5432;Database=appweb1;Username=postgres;Password=docker");
    }
  }
}