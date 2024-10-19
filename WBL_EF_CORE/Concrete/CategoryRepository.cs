using WBL_EF_CORE.Abstract;
using WBL_EF_CORE.Models;
using WBL_EF_CORE.SqlDbContext;

namespace WBL_EF_CORE.Concrete
{
    public class CategoryRepository : BaseRepoitory<Category, ApplicationDbContext>, ICategoryRepository
    {

    }
}
