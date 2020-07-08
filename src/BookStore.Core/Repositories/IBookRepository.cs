using BookStore.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories
{
    public interface IBookRepository
    {
        Task Save(Book data);
    }
}
