using System;
using System.Linq;
using System.Linq.Expressions;
using ErpAnt.ApplicationCore.Interfaces.Repositories;

namespace ErpAnt.InfraStructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}