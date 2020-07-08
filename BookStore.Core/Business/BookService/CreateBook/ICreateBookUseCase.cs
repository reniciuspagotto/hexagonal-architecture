using System;
using System.Threading.Tasks;

namespace BookStore.Core.Business.BookService.CreateBook
{
    public interface ICreateBookUseCase
    {
        Task<CreateBookOutput> Execute(CreateBookInput data);
    }
}
