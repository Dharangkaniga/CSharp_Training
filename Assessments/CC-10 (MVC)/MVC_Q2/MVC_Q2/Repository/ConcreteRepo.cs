using MVC_Q2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Q2.Repository
{
    public class ConcreteRepo<T> : IRepository<T> where T : class
    {
        MoviesDBContext db = new MoviesDBContext();
        System.Data.Entity.DbSet<T> table;

        public ConcreteRepo()
        {
            table = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}