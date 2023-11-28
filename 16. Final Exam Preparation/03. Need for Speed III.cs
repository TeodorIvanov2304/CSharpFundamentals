/*
 You have just bought the latest and greatest computer game – Need for Seed III. Pick your favorite cars and drive them all you want! We know that you can't wait to start playing.
On the first line of the standard input, you will receive an integer n – the number of cars that you can obtain. On the next n lines, the cars themselves will follow with their mileage and fuel available, separated by "|" in the following format:
"{car}|{mileage}|{fuel}"
Then, you will be receiving different commands, each on a new line, separated by " : ", until the "Stop" command is given:
•	"Drive : {car} : {distance} : {fuel}":
o	You need to drive the given distance, and you will need the given fuel to do that. If the car doesn't have enough fuel, print: "Not enough fuel to make that ride"
o	If the car has the required fuel available in the tank, increase its mileage with the given distance, decrease its fuel with the given fuel, and print: 
"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
o	You like driving new cars only, so if a car's mileage reaches 100 000 km, remove it from the collection(s) and print: "Time to sell the {car}!"
•	"Refuel : {car} : {fuel}":
o	Refill the tank of your car. 
o	Each tank can hold a maximum of 75 liters of fuel, so if the given amount of fuel is more than you can fit in the tank, take only what is required to fill it up. 
o	Print a message in the following format: "{car} refueled with {fuel} liters"
•	"Revert : {car} : {kilometers}":
o	Decrease the mileage of the given car with the given kilometers and print the kilometers you have decreased it with in the following format:
"{car} mileage decreased by {amount reverted} kilometers"
o	If the mileage becomes less than 10 000km after it is decreased, just set it to 10 000km and 
DO NOT print anything.
Upon receiving the "Stop" command, you need to print all cars in your possession in the following format:
"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
Input / Constraints
•	The mileage and fuel of the cars will be valid, 32-bit integers, and will never be negative.
•	The fuel and distance amounts in the commands will never be negative.
•	The car names in the commands will always be valid cars in your possession.
Output
•	All the output messages with the appropriate formats are described in the problem description.
*/
namespace _03._Need_for_Speed_III
{   
    class Car
    {
        public Car(string carModel, uint mileage, uint fuel)
        {
            CarModel = carModel;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string CarModel { get; set; }
        public uint Mileage { get; set; }
        public uint Fuel { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string cars = Console.ReadLine();
                string[] carsArgs = cars.Split("|").ToArray();
                string carModel = carsArgs[0];
                uint carMileage = uint.Parse(carsArgs[1]);
                uint fuel = uint.Parse(carsArgs[2]);

                Car car = new Car(carModel, carMileage, fuel);
                carList.Add(car);
            }

            string commands = "";
            while((commands = Console.ReadLine()) != "Stop")
            {
                string[] commandsArgs = commands.Split(" : ").ToArray();
                string command = commandsArgs[0];
                string carModel = commandsArgs[1];
                Car car = carList.FirstOrDefault(m => m.CarModel == carModel);
                switch(command)
                {
                    case "Drive":
                        uint distance = uint.Parse(commandsArgs[2]);
                        uint fuel = uint.Parse(commandsArgs[3]);

                        if (car.Fuel>=fuel)
                        {
                            car.Fuel -= fuel;
                            car.Mileage += distance;
                            Console.WriteLine($"{car.CarModel} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            if (car.Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car.CarModel}!");
                                carList.Remove(car);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Not enough fuel to make that ride");
                        }
                        break;
                    case "Refuel":
                        uint fuelToAdd = uint.Parse(commandsArgs[2]);
                        if (car.Fuel + fuelToAdd > 75)
                        {
                            fuelToAdd = (uint)(75 - car.Fuel);
                        }
                        car.Fuel += fuelToAdd;
                        Console.WriteLine($"{car.CarModel} refueled with {fuelToAdd} liters");
                        break;
                    case "Revert":
                        uint kilometers = uint.Parse(commandsArgs[2]);
                        
                        car.Mileage -= kilometers;

                        if (car.Mileage < 10000)
                        {
                            car.Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car.CarModel} mileage decreased by {kilometers} kilometers");
                        }

                        
                        break;
                }
            }

            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.CarModel} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}