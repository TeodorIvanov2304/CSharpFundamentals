namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            List<Student> studentList = new List<Student>();
            int numberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] data = Console.ReadLine().Split();
                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);

                Student student = new Student(firstName, lastName, grade);
                studentList.Add(student);
            }

            List<Student> filteredStudents = studentList.OrderBy(student => student.Grade).ToList();
            filteredStudents.Reverse();

            foreach(Student student in filteredStudents) 
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Student
    {   
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}