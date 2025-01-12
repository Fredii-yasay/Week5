namespace Assignment7
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
            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter amount of grades to process: ");
            string input = Console.ReadLine();
            int size = int.Parse(input);

            int[] grades = new int[size];
            Student student = new Student(name, grades);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter grade {i+1}: ");
                string number = Console.ReadLine();
                int grade = int.Parse(number);
                grades[i] = grade;
            }
            student.DisplayGrades();
        }
    }
}
