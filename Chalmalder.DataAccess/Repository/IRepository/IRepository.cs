﻿using System.Linq.Expressions;


namespace Chalmalder.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class 
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Remove(T entity);
        void Add(T entity);
        void RemoveRange(IEnumerable<T> entity);



    }
}
