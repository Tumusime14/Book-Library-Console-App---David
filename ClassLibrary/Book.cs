namespace ClassLibrary
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; set; }
        public Author Author { get; set; }

        private static int UniqId = 1;

        public Book(string title, Author author)
        {
            Id = UniqId++;
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return ($"List of books avaiable: \n{Title} {Author.Firstname} {Author.Lastname} ");
        }

    }

}
