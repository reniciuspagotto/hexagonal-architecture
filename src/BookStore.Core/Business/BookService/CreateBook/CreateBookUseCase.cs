using BookStore.Core.Domain.Entities;
using BookStore.Core.Domain.Validators;
using System.Threading.Tasks;

namespace BookStore.Core.Business.BookService.CreateBook
{
    public class CreateBookUseCase : ICreateBookUseCase
    {
        public Task<CreateBookOutput> Execute(CreateBookInput data)
        {
            var book = new Book(data.Name, data.Author, data.Description, data.Category, data.PublishingCompany);

            var resultValidation = new BookValidator().Validate(book);

            throw new System.NotImplementedException();
        }
    }
}
