using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepoPattern.Data
{
    public class EFCoreRepo<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        private readonly TContext context;

        public EFCoreRepo(TContext context)
        {
            this.context = context;
        }
        public async Task<TEntity> Get(int id)
        {
          return await context.Set<TEntity>().FindAsync(id);

        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }
    }
}
