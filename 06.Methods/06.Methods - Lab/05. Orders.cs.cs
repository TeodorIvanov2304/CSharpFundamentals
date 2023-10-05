using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace _05._Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            //Create a program that calculates and prints the total price of an order.The method should receive two parameters:
            //• A string, representing a product -"coffee", "water", "coke", "snacks"
            //• An integer, representing the quantity of the product
            //The prices for a single item of each product are:
            //• coffee – 1.50
            //• water – 1.00
            //• coke – 1.40
            //• snacks – 2.00
            //Print the result, rounded to the second decimal place.

            //Четем входа от конзолата
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            //Извикваме метода за смятане на поръчката
            CalculateOrders(product, quantity);

            
        }

        static void CalculateOrders(string product, int quantity) // Изчислява цената на поръчката
        {   
            //Създаваме променлива, която пази крайната цена
            double price = 0;

            //Създаваме switch, който върти вида продукт и изчиславаме крайнтата цената по формулата
            //цена * количество = крайна цена
            switch (product) 
            {
                case "coffee": price = quantity * 1.50;
                    break;
                case "water": price = quantity * 1.00;
                    break;
                case "coke": price = quantity * 1.40;
                    break;
                case "snacks": price = quantity * 2.00;
                    break;

            }

            //Изпечатваме крайната цена, форматирана до 2 знака след "."
            Console.WriteLine($"{price:F2}");
        }
    }
}