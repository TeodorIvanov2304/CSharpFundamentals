namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pirates are invading the sea, and you're tasked to help them plunder
            //Create a program that checks if target plunder is reached.First, you will receive how many days the pirating lasts.Then you will receive how much the pirates plunder for a day. Last you will receive the expected plunder at the end.
            //Calculate how much plunder the pirates manage to gather.Each day they gather the plunder.Keep in mind that they attack more ships every third day and add additional plunder to their total gain, which is 50 % of the daily plunder.Every fifth day the pirates encounter a warship, and after the battle, they lose 30 % of their total plunder.
            //If the gained plunder is more or equal to the target, print the following:
            //"Ahoy! {totalPlunder} plunder gained."
            //If the gained plunder is less than the target.Calculate the percentage left and print the following:
            //"Collected only {percentage}% of the plunder."
            //Both numbers should be formatted to the 2nd decimal place.

            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {

                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += (double)dailyPlunder / 2;
                }


                if (i % 5 == 0)
                {
                    totalPlunder = totalPlunder * 0.70;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = ((double)totalPlunder / (double)expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}