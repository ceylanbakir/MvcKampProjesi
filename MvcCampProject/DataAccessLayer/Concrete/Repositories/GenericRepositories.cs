using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepositories<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepositories()
        {
            _object = c.Set<T>();
        }
        public void Delete(T t)
        {
            var deletedEntity = c.Entry(t);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();


            //_object.Remove(t);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T t)
        {
            var addedEntity = c.Entry(t);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();


            //_object.Add(t);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            var updatedEntity = c.Entry(t);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
            
        }
    }
}
