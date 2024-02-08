using ApiRest.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.DataAccess
{
    public class DbContext<T> : IDbContext<T> where T : class, IEntity
    {
        //IList<T> _data;
        DbSet<T> _items;
        ApiDbContext _ctx;
        public DbContext(ApiDbContext ctx) 
        {
            //_data = new List<T>();
            _ctx= ctx;
            _items = ctx.Set<T>();

        }
        public void Delete(int id)
        {
            //var d = _data.Where(d => d.Id.Equals(id)).FirstOrDefault();
            //if (d != null) _data.Remove(d);
        }

        public IList<T> GetAll()
        {
            //return _data;
            var data = _items.ToList();
            return data;
        }

        public T GetById(int id)
        {
            //var d = _data.Where(d => d.Id.Equals(id)).FirstOrDefault();
            //return d;
            var item = _items.Where(i => i.Id.Equals(id)).FirstOrDefault();
            return item;
        }

        public T Save(T entity)
        {
            //if(entity.Id.Equals(0)) _data.Add(entity);
            //return entity;
            _items.Add(entity);
            _ctx.SaveChanges();
            return entity;
        }
    }
}
