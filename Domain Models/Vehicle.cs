namespace Domain_Models
{
    public abstract class Vehicle
    {
        public uint Id { get; set; }
        private static uint lastId = 0;
        public string Url { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get;  set; }
        public int hoursePower { get;  set; }
        public Vehicle(string brand, string model, int year, string color, int hoursePower)
        {
            this.Url = $"car/{lastId}";
            Id = lastId++;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            this.hoursePower = hoursePower;
        }
        public virtual void DisplayVehicle()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Write($"This vehicle is from the great brand of ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.brand}");
            Console.ResetColor();
            Console.Write($"It is their model: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{this.model}");
            Console.ResetColor();
            Console.Write($" Made in the year ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.year}");
            Console.ResetColor();
            Console.WriteLine($"The {this.color} exterior matches well with its {this.hoursePower} number of hoursepowers");
        }
    }

    public abstract class Car : Vehicle
    {
        public int numberOfDoors { get; set; }
        public List<string>? listOfAdditionalEquipment { get; set; }
        public Car(string brand, string model, int year, string color, int hoursePower)
        : base(brand, model, year, color, hoursePower)
        {
        }
    }

    public class EVCar : Car
    {
        public int batteryCapacity { get; set; }
        public int range {  get; set; }
        public EVCar(string brand, string model, int year, string color, int hoursePower)
        : base(brand, model, year, color, hoursePower)
        {
        }
        public override void DisplayVehicle()
        {
            base.DisplayVehicle();
            Console.WriteLine($"It comes with a {this.batteryCapacity} kWh battery that gives {this.range} miles of range!");
        }
    }

    public class PetrolCar : Car
    {
        public int numberOfCylinders { get; set;}

        public PetrolCar(string brand, string model, int year, string color, int hoursePower)
        : base(brand, model, year, color, hoursePower)
        {
        }
        public override void DisplayVehicle()
        {
            base.DisplayVehicle();
            Console.WriteLine($"It comes with {this.numberOfCylinders} cylinders that each help the world get just a bit hotter");
        }

    }

    public class MotorBike : Vehicle
    {
        public int numberOfCylinders { get; set; }
        public MotorBike(string brand, string model, int year, string color, int hoursePower)
        : base(brand, model, year, color, hoursePower)
        {
        }
    }

}
