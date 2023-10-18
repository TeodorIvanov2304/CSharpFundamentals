namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints you a receipt for your new computer.You will receive the parts' prices (without tax) until you receive what type of customer this is - special or regular. Once you receive the type of customer you should print the receipt.
            //The taxes are 20 % of each part's price you receive. 
            //If the customer is special, he has a 10 % discount on the total price with taxes.
            //If a given price is not a positive number, you should print "Invalid price!" on the console and continue with the next price.
            //If the total price is equal to zero, you should print "Invalid order!" on the console.

            string input = Console.ReadLine();
            double sum = 0;
            //bool isReady = input == "special" || input == "regular";
            while (input != "special" && input != "regular") 
            {
                
                double price = double.Parse(input);
                

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }

                if (price>0)
                {
                    sum += price;
                }
                
                input = Console.ReadLine();
            }

            double taxes = sum * 0.20;
            double totalSum = sum + taxes;
            if (input == "special")
            {
                totalSum = totalSum - (totalSum * 0.10);
            }
            if (totalSum > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:F2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
