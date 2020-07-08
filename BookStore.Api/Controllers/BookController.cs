using BookStore.Core.Business.BookService.CreateBook;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ICreateBookUseCase _createBookUseCase;

        public BookController(ICreateBookUseCase createBookUseCase)
        {
            _createBookUseCase = createBookUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> Save(CreateBookInput command)
        {
            await _createBookUseCase.Execute(command);
            return Ok();
        }
    }
}
