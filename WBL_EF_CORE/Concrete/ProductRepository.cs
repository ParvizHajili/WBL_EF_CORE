using WBL_EF_CORE.Abstract;
using WBL_EF_CORE.Migrations;
using WBL_EF_CORE.Models;
using WBL_EF_CORE.SqlDbContext;

namespace WBL_EF_CORE.Concrete
{
    public class ProductRepository : BaseRepoitory<Product, ApplicationDbContext>, IProductRepository
    {
        public List<Product> GetTopFiveExpensiveProducts()
        {
            throw new NotImplementedException();
        }
    }
}
