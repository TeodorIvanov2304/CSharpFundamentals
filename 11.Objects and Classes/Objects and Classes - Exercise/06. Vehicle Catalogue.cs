using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalog = new List<Vehicle>();

            string data = "";

            while ((data = Console.ReadLine()) != "End") 
            {
                string[] dataTokens = data.Split();
                string type = dataTokens[0].ToLower();
                string model = dataTokens[1];
                string color = dataTokens[2].ToLower();
                int horsePower = int.Parse(dataTokens[3]);

                Vehicle vehicle = new Vehicle(type,model,color,horsePower);
                catalog.Add(vehicle);
            }

            string modelToSearch = "";

            while ((modelToSearch = Console.ReadLine()) != "Close the Catalogue")
            {

                //string modelType = modelToSearch;
                //Vehicle printCar = catalog.First(x=>x.Type == modelToSearch);
                //Console.WriteLine(printCar);

                if (catalog.Any(x => x.Model.Contains(modelToSearch)))
                {
                    int index = catalog.FindIndex(x => x.Model == modelToSearch);
                    Console.WriteLine($"{catalog[index]}");
                }
            }

            int sumTruckPower = 0;
            int truckCount = 0;
            int sumCarPower = 0;
            int carCount = 0;
            foreach (Vehicle vehicle in catalog) 
            {
                if (vehicle.Type == "car" )
                {
                    sumCarPower += vehicle.HorsePower;
                    carCount++;
                }
                else
                {
                    sumTruckPower += vehicle.HorsePower;
                    truckCount++;
                }
            }

            //Когато броят на колите, е = 0 даваше грешен отговор, за камионите също
            if (sumCarPower > 0) 
            {
                Console.WriteLine($"Cars have average horsepower of: {(double)sumCarPower / (double)carCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (sumTruckPower>0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(double)sumTruckPower / (double)truckCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            

        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendLine($"Type: {(Type == "car" ? "Car":"Truck")}");
            stringBuild.AppendLine($"Model: {Model}");
            stringBuild.AppendLine($"Color: {Color}");
            stringBuild.AppendLine($"Horsepower: {HorsePower}");

            return stringBuild.ToString().TrimEnd();
        }

    }
}