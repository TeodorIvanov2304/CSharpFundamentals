using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if(day=="Friday")
            {
                if(groupType=="Students")
                {
                    price = people * 8.45;
                }
                else if(groupType=="Business")
                {
                    price = people * 10.90;
                }
                else
                {
                    price = people * 15;
                }
            }
            else if(day=="Saturday")
            {
                if (groupType == "Students")
                {
                    price = people * 9.80;
                }
                else if (groupType == "Business")
                {
                    price = people * 15.60;
                }
                else
                {
                    price = people * 20;
                }
            }
            else
            {
                if (groupType == "Students")
                {
                    price = people * 10.46;
                }
                else if (groupType == "Business")
                {
                    price = people * 16;
                }
                else
                {
                    price = people * 22.50;
                }
            }

            if(groupType == "Students"&& people>=30)
            {
                price = price - (price * 0.15);
                //price *=0.85;
            }
            if(groupType=="Business"&&people>=100)
            {
                if(day=="Friday")
                {
                    price = (people-10) * 10.90;
                }
                else if(day=="Saturday")
                {
                    price = (people - 10) * 15.60;
                }
                else
                {
                    price = (people - 10) * 16;
                }
            }
            if(groupType == "Business"&&(people>=10&&people<=20))
            {
                price = price - (price * 0.05);
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}