using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

public interface IBaseRepository<T> where T : class
{
    IQueryable<T> GetAll();
 
    T GetById(int id);

    T Get(Expression<Func<T, bool>> expression);

    IQueryable<T> GetMany(Expression<Func<T, bool>> expression);
 
    void Create(T entity);
 
    void Update(T entity);

    void Delete(int id);

    int Count();
}