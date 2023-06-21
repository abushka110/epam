using System;
using System.Collections.Generic;

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
        set
        {
            if (value < 0 || value > 300)
            {
                throw new ArgumentOutOfRangeException("Максимальна швидкість", "Недійсне значення максимальної швидкості. Максимальна швидкість має бути від 0 до 300 км/год.");
            }
            maxSpeed = value;
        }
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

        try
        {
            automobiles.Add(new Automobile("Audi", "R8 GT", 280));
            automobiles.Add(new Automobile("Tesla", "Model S Plaid", 390)); // Invalid maximum speed value
            automobiles.Add(new Automobile("Mercedes", "AMG GT 63 S E", 271)); // Invalid maximum speed value
            automobiles.Add(new Automobile("Bentley", "Continental GT", -25)); // Invalid maximum speed value
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }

        foreach (Automobile automobile in automobiles)
        {
            Console.WriteLine("Марка автомобіля: " + automobile.Name);
            Console.WriteLine("Модель автомобіля: " + automobile.CarModel);
            Console.WriteLine("Максимальна швидкість автомобіля: " + automobile.MaxSpeed);
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

        Console.WriteLine("Найшвидший автомобіль: " + fastestCar);

        Console.ReadLine();
    }
}