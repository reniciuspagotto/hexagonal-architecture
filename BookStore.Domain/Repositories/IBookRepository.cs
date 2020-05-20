using BookStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Domain.Repositories
{
    public interface IBookRepository
    {
        Task Save(Book data);
        Task<IEnumerable<Book>> GetAll();
    }
}
