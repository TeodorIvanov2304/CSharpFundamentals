namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use the class from the previous problem.If you receive a student, which already exists(first name and last name should be unique) overwrite the information.

       
            List<Student> studentList = new List<Student>();
            string information = "";

            while ((information = Console.ReadLine()) != "end") 
            {
                string[] infoTokens = information.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = infoTokens[0];
                string lastName = infoTokens[1];
                int age = int.Parse(infoTokens[2]);
                string city = infoTokens[3];

                //Проверяваме, дали студента съществува, ако да - заместваме го
                if (IsStudentExisting(studentList, firstName, lastName))
                {
                    Student student = GetStudent(studentList, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                //Ако не, създаваме нов
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };
                    studentList.Add(student);
                }
            }

            string filterCity = Console.ReadLine();

            //Изпечатваме с foreach
            foreach (Student student in studentList)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }



        }
        //Проверяваме дали студент с такива имена вече съществува
        static bool IsStudentExisting(List<Student> studentList, string firstName, string lastName)
        {
            foreach (Student student in studentList) 
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        //Проверява за ученика със същото име и го връща, ако съществува
        static Student GetStudent(List<Student> studentList, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach(Student student in studentList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}