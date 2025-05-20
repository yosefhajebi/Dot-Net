using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Domain.Test;

namespace WebApplication5.Controller
{
    public class TestController : BaseController<Test>
    {
        public TestController() { }

        public override IEnumerable<Test> Get()
        {
            var ali = new Test()
            {
                Id = Guid.NewGuid(),
                Name = "Test"
            };
            var testList= new List<Test>() { ali };
            return testList;
        }

        public override Test Get(Guid id)
        {
            return new Test()
            {
                Id = Guid.NewGuid(),
                Name = "Test"
            };
        }

        [HttpGet]
        public string GetTestName() {
            return "Test";
        }

        public override void Post(Guid id, [FromBody] Test value)
        {
            throw new NotImplementedException();
        }
    }
}
