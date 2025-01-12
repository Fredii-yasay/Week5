using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class VotingSystem
    {
        public VoteOption[] votes;
        public int[] count;

        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
        }

        public void CastVote(VoteOption vote)
        {
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] == VoteOption.Yes)
                {
                    count[0]++;
                }
                else if (votes[i] == VoteOption.No)
                {
                    count[1]++;
                }
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Results:\n" +
                $"Yes: {count[0]}\n" +
                $"No: {count[1]}");
        }
    }
}
