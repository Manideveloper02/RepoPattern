
using RepoPattern.Data;
using RepoPattern.Models;

namespace RepoPattern.Controllers
{

    public class WorkerController : EFCoreController<Worker, WorkerRepo>
    {
        public WorkerController(WorkerRepo repository) : base(repository)
        {
        }
    }
}
