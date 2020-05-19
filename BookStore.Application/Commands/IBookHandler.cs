namespace BookStore.Application.Commands
{
    public interface IBookHandler
    {
        void Save(CreateBookCommand command);
    }
}
