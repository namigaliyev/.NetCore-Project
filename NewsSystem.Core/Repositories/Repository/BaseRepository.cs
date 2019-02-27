
using System.Linq;
using System.Threading.Tasks;
using NewsSystem.Data.DataContext;
using System;
using System.Linq.Expressions;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly NewsContext dbContext;

    public BaseRepository(NewsContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IQueryable<T> GetAll()
    {
        return dbContext.Set<T>();
    }

    public T GetById(int id)
    {
        return dbContext.Set<T>().Find(id);
    }

    public IQueryable<T> GetMany(Expression<Func<T, bool>> expression)
    {
        return dbContext.Set<T>()
                .Where(expression);
    }

    public T Get(Expression<Func<T, bool>> expression)
    {
        return dbContext.Set<T>()
                .Where(expression)
                .FirstOrDefault();
    }

    public void Create(T entity)
    {
        dbContext.Set<T>().Add(entity);
        dbContext.SaveChanges();
    }

    public void Update(T entity)
    {
        dbContext.Set<T>().Update(entity);
        dbContext.SaveChanges();
    }

    public int Count()
    {
        return dbContext.Set<T>().Count();
    }

    public void Delete(int id)
    {
        T entity = dbContext.Set<T>().Find(id);
        dbContext.Set<T>().Remove(entity);
        dbContext.SaveChanges();
    }
}