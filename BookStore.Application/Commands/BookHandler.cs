using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;

namespace BookStore.Application.Commands
{
    public class BookHandler : IBookHandler
    {
        private readonly IBookRepository _bookRepository;

        public BookHandler(IBookRepository bookRepository)
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
