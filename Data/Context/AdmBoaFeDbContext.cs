using AdmBoaFe.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Data
{
    public class AdmBoaFeDbContext: DbContext
    {
        public AdmBoaFeDbContext(DbContextOptions<AdmBoaFeDbContext> context) : base(context)
        {

        }

        public DbSet<Bloco> Bloco { get; set; }
    }
}
