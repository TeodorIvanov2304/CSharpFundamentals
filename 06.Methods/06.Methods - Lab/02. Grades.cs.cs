using System.Diagnostics;

namespace _02._Grades
{
    internal class Grades
    {
        static void Main(string[] args)
        {
            //Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
            //• 2.00 – 2.99 - "Fail"
            //• 3.00 – 3.49 - "Poor"
            //• 3.50 – 4.49 - "Good"
            //• 4.50 – 5.49 - "Very good"
            //• 5.50 – 6.00 - "Excellent"

            // Четем променливата grade 
            double grade = double.Parse(Console.ReadLine());

            //Подаваме grade като параметър на PrintGrade(параметър/grade);
            PrintGrade(grade); 

            //Четем нова променлива newGrade и я подаваме като нов параметър newGrade към същия метод
            double newGrade = double.Parse(Console.ReadLine());
            PrintGrade(newGrade);
        }

        static void PrintGrade(double grade)
        {
            //Logic for calculating result

            switch(grade) // Using switch-case for determining the grade 
            {
                case >= 2 and <= 2.99: // Използваме ключовата дума AND и така се използва bool в switch
                    Console.WriteLine("Fail");
                    break;
                case >= 3 and <= 3.49: // На края на реда се слагат 2-те точки
                    Console.WriteLine("Poor");
                    break;
                case >= 3.50 and <= 4.49:
                    Console.WriteLine("Good");
                    break;
                case >= 4.50 and <= 5.49:
                    Console.WriteLine("Very good");
                    break;
                case >= 5.50 and <= 6.00:
                    Console.WriteLine("Excellent");
                    break;
            }
        }
    }
}