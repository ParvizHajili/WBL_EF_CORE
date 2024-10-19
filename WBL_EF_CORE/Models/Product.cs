using WBL_EF_CORE.Models.Abstract;

namespace WBL_EF_CORE.Models
{
    public class Product : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
