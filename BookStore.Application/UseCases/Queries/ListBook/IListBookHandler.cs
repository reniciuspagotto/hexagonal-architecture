using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Application.UseCases.Queries.ListBook
{
    public interface IListBookHandler
    {
        IEnumerable<Book> GetAll();
    }
}
