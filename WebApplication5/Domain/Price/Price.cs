using WebApplication5.Domain.Base;

namespace WebApplication5.Domain.Price
{
    public class Price:Aggregate
    {
        public Price() { }
        public decimal Price { get; set; }

    }
}
