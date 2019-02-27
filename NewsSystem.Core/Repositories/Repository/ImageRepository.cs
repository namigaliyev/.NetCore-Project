using NewsSystem.Core.Repositories.Interfaces;
using NewsSystem.Data.DataContext;
using NewsSystem.Data.Models;

namespace NewsSystem.Core.Repositories.Repository
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(NewsContext dbContext) : base(dbContext)
        {
            
        }
    }
}