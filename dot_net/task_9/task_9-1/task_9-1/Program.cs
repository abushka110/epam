using System;

class Automobile
{
    private string name;
    private string carModel;
    private int maxSpeed;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }

    public int MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    public Automobile(string name, string carModel, int maxSpeed)
    {
        Name = name;
        CarModel = carModel;
        MaxSpeed = maxSpeed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Automobile> automobiles = new List<Automobile>();

        automobiles.Add(new Automobile("Audi", "R8 GT", 330));
        automobiles.Add(new Automobile("Tesla", "model S plaid", 321));
        automobiles.Add(new Automobile("Mercedes", "AMG GT 63 S E", 360));
        automobiles.Add(new Automobile("Bentley", "Continental GT", 335));

        foreach (Automobile automobile in automobiles)
        {
            Console.WriteLine("Name of the car is: " + automobile.Name);
            Console.WriteLine("car model is: " + automobile.CarModel);
            Console.WriteLine("Maximum speed is: " + automobile.MaxSpeed);
            Console.WriteLine();
        }

        int maxSpeed = 0;
        string fastestCar = "";

        foreach (Automobile automobile in automobiles)
        {
            if (automobile.MaxSpeed > maxSpeed)
            {
                maxSpeed = automobile.MaxSpeed;
                fastestCar = automobile.Name;
            }
        }

        Console.WriteLine("The fastest car is: " + fastestCar);

        Console.ReadLine();
    }
}