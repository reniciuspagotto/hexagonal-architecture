namespace BookStore.Application.UseCases.Commands.CreateBook
{
    public interface ICreateBookHandler
    {
        void Save(CreateBookCommand command);
    }
}
