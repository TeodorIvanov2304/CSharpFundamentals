namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] twoStrings = Console.ReadLine()
                                  .Split();
            int sum = MultiplyChars(twoStrings);
            Console.WriteLine(sum);
        }

        //MULTIPLY CHARS
        public static int MultiplyChars(string[] twoStrings)
        {
            string string1 = twoStrings[0];
            string string2 = twoStrings[1];
            //Намираме по-дългият стринг
            int maxIndex = Math.Max(string1.Length, string2.Length);
            int sum = 0;

            //Пускаме for цикъл по дължината на по-дългия стринг
            for (int i = 0; i < maxIndex; i++)
            {

                //Ако i е по-малко от двете дължини
                if (i < string1.Length && i < string2.Length)
                {
                    sum += string1[i] * string2[i];
                }
                //Ако е по-голямо от първата дължина
                else if (i < string1.Length)
                {
                    sum += string1[i];
                }
                //Ако е по-голямо от втората дължина
                else if (i < string2.Length)
                {
                    sum += string2[i];
                }

            }

            return sum;
        }
    }
}