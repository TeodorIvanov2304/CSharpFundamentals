namespace _02._Common_Elements
{
    internal class CommonElementsIntersect
    {
        static void Main(string[] args)
        {
            //Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            //Четене на string масив от конзолата
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            //Сравняване на двата масива с метода Intersect
            string[] matchingWords = firstArray.Intersect(secondArray).ToArray();

            //Изпечатване с foreach
            foreach (string word in matchingWords) 
            {
                Console.Write($"{word} ");
            }
                                  
        }
    }
}