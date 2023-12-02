using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Family
{
    private List<Person> members;

    public Family()
    {
        members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public Person GetOldestMember()
    {
        return members.OrderByDescending(p => p.Age).FirstOrDefault();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new Person(name, age);
            family.AddMember(person);
        }

        Person oldestMember = family.GetOldestMember();

        if (oldestMember != null)
        {
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}