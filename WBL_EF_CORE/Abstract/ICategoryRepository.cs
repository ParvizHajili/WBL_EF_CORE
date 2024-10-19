using WBL_EF_CORE.Models;

namespace WBL_EF_CORE.Abstract
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetById(int id);
        List<Category> GetAll();
    }
}
