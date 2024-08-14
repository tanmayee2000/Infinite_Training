using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CC_MVC.Models;
using System.Data.Entity;


namespace CC_MVC.Repository
{
    public class MovieRepository<T> : IMovieRepository<T> where T : class
    {
        MoviesContext db;
        DbSet<T> dbset;
        public MovieRepository()
        {
            db = new MoviesContext();
            dbset = db.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetById(object Id)
        {
            return dbset.Find(Id);
        }

        public IEnumerable<T> GetMoviesByYear(int year)
        {
            return dbset.ToList();
        }
        public void Insert(T obj)
        {
            dbset.Add(obj);
        }
        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object Id)
        {
            T getmodel = dbset.Find(Id);        //For generic //getmodel - obj of T
            dbset.Remove(getmodel);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}