using Microsoft.AspNetCore.Mvc;

namespace _01_ControllerApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello world";
        }
    }
}
