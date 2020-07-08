using BookStore.Core.Domain.Entities;
using BookStore.Core.Repositories;
using BookStore.Infrastructure.Context;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        protected readonly DataContext _dataContext;

        public BookRepository(DataContext dbContext)
        {
            _dataContext = dbContext;
        }

        public async Task Save(Book data)
        {
            await _dataContext.Books.AddAsync(data);
            await _dataContext.SaveChangesAsync();
        }
    }
}
