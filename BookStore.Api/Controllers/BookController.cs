using BookStore.Application.UseCases.Commands.CreateBook;
using BookStore.Application.UseCases.Queries.ListBook;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ICreateBookHandler _bookHandler;
        private readonly IListBookHandler _listBookHandler;

        public BookController(ICreateBookHandler bookHandler, IListBookHandler listBookHandler)
        {
            _bookHandler = bookHandler;
            _listBookHandler = listBookHandler;
        }

        [HttpPost]
        public IActionResult Save(CreateBookCommand command)
        {
            _bookHandler.Save(command);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _listBookHandler.GetAll();
            return Ok(result);
        }
    }
}
