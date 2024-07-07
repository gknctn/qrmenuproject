using Entities.Models;
using Microsoft.EntityFrameworkCore;
using qrmenuproject.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class, new()
    {
        protected readonly RepositoryContext _context;

        protected RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public void AddItem(T t, bool trackChanges)
        {
            _context.Set<T>().Add(t);
        }

        public void DeleteItem(T t, bool trackChanges)
        {
            _context.Remove(t);
        }

        public void EditItem(T t, bool trackChanges)
        {
            _context.Update(t);
        }

        public IQueryable<T> GetAll(bool trackChanges)
        {
            return trackChanges
                ? _context.Set<T>()
                : _context.Set<T>().AsNoTracking();
        }

        public T? GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges
                ? _context.Set<T>().Where(expression).SingleOrDefault()
                : _context.Set<T>().Where(expression).AsNoTracking().SingleOrDefault();
        }
    }
}
