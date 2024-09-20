namespace ClassLibrary
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Book(string title, Author author)
        {
            Title = title;
            Author = author;
        }

    }

}
