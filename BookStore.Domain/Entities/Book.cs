namespace BookStore.Domain.Entities
{
    public class Book
    {
        public Book(string name, string description, string publishCompany)
        {
            Name = name;
            Description = description;
            PublishCompany = publishCompany;
        }

        public int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PublishCompany { get; private set; }
    }
}
