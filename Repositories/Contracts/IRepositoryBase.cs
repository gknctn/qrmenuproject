using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);
        T? GetByCondition (Expression<Func<T, bool>> expression, bool trackChanges);
        void AddItem (T t, bool trackChanges);
        void EditItem (T t, bool trackChanges);
        void DeleteItem (T t, bool trackChanges);
    }
}
