using WBL_EF_CORE.Models.Abstract;

namespace WBL_EF_CORE.Models
{
    public class Category : BaseEntity, IEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
