using _01_ControllerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace _01_ControllerApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            return Ok(await _bookService.GetBooksAsync());
        }
    }
}
