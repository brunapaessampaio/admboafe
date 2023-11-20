using Microsoft.EntityFrameworkCore;
using AdmBoaFe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Servico.Data.Repository
{
    public class Repository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        protected readonly AdmBoaFeDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(MyContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }


        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
