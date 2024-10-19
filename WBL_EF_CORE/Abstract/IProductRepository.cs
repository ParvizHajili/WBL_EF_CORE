using WBL_EF_CORE.Models;

namespace WBL_EF_CORE.Abstract
{
    public interface IProductRepository :IBaseRepository<Product>
    {
        List<Product> GetTopFiveExpensiveProducts();
    }
}
