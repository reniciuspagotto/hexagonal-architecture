using BookStore.Domain.Entities;

namespace BookStore.Domain.Repositories
{
    public interface IBookRepository
    {
        void Save(Book data);
    }
}
