using System.Collections.Generic;
using System.Linq;
using EFCoreDBProviders.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreDBProviders.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>
    {
        public LivroRepository(DbContext db) : base(db) { }

        public IEnumerable<Livro> GetByYear(int year)
        {
            return db.Set<Livro>().Where(x => x.AnoPublicacao == year);
        }
    }
}