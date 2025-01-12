namespace Assignment6
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
            Console.WriteLine("How many votes would you like to process? ");
            string process = Console.ReadLine();
            int size = int.Parse(process);

            VotingSystem votes = new VotingSystem(size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Cast your vote(Yes/No): ");
                string input = Console.ReadLine();
                Console.WriteLine($"Vote Casted: {input}");

                votes.CastVote((VoteOption)Enum.Parse(typeof(VoteOption), input));
            }

            votes.DisplayResults();
        }
    }
}
