using System.Linq;

namespace _06._Student_Academy
{   
    class Student
    {   
        //Отново бях забравил да задам нов лист на конструктора
        public Student(string name)
        {
            Name = name;
            Grades = new List<double>();
        }

        public string Name { get; set; }
        public new List<double> Grades { get; set; }

        //Смятаме Average направо в override метода, за List<double> grades
        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                
                if (!students.ContainsKey(name))
                {   
                    // Създаваме нов студент, с име и обект студетнт с име
                    students.Add(name, new Student(name));
                }
                students[name].Grades.Add(grade);
                
            }

            //Бях го направил на Dictionary<string, Student>, а трябва да е var!!!
            var filteredStudents = students.Where(s => s.Value.Grades.Average() >= 4.5);

            foreach (KeyValuePair<string,Student> kvp in filteredStudents)
            {
                Console.WriteLine(kvp.Value);
                
            }
        }
    }
}