namespace BookStore.Core.Business.BookService.CreateBook
{
    public class CreateBookInput
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string PublishingCompany { get; set; }
    }
}