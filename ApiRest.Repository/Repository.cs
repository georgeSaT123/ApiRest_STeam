using ApiRest.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Repository
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        IDbContext<T> _ctx;
        public Repository(IDbContext<T> ctx) 
        { 
            _ctx = ctx;
        }
        public void Delete(int id)
        {
            _ctx.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _ctx.GetAll();
        }

        public T GetById(int id)
        {
            return _ctx.GetById(id);
        }

        public T Save(T entity)
        {
            return _ctx.Save(entity);
        }
    }
}
