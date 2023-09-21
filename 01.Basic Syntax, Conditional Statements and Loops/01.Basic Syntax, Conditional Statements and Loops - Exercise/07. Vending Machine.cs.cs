using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = (Console.ReadLine());
            double accummulate = 0;
            double price = 0;
            double currentCoin = 0;
            while (coins != "Start")
            {
                currentCoin = double.Parse(coins);

                if (currentCoin == 0.1)
                {
                    accummulate = accummulate + currentCoin;
                }
                else if (currentCoin == 0.2)
                {
                    accummulate = accummulate + currentCoin;
                }
                else if (currentCoin == 0.5)
                {
                    accummulate = accummulate + currentCoin;
                }
                else if (currentCoin == 1)
                {
                    accummulate = accummulate + currentCoin;
                }
                else if (currentCoin == 2)
                {
                    accummulate = accummulate + currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }

                coins = Console.ReadLine();

            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "End")
                {
                    break;
                }
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        if (accummulate >= price)
                        {
                            accummulate = accummulate - price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        price = 0.7;
                        if (accummulate >= price)
                        {
                            accummulate = accummulate - price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        price = 1.5;
                        if (accummulate >= price)
                        {
                            accummulate = accummulate - price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        price = 0.8;
                        if (accummulate >= price)
                        {
                            accummulate = accummulate - price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        price = 1.0;
                        if (accummulate >= price)
                        {
                            accummulate = accummulate - price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
                
            }

            Console.WriteLine($"Change: {accummulate:F2}");
        }
    }
}