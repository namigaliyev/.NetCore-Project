using NewsSystem.Core.Repositories.Interfaces;
using NewsSystem.Data.DataContext;
using NewsSystem.Data.Models;

namespace NewsSystem.Core.Repositories.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(NewsContext dbContext) : base(dbContext)
        {
            
        }
    }
}