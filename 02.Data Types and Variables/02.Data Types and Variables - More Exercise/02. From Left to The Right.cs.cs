namespace DEMO
{
    internal class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            //You will receive a number that represents how many lines we will get as input.On the next N lines, you will receive a string with 2 numbers, separated by a single space.You need to compare them.If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise, print the sum of all digits in the right number.

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                // We are using the method IndexOf(here is the symbol we are looking for, ' ')
                int spaceIndex = input.IndexOf(' ');

                if (spaceIndex != -1)
                {
                    // writing down the two numbers from string input in diff variables
                    string leftNumberString = input.Substring(0, spaceIndex);
                    string rightNumberString = input.Substring(spaceIndex + 1);

                    if (long.TryParse(leftNumberString, out long leftNumber) && long.TryParse(rightNumberString, out long rightNumber))
                    {
                        
                        long sum = 0;
                        // Comparing the number
                        if (leftNumber >= rightNumber)
                        {
                            
                            // cheking for negative sign on space 0
                            if (leftNumberString[0] == '-')
                            {
                                // adding up the numbers into the sum
                                for (int j = 1; j < leftNumberString.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(leftNumberString[j]);
                                    sum += nextNumber;
                                }
                            }
                            else
                                for (int j = 0; j < leftNumberString.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(leftNumberString[j]);
                                    sum += nextNumber;
                                }
                        }
                        else if (leftNumber <= rightNumber)
                        {
                            if (rightNumberString[0] == '-')
                            {
                                for (int j = 1; j < rightNumberString.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(rightNumberString[j]);
                                    sum += nextNumber;
                                }
                            }
                            else
                                for (int j = 0; j < rightNumberString.Length; j++)
                                {

                                    long nextNumber = (long)Char.GetNumericValue(rightNumberString[j]);
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