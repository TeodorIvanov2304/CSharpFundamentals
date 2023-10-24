namespace _07._Vehicle_Catalogue
{
    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
               
                string[] command2 = command.Split('/');
                string type = command2[0];
                string brand = command2[1];
                string model = command2[2];
                int index = int.Parse(command2[3]);

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = index;
                    catalog.Cars.Add(car);

                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = index;
                    catalog.Trucks.Add(truck);
                }

            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.Brand))
                {

                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}