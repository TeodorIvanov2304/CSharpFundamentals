namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Създавме string , през който ще четем данните
            string data = "";
            //Създаваме лист от тип Box
            List<Box> boxes = new List<Box>();

            //Създаваме цикъл, който чете данни докато не поучи end
            while ((data = Console.ReadLine()) != "end") 
            {   

                //Създаваме масив, който ще пази сплитнатите данни
                string[] dataTokens = data.Split();
                //Създаваме променливи, в който ще пазим данните
                int serialNumber = int.Parse(dataTokens[0]);
                string itemName = dataTokens[1];
                int itemQuantity = int.Parse(dataTokens[2]);
                decimal itemPrice = decimal.Parse(dataTokens[3]);

                //Създаваме нов предмет и му записваме данните Name , Price
                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                //Създаваме нова кутия, и й записваме данните - SerialNumber, Item, Quantity, Price
                Box box = new Box()
                {
                    SerailNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemQuantity * itemPrice 
                };
                //Добавяме кутия към листа с кутии
                boxes.Add(box);
            }

            //Създавме лист от тип Box, в който ще пазим сортираните кутии и го сортираме
            //Използваме OrederBy метод, за да подредим кутиите по възходяща цена
            List<Box> sortedBoxes = boxes.OrderBy(box => box.PriceForABox).ToList();

            //Преобръщаме листа, за да е по низходяща цена
            sortedBoxes.Reverse();

            //Изпечатваме с foreach
            foreach(Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerailNumber);
                //Чейнваме box.Item.Price за да изкараме цената на предмета
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");

                
            }
        }
    }

    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public int SerailNumber { get; set; }

        //Създаваме пропърти от тип Item, не string както го бях написал първоначално
        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox { get; set; }

        public Box() 
        {
            Item = new Item();
        }

    }
}