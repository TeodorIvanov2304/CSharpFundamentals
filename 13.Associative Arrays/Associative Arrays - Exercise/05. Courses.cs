namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string courseAndName = "";

            while ((courseAndName = Console.ReadLine()) != "end") 
            {
                string[] courseTokens = courseAndName.Split(" : ");
                string courseName = courseTokens[0];
                string student = courseTokens[1];

                //Add course and student
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(student);
                }
                //Add student, if the course already exists
                else
                {
                    courses[courseName].Add(student);
                }

            }

            foreach (KeyValuePair<string,List<string>> course in courses) 
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (string student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}