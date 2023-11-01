namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Четем масив от числа от конзолата
            double[] numbers = Console.ReadLine()
                            .Split()
                            .Select(double.Parse)
                            .ToArray();

            //Създаваме променлива сортиран речник, с ключ double, и стойност doulbe
            SortedDictionary<double, double> numberOccurrences = new SortedDictionary<double, double>();

            //Пускаме цикъл, който върти по дължината на масива numbers
            for (int i = 0; i < numbers.Length; i++)
            {   
                //Създаваме променлива, която ще пази текущото чиспо
                double currentNumber = numbers[i];

                //Проверяваме дали currentNumber(ключа) съществува в речника, ако не го добавяме и добавяме едно към стойността му(колко пъти е срещано)
                if (!numberOccurrences.ContainsKey(currentNumber))
                {
                    numberOccurrences[currentNumber] = 1;
                }

                //Ако вече е срещано, добавяме 1 към стойността(value), която пази колко пъти сме срещали ключа
                else
                {
                    numberOccurrences[currentNumber]++;
                }
            }

            //Изпечатваме с foreach, като като тип добавяме default-ният клас KeyValuePair
            foreach(KeyValuePair<double, double> item in numberOccurrences)
            {
                //Достъпваме пропъртитата на обектите в dictionary-то с item.Key, item.Value
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}