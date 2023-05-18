using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstact
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
        void Delete(T entity);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);
        T Get(Expression<Func<T, bool>> predicate);
        void Complete();
        void CompleteWithTransaction();
    }
}
