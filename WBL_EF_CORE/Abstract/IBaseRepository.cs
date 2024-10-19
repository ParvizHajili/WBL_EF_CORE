using WBL_EF_CORE.Models.Abstract;

namespace WBL_EF_CORE.Abstract
{
    public interface IBaseRepository<T> where T : IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
