namespace _03._Take_or_Skip_Rope
{
    internal class TakeOrSkipRope
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> letters = new List<string>();
            List<int> numbers = new List<int>();

            //Определяме кое е число, и кое не е и ги добавяме в отделни листове
            for (int i = 0; i < input.Length; i++)
            {
                bool isANumber = "1234567890".Contains(input[i]);

                if (isANumber) 
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    char letter = input[i];
                    letters.Add(letter.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            //Отделяме в два отделни листа числата на четните и нечетните позиции
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = "";
            int skip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {   
                //Създаваме помощен лист, който съдържа буквите
                List<string> temp = new List<string>(letters);
                //Презаписваме temp с функциите Spip и Take()
                temp = temp.Skip(skip).Take(takeList[i]).ToList();
                result += string.Join("",temp);
                skip += takeList[i] + skipList[i];
            }

            Console.WriteLine(result);
        }
    }
}