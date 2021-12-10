using Aperitif.Models;
using Microsoft.EntityFrameworkCore;

namespace Aperitif.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
