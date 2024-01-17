using System.Linq;
using System.Collections.Generic;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.Context;

namespace Contouring_App.Persistance.Repositories

{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _appContext;

        public GenericRepo(AppDbContext appcontext)
        {
            _appContext = appcontext;
        }

        public T GetById(int id)
        {
            T entity = _appContext.Set<T>().Find(id);
            if (entity == null)
            {
                throw new Exception("Data is nulll");
            }

            return entity;

        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> all_data = _appContext.Set<T>().ToList();
            if (all_data == null)
            {
                throw new Exception("Data is nulll");
            }
            return all_data;

        }

        public void Add(T entity)
        {
            _appContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _appContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _appContext.Set<T>().Remove(entity);
        }
    }

}
