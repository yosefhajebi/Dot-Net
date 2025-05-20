using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        public BaseController()
        {
                
        }
        [HttpGet]
        public abstract IEnumerable<T> Get();

        [HttpGet("{id}")]
        public abstract T Get(Guid id);


        [HttpPost("{id}")]
        public abstract void Post(Guid id, [FromBody] T value);
        
    }
}
