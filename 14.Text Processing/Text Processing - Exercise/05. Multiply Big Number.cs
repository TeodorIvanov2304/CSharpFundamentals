using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            double multiplier = double.Parse(Console.ReadLine());
            //Тук имаше проблем, когато множителя = 0, изкарваше n * 0 напр. 000000000
            if (multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int carry = 0;
            StringBuilder sum = new StringBuilder();

            while (number.Length > 0)
            {

                double currentNumber = char.GetNumericValue(number.Last());

                double currentMultyplication = currentNumber * multiplier + carry;
                carry = 0;
                if (currentMultyplication >= 10)
                {
                    carry = (int)currentMultyplication / 10;
                    currentMultyplication = currentMultyplication % 10;

                }
                sum.Insert(0, currentMultyplication);
                number = number.Remove(number.Length - 1);

            }

            if (carry > 0)
            {
                sum.Insert(0, carry);

            }
            Console.WriteLine(sum);
        }
    }
}