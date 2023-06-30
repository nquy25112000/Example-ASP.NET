
namespace Sample1.Repository
{
    public interface IBaseRepository<E>
    {
        List<E> GetAll();
        E GetById(int id);
        E Create(E entity);
        E Update(E entity);
        void Delete(int id);
    }
}
