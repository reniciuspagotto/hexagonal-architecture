using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;

namespace BookStore.Application.UseCases.Commands.CreateBook
{
    public class CreateBookHandler : ICreateBookHandler
    {
        private readonly IBookRepository _bookRepository;

        public CreateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Save(CreateBookCommand command)
        {
            var book = new Book(command.Name, command.Description, command.PublishCompany);
            _bookRepository.Save(book);
        }
    }
}
