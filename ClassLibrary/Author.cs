namespace ClassLibrary
{
    public class Author
    {
        public int id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private static int genId = 1;

        public Author(string fname, string lname)
        {
            id = genId++;
            Firstname = fname;
            Lastname = lname;

        }
    }
}
