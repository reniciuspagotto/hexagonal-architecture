using BookStore.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Application.UseCases.Queries.ListBook
{
    public class ListBookHandler : IRequestHandler<ListBookCommand, object>
    {
        private readonly IBookRepository _bookRepository;

        public ListBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<object> Handle(ListBookCommand request, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetAll();
        }
    }
}
