using WebApplication5.Domain.Base;

namespace WebApplication5.Domain.Discount
{
    public class Discount:Aggregate
    {
        public Discount()
        {
            
        }
        public DiscountType DiscountType { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; }
        public decimal TotalDiscount { get; set; }
        public Domain.Product.Product Product{ get; set; }
        public Domain.Category.Category Category { get; set; }
        public DiscountPeriod DiscountPeriod { get; set; }
    }
}
