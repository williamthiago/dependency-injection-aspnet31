using Microsoft.AspNetCore.Mvc;
using Shared;

namespace Api31.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
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