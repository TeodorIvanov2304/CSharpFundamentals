using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double price = 0;
            double initalBalance = balance;
            string input = Console.ReadLine();
            bool flag = false;
            while (input != "Game Time")
            {   
                
                switch (input)
                {
                    case "OutFall 4": price = 39.99;
                        break;
                    case "CS: OG": price = 15.99;
                        break;
                    case "Zplinter Zell": price = 19.99;
                        break;
                    case "Honored 2": price = 59.99;
                        break;
                    case "RoverWatch": price = 29.99;
                        break;
                    case "RoverWatch Origins Edition": price = 39.99;
                        break;
                    default:
                        flag = true;
                        Console.WriteLine("Not Found");
                        break;
                }
                
                if(price>balance)
                {
                    Console.WriteLine("Too Expensive");
                }
                if (balance >= price && !flag)
                {
                    balance -= price;
                    Console.WriteLine($"Bought {input}");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                flag = false;
                input = Console.ReadLine();
            }
            if(balance>0)
            {
                Console.WriteLine($"Total spent: ${initalBalance-balance:f2}. Remaining: ${balance:f2}");
            }
        }
        

    }
}