using AdmBoaFe.App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Data
{
    public class AdmBoaFeDbContext: DbContext
    {
        public AdmBoaFeDbContext(DbContextOptions<AdmBoaFeDbContext> context) : base(context)
        {

        }
        public DbSet<Bloco> Bloco { get; set; }
        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Locatario> Locatario { get; set; }        
        public DbSet<Manutencao> Manutencao { get; set; }
        public DbSet<Proprietario> Proprietario { get; set; }
        public DbSet<UnidadeCondominial> UnidadeCondominial { get; set; }
        public DbSet<UnidadeProprietario> UnidadeProprietario { get; set; }

    }
}
