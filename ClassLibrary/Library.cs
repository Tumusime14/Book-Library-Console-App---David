namespace ClassLibrary
{
    public class Library
    {
        readonly List<Book> books = new List<Book>();
        public Library()
        {
            books = new List<Book>
            {
                new Book("Mobby Dick", new Author("Herman","Merville")),
                new Book("Pride and Prejudice", new Author("Jane", "Austin"))
            };

        }
        public void addBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book is successful recorded!");
        }
        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library is empty.");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"{book}");
                }
                Console.WriteLine();
            }
        }
    }
}
