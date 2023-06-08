using System;

public abstract class Planet
{
    public abstract void ReportAboutMovement();
    public abstract void ReportAboutLife();
}

public class Earth : Planet
{
    public override void ReportAboutMovement()
    {
        Console.WriteLine("The Earth moves in an orbit around the Sun.");
    }

    public override void ReportAboutLife()
    {
        Console.WriteLine("Earth contains a variety of life.");
    }
}

public class Moon : Planet
{
    public override void ReportAboutMovement()
    {
        Console.WriteLine("The moon moves in an orbit around the Earth.");
    }

    public override void ReportAboutLife()
    {
        Console.WriteLine("There is no evidence of life on the moon.");
    }
}

class Program
{
    static void Main()
    {
        Planet[] planets = new Planet[2];

        Earth earth = new Earth();
        Moon moon = new Moon();

        planets[0] = earth;
        planets[1] = moon;

        foreach (Planet planet in planets)
        {
            planet.ReportAboutMovement();
            planet.ReportAboutLife();
            Console.WriteLine();
        }
    }
}
