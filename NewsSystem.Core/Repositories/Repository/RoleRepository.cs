using NewsSystem.Core.Repositories.Interfaces;
using NewsSystem.Data.DataContext;
using NewsSystem.Data.Models;

namespace NewsSystem.Core.Repositories.Repository
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(NewsContext dbContext) : base(dbContext)
        {
            
        }
    }
}