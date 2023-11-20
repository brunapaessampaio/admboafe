using AdmBoaFe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BlocoRepository : IBlocoRepository
    {
        public BlocoRepository(AdmBoaFeDbContext context) 
        {
        }

        public async Task<Bloco> BlocoPorId(int idBloco)
        {
            return await DbSet.Where(x => x.IdFunc == idFunc).FirstOrDefaultAsync();
        }

        public async Task<Funcionario> DadosFuncionarioPorMatricula(string matricula)
        {
            return await DbSet.Where(x => x.Matricula == matricula).FirstOrDefaultAsync();
        }
    }
}
