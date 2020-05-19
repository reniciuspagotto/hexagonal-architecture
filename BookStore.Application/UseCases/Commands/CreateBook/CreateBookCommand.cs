namespace BookStore.Application.UseCases.Commands.CreateBook
{
    public class CreateBookCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PublishCompany { get; set; }
    }
}
