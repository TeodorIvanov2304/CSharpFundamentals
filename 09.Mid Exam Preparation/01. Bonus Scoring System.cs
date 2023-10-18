//{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAttendances = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double totalBonus = 0;
                totalBonus = ((double)attendances / (double)numberOfLectures) * (5 + additionalBonus);

                if (totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                }

                if (attendances> maxAttendances)
                {
                    maxAttendances = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {Math.Round(maxAttendances)} lectures.");
        }
    }
}