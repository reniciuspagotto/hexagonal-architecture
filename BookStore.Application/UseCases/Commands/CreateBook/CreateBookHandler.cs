using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Application.UseCases.Commands.CreateBook
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, object>
    {
        private readonly IBookRepository _bookRepository;

        public CreateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<object> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Name, request.Description, request.PublishCompany);
            await _bookRepository.Save(book);
            return request;
        }
    }
}
