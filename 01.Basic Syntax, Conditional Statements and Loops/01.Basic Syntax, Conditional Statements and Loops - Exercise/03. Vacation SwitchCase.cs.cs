using System;

namespace _03._Vacation_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double sum = 0;
            double dayPrice = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    {
                        switch (dayOfWeek)
                        {
                            case "Friday":
                                sum = numberOfPeople * 8.45;

                                if (numberOfPeople >= 30)
                                {
                                    sum = sum * 0.85;
                                }
                                break;
                            case "Saturday":
                                sum = numberOfPeople * 9.80;


                                if (numberOfPeople >= 30)
                                {
                                    sum = sum * 0.85;
                                }
                                break;
                            case "Sunday":
                                sum = numberOfPeople * 10.46;

                                if (numberOfPeople >= 30)
                                {
                                    sum = sum * 0.85;
                                }
                                break;
                        }

                        break;
                    }
            }
            switch (typeOfGroup)
            {
                case "Business":
                    {
                        switch (dayOfWeek)
                        {
                            case "Friday":
                                dayPrice = 10.90;
                                sum = numberOfPeople * 10.90;
                                if (numberOfPeople >= 100)
                                {
                                    sum = sum - 10 * dayPrice;
                                }
                                break;
                            case "Saturday":
                                dayPrice = 15.60;
                                sum = numberOfPeople * 15.60;
                                if (numberOfPeople >= 100)
                                {
                                    sum = sum - 10 * dayPrice;
                                }
                                break;
                            case "Sunday":
                                dayPrice = 16;
                                sum = numberOfPeople * 16;
                                if (numberOfPeople >= 100)
                                {
                                    sum = sum - 10 * dayPrice;
                                }

                                break;

                        }
                        break;
                    }
            }
            switch (typeOfGroup)
            {
                case "Regular":
                    {
                        switch (dayOfWeek)
                        {
                            case "Friday":
                                sum = numberOfPeople * 15;

                                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                                {
                                    sum = sum * 0.95;
                                }
                                break;
                            case "Saturday":
                                sum = numberOfPeople * 20;


                                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                                {
                                    sum = sum * 0.95;
                                }
                                break;
                            case "Sunday":
                                sum = numberOfPeople * 22.50;

                                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                                {
                                    sum = sum * 0.95;
                                }
                                break;
                        }

                        break;
                    }

            }
            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}