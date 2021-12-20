
using RepoPattern.Data;
using RepoPattern.Models;

namespace RepoPattern.Controllers
{
    public class InterviewController : EFCoreController<Interview, InterviewRepo>
    {
        public InterviewController(InterviewRepo repository) : base(repository)
        {

        }
    }
}
