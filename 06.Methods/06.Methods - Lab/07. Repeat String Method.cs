namespace _07._Repeat_String
{
    internal class RepeatString
    {
        static void Main(string[] args)
        {
            // Create a method that receives two parameters:
            //• A string
            //• A number n(integer) represents how many times the string will be repeated
            //The method should return a new string, containing the initial one, repeated n times without space.

            //Четем string-ът който ще повтаряме от конзолата
            string str = Console.ReadLine();

            //Четем колко пъти ще го повтаряме
            int numberOfRepeats = int.Parse(Console.ReadLine());

            //Повикваме метода, която ще повтаря стринговете, и подаваме параметрите в скоби
            LoopAndConcatenateStrings(str, numberOfRepeats);
        }

        //Метод, който ще повтаря стринга n пъти
        private static void LoopAndConcatenateStrings(string str, int numberOfRepeats)
        {
            for (int i = 0; i < numberOfRepeats; i++)
            {
                PrintStringWithoutSpace(str);
            }
        }

        //Метод, който ще изечатва стринка без спейсове
        static void PrintStringWithoutSpace(string str)
        {
            Console.Write(str);
        }
    }
}