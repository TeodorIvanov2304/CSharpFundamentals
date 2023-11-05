
namespace _06._Student_Academy_Map_Only
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>
                    {
                        grade
                    };
                }
                else
                {
                    students[name].Add(grade);
                }

            }

            var filteredStudents = students.Where(g => g.Value.Average() >= 4.50);

            foreach (KeyValuePair<string,List<double>> student in filteredStudents) 
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}