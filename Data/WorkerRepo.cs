using RepoPattern.Models;

namespace RepoPattern.Data
{
    public class WorkerRepo : EFCoreRepo<Worker, FoodContext>
    {
        public WorkerRepo(FoodContext context) : base(context)
        {
        }
    }
}
