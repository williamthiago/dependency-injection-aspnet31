using Microsoft.AspNetCore.Mvc;
using Shared;

namespace Api22.Controllers
{
    [Route("test")]
    public class TestController : Controller
    {
        private readonly IBooleanService _booleanService;

        public TestController(IBooleanService booleanService)
        {
            _booleanService = booleanService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_booleanService.GetBooleanValue());
        }
    }
}