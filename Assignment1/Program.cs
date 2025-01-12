namespace Assignment1
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
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter width: ");
            string width = Console.ReadLine();
            rectangle.Width = double.Parse(width);

            Console.WriteLine("Enter height: ");
            string height = Console.ReadLine();
            rectangle.Height = double.Parse(height);

            Console.WriteLine($"Area = {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter = {rectangle.CalculatePerimeter()}");
        }
    }
}
