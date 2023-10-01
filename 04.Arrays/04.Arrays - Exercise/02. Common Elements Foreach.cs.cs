namespace _02._Common_Elements_Foreach
{
    internal class CommonElementsForeach
    {
        static void Main(string[] args)
        {
            //Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            //Четем двата string масива от конзолата
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            //Създаваме цикъл foreach, който върти по втория масив
            foreach (string match in arrayTwo) 
            {   

                //Създаваме втори for цикъл, който върти по дължината на първия масив
                for (int i = 0; i < arrayOne.Length; i++)
                {    
                    //Правим проверка, за да видим дали има съвпдащи елементи
                    if(match == arrayOne[i])
                    {   
                        //Ако има, ги изпечатваме на конзолата и brake-ваме итерацията
                        Console.Write($"{match} ");
                        break;
                    }
                }
            }
        }
    }
}
