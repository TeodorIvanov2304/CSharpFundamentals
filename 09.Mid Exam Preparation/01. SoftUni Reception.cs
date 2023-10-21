namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte employee1Efficiency = byte.Parse(Console.ReadLine());
            byte employee2Efficiency = byte.Parse(Console.ReadLine());
            byte employee3Efficiency = byte.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());
            int allEmployeesWork = employee1Efficiency + employee2Efficiency + employee3Efficiency;
            int hoursCount = 0;

            while (studentsCount > 0) 
            {
                hoursCount++;
                if (hoursCount % 4 == 0 && hoursCount >0)
                {
                    
                    continue;
                }
                
                studentsCount -= allEmployeesWork;
                
            }

            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}