using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using System.Collections.Generic;

namespace BookStore.Application.UseCases.Queries.ListBook
{
    public class ListBookHandler : IListBookHandler
    {
        private readonly IBookRepository _bookRepository;

        public ListBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }
    }
}
