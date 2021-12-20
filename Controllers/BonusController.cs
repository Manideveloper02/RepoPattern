
using RepoPattern.Data;
using RepoPattern.Models;

namespace RepoPattern.Controllers
{

    public class BonusController : EFCoreController<Bonu, BonusRepo>
    {
        public BonusController(BonusRepo repository) : base(repository)
        {
        }
    }
}
