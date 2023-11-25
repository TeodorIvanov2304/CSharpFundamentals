using System.Transactions;

namespace _01._Activation_Keys_2nd_Variant
{
    
    internal class Program
    {
        private static void Slice(int startIndex, int endIndex)
        {
            string firstPart = activationKey.Substring(0, startIndex);
            string secondPart = activationKey.Substring(endIndex);
            //Синтаксисът одолу замества този - activationKey = firstPart + secondPart;
            activationKey = $"{firstPart}{secondPart}";
            Console.WriteLine(activationKey);
        }

        public static void FlipToLower(int startIndex, int endIndex)
        {
            string prefix = activationKey.Substring(0, startIndex);
            string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
            string sufix = activationKey.Substring(endIndex);
            activationKey = prefix + middle + sufix;
            Console.WriteLine(activationKey);
        }

        public static void FlipToUpper(int startIndex, int endIndex)
        {
            string prefix = activationKey.Substring(0, startIndex);
            //Директно му подаваме string функцията toUpper();
            string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
            //Даваме му само стартиращият индек endIndex, защото има override който хваща автоматично до края вместо да пиша (endIndex, activationKey.Length)
            //
            string sufix = activationKey.Substring(endIndex);
            activationKey = prefix + middle + sufix;
            Console.WriteLine(activationKey);
        }

        public static void Contains(string substring)
        {
            if (activationKey.Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");
            }
            else
            {
                Console.WriteLine($"Substring not found!");
            }
        }

        //Изкарваме activationKey като статичен член(static member) , за да можем да го достъпваме от всички методи и за да не е нужно да го подаваме на метода Contains. Така се контролира директно, и не е нужно да се подава и връща от методите. Обърни внимание, как activationKey свети в бяло, а не в синьо.

        static string activationKey;
        static void Main(string[] args)
        {
            activationKey = Console.ReadLine();
            string input = "";
            while ((input = Console.ReadLine()) != "Generate") 
            {
                string[] arguments = input.Split(">>>").ToArray();
                string command = arguments[0];

                switch (command) 
                {
                    case "Contains":
                        string substring = arguments[1];
                        Contains(substring);
                        break;
                    case "Flip":
                        string letterType = arguments[1];
                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]);

                        if (letterType == "Upper")
                        {   
                            
                            FlipToUpper(startIndex, endIndex);
                        }
                        else
                        {
                            FlipToLower(startIndex, endIndex);
                        }
                        break;
                    case "Slice":
                        startIndex = int.Parse(arguments[1]);
                        endIndex = int.Parse(arguments[2]);
                        Slice(startIndex, endIndex);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        
    }
}