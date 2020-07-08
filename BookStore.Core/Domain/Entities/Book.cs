namespace BookStore.Core.Domain.Entities
{
    public class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public string PublishingCompany { get; private set; }

        public Book(string name, string author, string description, string category, string publishingCompany)
        {
            Name = name;
            Author = author;
            Description = description;
            Category = category;
            PublishingCompany = publishingCompany;
        }
    }
}
