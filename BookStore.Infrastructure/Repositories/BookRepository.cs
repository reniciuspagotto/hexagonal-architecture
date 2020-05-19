using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using BookStore.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        protected readonly DataContext _dataContext;

        public BookRepository(DataContext dbContext)
        {
            _dataContext = dbContext;
        }

        public IEnumerable<Book> GetAll()
        {
            return _dataContext.Books.ToList();
        }

        public void Save(Book data)
        {
            _dataContext.Books.Add(data);
            _dataContext.SaveChanges();
        }
    }
}
