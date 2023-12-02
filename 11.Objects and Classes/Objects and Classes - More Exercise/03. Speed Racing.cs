using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace _03._Speed_Racing
{   
    class Car
    {
        public Car(string carModel, double fuel, double fuelConsumption, int traveledDistance)
        {
            CarModel = carModel;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            TraveledDistance = traveledDistance;
        }

        public string CarModel { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public int TraveledDistance { get; set; }

        public static void MoveCar(int distance, Car car, double fuelConsumed)
        {
            if (car.Fuel >= fuelConsumed)
            {
                car.Fuel -= fuelConsumed;
                car.TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string carInfo = Console.ReadLine();
                string[] carInfoTokens = carInfo.Split().ToArray();
                string carModel = carInfoTokens[0];
                double fuel = double.Parse(carInfoTokens[1]);
                double fuelPerKm = double.Parse(carInfoTokens[2]);
                int distrance = 0;
                Car car = new Car(carModel, fuel, fuelPerKm, distrance);
                carList.Add(car);
            }

            string commands = "";
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] commandsArgs = commands.Split();

                string carModel = commandsArgs[1];
                int distance = int.Parse(commandsArgs[2]);

                Car car = carList.FirstOrDefault(model => model.CarModel == carModel);
                double fuelConsumed = (double)(distance * car.FuelConsumption);
                Car.MoveCar(distance, car, fuelConsumed);
            }

            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.CarModel} {car.Fuel:F2} {car.TraveledDistance}");
            }
        }

    }
}