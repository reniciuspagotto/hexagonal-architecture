using BookStore.Application.Commands;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookHandler _bookHandler;

        public BookController(IBookHandler bookHandler)
        {
            _bookHandler = bookHandler;
        }

        [HttpPost]
        public IActionResult Save(CreateBookCommand command)
        {
            _bookHandler.Save(command);
            return Ok();
        }
    }
}
