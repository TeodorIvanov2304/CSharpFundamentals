namespace DEMO
{
    internal class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                // We are using the method IndexOf(here is the symbol we are looking for, ' ')
                int spaceIndex = input.IndexOf(' ');

                if (spaceIndex != -1)
                {
                    // writing down the two numbers from string input in diff variables
                    string number1Str = input.Substring(0, spaceIndex);
                    string number2Str = input.Substring(spaceIndex + 1);

                    if (long.TryParse(number1Str, out long number1) && long.TryParse(number2Str, out long number2))
                    {
                        
                        long sum = 0;
                        // Comparing the number
                        if (number1 >= number2)
                        {
                            
                            // cheking for negative sign on space 0
                            if (number1Str[0] == '-')
                            {
                                // adding up the numbers into the sum
                                for (int j = 1; j < number1Str.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(number1Str[j]);
                                    sum += nextNumber;
                                }
                            }
                            else
                                for (int j = 0; j < number1Str.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(number1Str[j]);
                                    sum += nextNumber;
                                }
                        }
                        else if (number1 <= number2)
                        {
                            if (number2Str[0] == '-')
                            {
                                for (int j = 1; j < number2Str.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(number2Str[j]);
                                    sum += nextNumber;
                                }
                            }
                            else
                                for (int j = 0; j < number2Str.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(number2Str[j]);
                                    sum += nextNumber;
                                }
                        }
                        Console.WriteLine(sum);

                    }
                }
            }

        }
    }
}