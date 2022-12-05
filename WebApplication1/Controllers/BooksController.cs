using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        private readonly ILogger<BooksController> _logger;

        public BooksController(
            IBookRepository bookRepository,
            ILogger<BooksController> logger
        )
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookDetailById(int id)
        {
            var book = await _bookRepository.GetBookDetailById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }


        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookDto model)
        {
            var id = await _bookRepository.CreateBook(model);

            return Ok(id);
        }
    }
}
