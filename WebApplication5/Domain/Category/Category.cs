using WebApplication5.Domain.Base;

namespace WebApplication5.Domain.Category
{
    public class Category:Aggregate
    {
        public Category() { }
        public Category ParentCategory { get; set; }
        public string Name { get; set; }
    }
}
