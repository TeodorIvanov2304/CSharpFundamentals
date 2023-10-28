namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split();
                string name = inputTokens[0];
                string id = inputTokens[1];
                int age = int.Parse(inputTokens[2]);

                Student student = new Student(name, id, age);
                students.Add(student);
            }

            List<Student> orederedStudents = students.OrderBy(x=>x.Age).ToList();

            foreach (Student student in orederedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {   
        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age{ get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}