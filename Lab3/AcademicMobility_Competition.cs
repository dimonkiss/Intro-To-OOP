using System;
using System.Linq;

namespace Lab3
{
    public partial class AcademicMobility
    {
        public void ConductCompetition(Student[] candidates)
        {

            var sortedCandidates = candidates.OrderByDescending(student => student.Rating).ToArray();

            // Selecting the best candidates (e.g., top 10)
            int numberOfWinners = Math.Min(10, sortedCandidates.Length);

            Console.WriteLine("The winners of the competition are:");

            for (int i = 0; i < numberOfWinners; i++)
            {
                Console.WriteLine($"{sortedCandidates[i].Name} {sortedCandidates[i].Surname}");
            }
        }
    }
}