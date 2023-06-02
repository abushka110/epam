using System;

class Automobile
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Automobile()
    {
        Name = "";
        MaxSpeed = 0;
    }

    public Automobile(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }
}

class Car : Automobile
{
    public int PassengerCapacity { get; set; }

    public Car() : base()
    {
        PassengerCapacity = 0;
    }

    public Car(string name, int maxSpeed, int passengerCapacity) : base(name, maxSpeed)
    {
        PassengerCapacity = passengerCapacity;
    }
}

class Vehicle : Automobile
{
    public int CargoWeight { get; set; }

    public Vehicle() : base()
    {
        CargoWeight = 0;
    }

    public Vehicle(string name, int maxSpeed, int cargoWeight) : base(name, maxSpeed)
    {
        CargoWeight = cargoWeight;
    }
}

class Program
{
    static void Main()
    {
        Automobile[] automobiles = new Automobile[2];
        automobiles[0] = new Car("Audi", 220, 5);
        automobiles[1] = new Vehicle("Mercedes", 180, 2000);

        Automobile fasterAutomobile = CompareSpeed(automobiles[0], automobiles[1]);
        if (fasterAutomobile != null)
        {
            Console.WriteLine("The name of the car with a higher speed: " + fasterAutomobile.Name);
            Console.WriteLine("Max speed: " + fasterAutomobile.MaxSpeed);

            if (fasterAutomobile is Car)
            {
                Car car = (Car)fasterAutomobile;
                Console.WriteLine("Number of seats for passengers: " + car.PassengerCapacity);
            }
            else if (fasterAutomobile is Vehicle)
            {
                Vehicle vehicle = (Vehicle)fasterAutomobile;
                Console.WriteLine("Cargo weight: " + vehicle.CargoWeight);
            }
        }
        else
        {
            Console.WriteLine("Both cars have the same speed.");
        }
    }

    static Automobile CompareSpeed(Automobile automobile1, Automobile automobile2)
    {
        if (automobile1.MaxSpeed > automobile2.MaxSpeed)
            return automobile1;
        else if (automobile2.MaxSpeed > automobile1.MaxSpeed)
            return automobile2;
        else
            return null;
    }
}