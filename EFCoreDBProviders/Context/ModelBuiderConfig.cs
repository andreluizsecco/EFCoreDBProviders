using EFCoreDBProviders.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDBProviders.Context
{
    public static class ModelBuilderConfig
    {
        public static void AddPreferences(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                 .ToTable("Livro");
                 
            // Caso o nome da propriedade seja ID ou <NomeDaClasse>Id por convenção ele será uma chave primária,
            // Caso o nome não siga esse padrão, utilize o código modelo abaixo para definir sua chave primária
            // modelBuilder.Entity<Livro>()
            //      .HasKey(p => p.ID);

            modelBuilder.Entity<Livro>()
                 .Property(p => p.ID)
                 .ValueGeneratedOnAdd();

            modelBuilder.Entity<Livro>()
                 .Property(p => p.Titulo)
                 .HasColumnType("varchar(255)")
                 .IsRequired();

            modelBuilder.Entity<Livro>()
                 .Property(p => p.Autor)
                 .HasColumnType("varchar(50)")
                 .IsRequired();
        }
    }
}