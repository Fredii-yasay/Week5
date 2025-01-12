namespace Assignment3
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
            int[] numbers = new int[3];

            InsertIntegers(numbers);

            int sum = CalculateSum(numbers);
            double average = CalculateAverage(numbers);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }

        void InsertIntegers(int[] numbers)
        {
            Console.WriteLine("Enter 3 integers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                string input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }
        }

        int CalculateSum(int[] numbers)
        {
            int sum = 0;

            for (int i = 0;i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum; 
        }

        double CalculateAverage(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return (double)sum / (double)numbers.Length;


        }
    }
}
