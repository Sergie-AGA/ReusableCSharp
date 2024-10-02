using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReusableCSharp.Communication.Requests;

namespace ReusableCSharp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpPost]

        public IActionResult Create([FromBody] RequestAddTodoJson request)
        {
            return Created();
        }
    }
}
