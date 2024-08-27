using ClassLibrary;

namespace BookLibraryApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("---- Book library ----");
                Console.WriteLine("Choose your option from the menu:");
                Console.WriteLine("1. List all books");
                Console.WriteLine("2. Add new book to library");
                Console.WriteLine("3. Exit program");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        library.ListBooks();
                        break;
                    case "2":
                        AddNewBook(library);
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid data!");
                        break;
                }


            }

        }
        static void AddNewBook(Library library)
        {
            Console.WriteLine("Enter book title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author's Firstname: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Author's Lastname: ");
            string lname = Console.ReadLine();

            Author author = new Author(fname, lname);
            Book newBook = new Book(title, author);
            library.addBook(newBook);

        }
    }

}