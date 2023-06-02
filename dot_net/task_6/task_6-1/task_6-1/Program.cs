using System;

class Car
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Car()
    {
        Name = "";
        MaxSpeed = 0;
    }

    public Car(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }
    public static Car CompareSpeed(Car car1, Car car2)
    {
        if (car1.MaxSpeed > car2.MaxSpeed)
            return car1;
        else if (car2.MaxSpeed > car1.MaxSpeed)
            return car2;
        else
            return null;
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Audi", 240);
        Car car2 = new Car("BMW", 250);

        Car fasterCar = Car.CompareSpeed(car1, car2);
        if (fasterCar != null)
            Console.WriteLine("The name of the car with a higher speed: " + fasterCar.Name);
        else
            Console.WriteLine("Both cars have the same speed.");
    }
}