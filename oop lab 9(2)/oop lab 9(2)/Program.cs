// See https://aka.ms/new-console-template for more information
// Коляда Олександра
using System;
using System.Collections.Generic;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public virtual void Start()
    {
        Console.WriteLine($"The {Brand} {Model} is starting.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {Brand} {Model} is stopping.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public override void Start()
    {
        Console.WriteLine($"The {NumberOfDoors}-door car {Brand} {Model} is starting.");
    }

    public void Accelerate()
    {
        Console.WriteLine($"The {NumberOfDoors}-door car {Brand} {Model} is accelerating.");
    }
}

class Bicycle : Vehicle
{
    public bool HasBasket { get; set; }

    public override void Start()
    {
        Console.WriteLine($"The bicycle {Brand} {Model} is starting.");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { Brand = "Toyota", Model = "Camry", NumberOfDoors = 4 },
            new Car { Brand = "Honda", Model = "Civic", NumberOfDoors = 2 },
            new Bicycle { Brand = "Giant", Model = "Escape", HasBasket = true },
            new Bicycle { Brand = "Trek", Model = "FX", HasBasket = false }
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();


            if (vehicle is Car)
            {
                ((Car)vehicle).Accelerate();
            }

            Console.WriteLine();
        }

        Console.WriteLine("Car test completed.");
    }
}
