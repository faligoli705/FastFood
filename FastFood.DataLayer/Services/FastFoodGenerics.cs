using FastFood.DataLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FastFood.DataLayer.DataAccess
{
    public class FastFoodGenerics<T> where T : class
    {
        private readonly FastFoodContext _context;
        private readonly DbSet<T> _dbset;
        public FastFoodGenerics(FastFoodContext context)
        {
            _context = context;
           // _dbset = _context.Set<T>();
        }

        public virtual IEnumerable<T> Get(Expression<Func<T,bool>> where=null)
        {
            IQueryable<T> query = _dbset;

            if (where != null)
                query = query.Where(where);
            return query.ToList();
        }

        public virtual T GetById(object id)
        {
            return _dbset.Find(id);
        }

        public virtual void Insert(T t)
        {
            _dbset.Add(t);
        }

        public virtual void Update(T t)
        {
            _dbset.Attach(t);
           // _context.Entry(t).State = EntityState.Modified;
        }
       
        public virtual void Delete(T t)
        {
            //if (_context.Entry(t).State == EntityState.Detached)
            //{
            //    _dbset.Attach(t);
            //}
            _dbset.Remove(t);
        }

        public virtual void Delete( object id)
        {
            var t = GetById(id);
            Delete(t);
        }
    }
}
