using System.ComponentModel;

namespace _03._Orders
{
    class Product
    {
        public Product(string name, decimal price, decimal quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        //Създаваме метод, който ще актуализира цената
        public void Update(decimal price, decimal quantity) 
        {
            Price = price;
            Quantity += quantity;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            Dictionary<string,Product> keyValuePairs = new Dictionary<string, Product>();
            string products = "";

            while ((products = Console.ReadLine()) != "buy") 
            {
                string[] productsTokens = products.Split();
                string name = productsTokens[0];
                decimal price = decimal.Parse(productsTokens[1]);
                decimal quantity = decimal.Parse(productsTokens[2]);

                Product product = new Product(name, price, quantity);

                if (!keyValuePairs.ContainsKey(product.Name))
                {
                    keyValuePairs.Add(product.Name,product);
                }
                else
                {
                    keyValuePairs[name].Update(product.Price, product.Quantity);
                }
            }

            foreach (KeyValuePair<string,Product> product in keyValuePairs) 
            {

                Console.WriteLine($"{product.Value.Name} -> {product.Value.Price * product.Value.Quantity}");
                
            }
        }
    }

    
}