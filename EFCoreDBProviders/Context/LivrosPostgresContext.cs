using EFCoreDBProviders.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreDBProviders.Context
{
    public class LivrosPostgresContext : DbContext
    {
        public LivrosPostgresContext(DbContextOptions<LivrosPostgresContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilderConfig.AddPreferences(ref modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Livro> Livros { get; set; }
    }
}