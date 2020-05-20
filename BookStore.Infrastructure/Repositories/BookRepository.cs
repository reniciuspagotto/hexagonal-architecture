using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _dataContext.Books.ToListAsync();
        }

        public async Task Save(Book data)
        {
            await _dataContext.Books.AddAsync(data);
            await _dataContext.SaveChangesAsync();
        }
    }
}
