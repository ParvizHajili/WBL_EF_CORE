namespace WBL_EF_CORE.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
