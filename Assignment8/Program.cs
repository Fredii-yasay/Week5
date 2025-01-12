namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Book book = new Book();
            Console.WriteLine("How many books should there be in the library?");
            string input = Console.ReadLine();
            int capacity = int.Parse(input);

            Library library = new Library(capacity);

            for (int i = 0; i < library.books.Length; i++)
            {
                library.AddBook(book);
            }
        }
    }
}
