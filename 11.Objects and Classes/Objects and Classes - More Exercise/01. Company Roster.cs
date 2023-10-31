namespace _01._Company_Roster
{   
    class Employee
    {   
        public Employee(string name, decimal salary, string department) 
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"Highest Average Salary: {Department}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                decimal salary = decimal.Parse(data[1]);
                string department = data[2];

                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);

            }

            List<Employee> ordered = employees.OrderBy(e => e.Department).ToList();

            foreach (Employee employee in employees)
            {

            }
           
            //employees.GroupBy(x=>x.Department).Select(x=>x.Average(x=>x.Salary));
           
        }
    }
}