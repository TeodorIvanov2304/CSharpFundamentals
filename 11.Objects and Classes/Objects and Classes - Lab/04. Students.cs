/*
 Define a class called Student, which will hold the following information about some students: 
•	first name
•	last name
•	age
•	home town
Input / Constraints
Read information about some students, until you receive the "end" command. After that, you will receive a city name.
Output
Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."
 */
namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създаваме лист от тип Student
            List<Student> studentList = new List<Student>();
            //Създаваме стринг променлива, от който ще четем информация
            string information = "";

            //Създаваме цикъл, който ще върти докато не получим end команда
            while ((information = Console.ReadLine()) != "end")
            {
                //Създаваме променлива масив, в която пазим разложения стринг
                string[] infoTokens = information.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Създаваме променливи, които пазят частите от стринг information
                string firstName = infoTokens[0];
                string lastName = infoTokens[1];
                int age = int.Parse(infoTokens[2]);
                string city = infoTokens[3];

                //Присвояваме частите от стринг information на обекта-инстанция от клас Студент
                //Първо име, второ име, възраст и град
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };
                studentList.Add(student);
            }

            //Създаваме стринг, който ще пази града, по който ще филтрираме
            string filterCity = Console.ReadLine();

            //Изпечатваме с foreach
            foreach (Student student in studentList)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

            //Алтернатива на изпечатването с foreach
            //С метода Where филтрираме по град x => x.City == filterCity
            //List<Student> filteredStudents = studentList
            //                                 .Where(x => x.City == filterCity)
            //                                 .ToList();
            //foreach (Student student in studentList)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

            //}
        }
    }

    //Клас Student
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}