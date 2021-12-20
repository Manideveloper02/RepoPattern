using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

using RepoPattern.Data;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepoPattern.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class EFCoreController<TEntity, TRepo> : ControllerBase
        where TEntity : class
        where TRepo : IRepository<TEntity>
    {
        private readonly TRepo repository;

        public EFCoreController(TRepo repository)
        {
            this.repository = repository;
        }

        [Route("GetAll", Order = 1)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }
    }
}
