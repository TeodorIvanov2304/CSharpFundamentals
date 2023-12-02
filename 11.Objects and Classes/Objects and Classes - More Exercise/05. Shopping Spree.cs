namespace _05._Shopping_Spree
{   
    class Product
    {
        public Product(string productName, int price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get; set; }
        public int Price { get; set; }
    }

    class Person
    {
        public Person(string name, int money, List<Product> bagOfProducts)
        {
            Name = name;
            Money = money;
            BagOfProducts = bagOfProducts;
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> bagOfProducts = new List<Product>();

            string peopleInfo = Console.ReadLine();
            string products = Console.ReadLine();
            string[] productsArgs = products
                                    .Split(";",StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            foreach (var item in productsArgs)
            {
                string[] productArgs = item
                                       .Split("=", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
                string productName = productArgs[0];
                int price = int.Parse(productArgs[1]);
                Product product = new Product(productName, price);
                bagOfProducts.Add(product);
            }

            string[] peopleAndMoney = peopleInfo
                                      .Split(";", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            List<Person> persons = new List<Person>();
            foreach (var person in peopleAndMoney)
            {
                string[] itemArgs = person
                                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                string name = itemArgs[0];
                int money = int.Parse(itemArgs[1]);
                Person newPerson = new Person(name, money, new List<Product>());
                persons.Add(newPerson);
            }

            string commands = "";
            while ((commands = Console.ReadLine()) != "END")
            {
                string[] commandsArgs = commands.Split().ToArray();
                string name = commandsArgs[0];
                string productName = commandsArgs[1];
                Product productToCheck = bagOfProducts.FirstOrDefault(x=>x.ProductName == productName);
                Person personToCheck = persons.FirstOrDefault(x=>x.Name == name);
                
                if (personToCheck != null && personToCheck != null) 
                {
                    if (personToCheck.Money >productToCheck.Price)
                    {
                        personToCheck.BagOfProducts.Add(productToCheck);
                        Console.WriteLine($"{personToCheck.Name} bought {productToCheck.ProductName}");
                    }
                    else
                    {
                        Console.WriteLine($"{personToCheck.Name} can't afford {productToCheck.ProductName}");
                    }
                }
            }

            foreach (var person in persons)
            {
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {   
                    //Добавяме продуктите от торбата в нов лист, иначе не могат да се изпечатат, или поне не се сетих как
                    List<string> productsNames = person.BagOfProducts.Select(p => p.ProductName).ToList();
                    Console.WriteLine($"{person.Name} - {string.Join(", ", productsNames)}");
                }
            }
        }
    }
}