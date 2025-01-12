namespace Assignment5
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
            Person[] people = new Person[3];
            
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Enter a name for person {i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter age for person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                people[i] = new Person(name, age);
            }

            PrintPersonArray(people);
        }

        void PrintPersonArray(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}: \n");
                people[i].DisplayPersonInfo();
            }
        }
    }
}
