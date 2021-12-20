using RepoPattern.Models;

namespace RepoPattern.Data
{
    public  class InterviewRepo : EFCoreRepo<Interview, FoodContext>

    {
        public InterviewRepo(FoodContext context) : base(context)
        {
        }

    }
}
