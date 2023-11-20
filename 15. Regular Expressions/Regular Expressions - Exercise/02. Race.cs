using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //Четем от конзолата имената на участниците, разделени с ","
            string[] names = Console.ReadLine().Split(", ").ToArray();

            //Създаваме променлива речник, с ключ string и стойност double, която ще пази името на участника и изминатото от него разстояние
            Dictionary<string, double> participants = new Dictionary<string, double>();

            //Добавяме всчки имена от масива като ключове, а за разстояние слагаме първоначално 0
            foreach (string name in names)
            {
                participants.Add(name, 0);
            }

            //Създаваме regex pattern, който хваща всички символи, освен буквите
            string letterPattern = @"[\W\d]";
            //Създаваме regex pattern, който хваща всички символи, освен цифрите
            string numberPattern = @"[\D]";

            //Четем участници, докато не получим end race
            string input = "";
            while ((input = Console.ReadLine()) != "end of race")
            {
                //Създаваме променлива, която пази името. За да го получим, използваме Regex.Replace(вход, буквен шаблон, ""). Така в стринга остава името
                string name = Regex.Replace(input, letterPattern, "");

                //По същия начин, само че с цифрите
                string numbers = Regex.Replace(input, numberPattern, "");
                //Създаваме променлива, която пази разстоянието на конкретния участник
                double distance = 0;

                //Пускаме цикъл, за да съберем всички цифри, съдържащи се в string numbers
                for (int i = 0; i < numbers.Length; i++)
                {
                    char currentNumber = numbers[i];
                    distance += char.GetNumericValue(currentNumber);
                }

                //Ако участникът е в списъка, добавяме изминатото разстояние към резултата му
                if (participants.ContainsKey(name))
                {
                    participants[name] += distance;
                }
            }

            // Създаваме List<KeyValuePair<string, double>> променлива, в която ще филтрираме участниците по низходящ ред
            var filtered = participants.OrderByDescending(x => x.Value).ToList();

            //Изпечатваме имената на първите 3-ма участници
            Console.WriteLine($"1st place: {filtered[0].Key}");
            Console.WriteLine($"2nd place: {filtered[1].Key}");
            Console.WriteLine($"3rd place: {filtered[2].Key}");

        }
    }
}