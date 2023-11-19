using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace _01._Furniture
{   
    // Създаваме клас Furniture с пропъртита Име, Цена, Количество и метод, който смята TotalPrice
    class Furniture
    {
        

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal GetTotal() 
        {
            return Price * Quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Създаваме променлива, която пази шаблона от regex101
            string pattern = @">>([A-Z]+[a-z]*)<<([+-]?[0-9]*[.]?[0-9]+)!(\d+)\b";
            //Създаваме regex променлива
            Regex regex = new Regex(pattern);
            //Създаваме лист от тип Furniture
            List<Furniture> furnitures = new List<Furniture>();
            //Четен вход, докато не получим команда Purchase
            string input = "";
            while ((input = Console.ReadLine()) != "Purchase") 
            {   

                //Пускаме foreach цикъл, който върти през всеки лист от тип Match, който съвпада с метода
                // на статичния клас Regex, Matches, на който подаваме input и pattern
                //Метода проверява, дали има съвпадения на шаблона(pattern)
                foreach (Match match in Regex.Matches(input, pattern))
                {   
                    //Създаване нов обект от тип Furniture
                    Furniture furniture = new Furniture();
                    //За име приравняваме стойността на 1-вата regex101 група match.Groups[1].Value 
                    furniture.Name = match.Groups[1].Value;
                    //За цена приравняваме втората група, като парсваме
                    furniture.Price = decimal.Parse(match.Groups[2].Value);
                    //За количество добавяме третата група
                    furniture.Quantity = int.Parse(match.Groups[3].Value);

                    //Добавяме към листа от обекти тип Furniture
                    furnitures.Add(furniture);
                }
            }

            //Създаваме променлива, която пази общата цена
            decimal totalCost = 0;
            //Изпечатваме първия ред на изхода
            Console.WriteLine("Bought furniture:");
            //Изпечатваме мебелите с foreach
            foreach (Furniture furniture in furnitures)
            {   
                Console.WriteLine(furniture.Name);
                //За всеки обект правим метода тотал
                totalCost += furniture.GetTotal(); 
            }

            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }
    }
}