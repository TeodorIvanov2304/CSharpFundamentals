namespace _02._Common_Elements_Foreach
{
    internal class CommonElementsForeach
    {
        static void Main(string[] args)
        {
            //Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            foreach (string match in arrayTwo) 
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if(match == arrayOne[i])
                    {
                        Console.Write($"{match} ");
                        break;
                    }
                }
            }
        }
    }
}