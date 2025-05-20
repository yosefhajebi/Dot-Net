namespace WebApplication5.Domain.Test
{
    public class Aggregate
    {
        public Guid Id { get; set; }   
    }
    public class Test : Aggregate
    {
        public string Name{ get; set; }

    }
}
