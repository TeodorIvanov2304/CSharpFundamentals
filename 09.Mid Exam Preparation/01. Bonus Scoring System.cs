/*Create a program that calculates bonus points for each student enrolled in a course. On the first line, you are going to receive the number of students. On the second line, you will receive the total number of lectures in the course. The course has an additional bonus, which you will receive on the third line. On the following lines, you will be receiving the count of attendances for each student.
The bonus is calculated with the following formula:
{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
Find the student with the maximum bonus and print them, along with his attendance, in the following format:
"Max Bonus: {max bonus points}."
"The student has attended {student attendances} lectures."
Round the bonus points at the end to the nearest larger number.
*/
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