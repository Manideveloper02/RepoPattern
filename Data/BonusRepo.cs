using RepoPattern.Models;

namespace RepoPattern.Data
{
    public class BonusRepo : EFCoreRepo<Bonu, FoodContext>
    {
        public BonusRepo(FoodContext context) : base(context)
        {
        }
    }
}
