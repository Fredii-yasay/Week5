namespace Assignment2
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
            Console.WriteLine("Enter a day of the week: ");
            string input = Console.ReadLine();

            switch(Enum.Parse(typeof(Day.Days), input))
            {
                case Day.Days.Monday:
                    Console.WriteLine("Back to school...");
                    break;

                case Day.Days.Tuesday:
                    Console.WriteLine("Still in school...");
                    break;

                case Day.Days.Wednesday:
                    Console.WriteLine("Halfway there...");
                    break;

                case Day.Days.Thursday:
                    Console.WriteLine("Almost there...");
                    break;

                case Day.Days.Friday:
                    Console.WriteLine("End of school! Yay!");
                    break;

                case Day.Days.Saturday:
                    Console.WriteLine("Weekend Extravaganze!");
                    break;

                case Day.Days.Sunday:
                    Console.WriteLine("Weekend ended too fast...");
                    break;
            }
        }
    }
}
