namespace _04._Raw_Data
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public Engine(uint engineSpeed, uint enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public uint EngineSpeed { get; set; }
        public uint EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(uint weight, string cargoType)
        {
            Weight = weight;
            CargoType = cargoType;
        }

        public uint Weight { get; set; }
        public string CargoType { get; set; }
    }
    internal class Program
    {   
        
        static void Main(string[] args)
        {   
            List<Car> carList = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string carInfo = Console.ReadLine();
                string[] carInfoArgs = carInfo.Split().ToArray();
                //"<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"
                
                uint engineSpeed = uint.Parse(carInfoArgs[1]);
                uint enginePower = uint.Parse(carInfoArgs[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                uint cargoWeight = uint.Parse(carInfoArgs[3]);
                string cargoType = carInfoArgs[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                string carModel = carInfoArgs[0];
                Car car = new Car(carModel, engine, cargo);
                carList.Add(car);
            }

            string cargoTypeToCheck = Console.ReadLine();
            foreach (Car car in carList.Where(c=>c.Cargo.CargoType == cargoTypeToCheck))
            {
                if (cargoTypeToCheck == "fragile" && car.Cargo.Weight<1000)
                {
                    Console.WriteLine($"{car.Model}");
                }
                else if(cargoTypeToCheck == "flamable" && car.Engine.EnginePower > 250)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}