using Microsoft.EntityFrameworkCore;
using Sample1.Data;

namespace Sample1.Repository
{
    public abstract class BaseRepository<E> : IBaseRepository<E> where E : class
    {
        private readonly MyDbContext _db;

        public BaseRepository(MyDbContext db)
        {
            _db = db;
        }
            
        public E Create(E entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            E entity = this.GetById(id);
            if (entity == null) return;
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public List<E> GetAll()
        {
            return _db.Set<E>().ToList();
        }

        public E GetById(int id)
        {
            return _db.Set<E>().Find(id);
        }

        public E Update(E entity)
        {
            _db.SaveChanges();
            return entity;
        }
    }
}
