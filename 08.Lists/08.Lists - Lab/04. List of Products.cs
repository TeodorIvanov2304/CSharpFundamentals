using System.Xml.Linq;

namespace _04._List_of_Products
{
    internal class ListOfProducts
    {
        static void Main(string[] args)
        {
            //Read a number n and n lines of products.Print a numbered list of all the products ordered by name.

            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for(int i = 0; i < n; i++) 
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}"); //Правим го на i + 1 иначе излиза от листа
            }
            
        }
    }
}