namespace Assignment4
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

            Console.WriteLine("Enter book title: ");
            string title = Console.ReadLine();
            book.Title = title;

            Console.WriteLine("Enter book author: ");
            string author = Console.ReadLine();
            book.Author = author;

            book.DisplayBookInfo();
        }
    }
}
