using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using BookStore.Infrastructure.Context;

namespace BookStore.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        protected readonly DataContext _dataContext;

        public BookRepository(DataContext dbContext)
        {
            _dataContext = dbContext;
        }

        public void Save(Book data)
        {
            _dataContext.Books.Add(data);
            _dataContext.SaveChanges();
        }
    }
}
