using WebApplication5.Domain.Base;
using WebApplication5.Domain.Brand;

namespace WebApplication5.Domain.Product
{
    public class Product:Aggregate
    {
        public Product() { }
        public Domain.Brand.Brand Brand { get; set; }
        public Domain.Category.Category Category  { get; set; }
        public Domain.Color.Color Color { get; set; }
    }
}
