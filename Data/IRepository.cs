using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepoPattern.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
    }
}
