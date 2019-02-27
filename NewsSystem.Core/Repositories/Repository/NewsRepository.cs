using NewsSystem.Core.Repositories.Interfaces;
using NewsSystem.Data.DataContext;
using NewsSystem.Data.Models;

namespace NewsSystem.Core.Repositories.Repository
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        public NewsRepository(NewsContext dbContext) : base(dbContext)
        {
            
        }
    }
}