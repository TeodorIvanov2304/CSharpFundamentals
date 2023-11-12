namespace _05._Multiply_Big_Number_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            string multipliyNumber = Console.ReadLine();
            Console.WriteLine(MultiplyBigNumber(bigNumber, multipliyNumber));

        }

        public static string MultiplyBigNumber(string bigNumber, string multipliyNumber)
        {
            if (bigNumber == "0" || multipliyNumber == "0")
            {

                return "0";
            }
            int carry = 0;
            int multiplier = int.Parse(multipliyNumber);

            char[] resultChars = new char[bigNumber.Length + 1];

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int product = digit * multiplier + carry;

                resultChars[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }

            if (carry > 0)
            {
                resultChars[0] = (char)(carry + '0');
            }

            return new string(resultChars).TrimStart('\0');
        }
    }
}