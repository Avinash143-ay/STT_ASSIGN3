// See https://aka.ms/new-console-template for more information
using System;

class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int speed, int fuel)
    {
        this.speed = speed;
        this.fuel = fuel;
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}");
    }
}

class Car : Vehicle
{
    private int passengers;

    public Car(int speed, int fuel, int passengers)
        : base(speed, fuel)
    {
        this.passengers = passengers;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Car is moving with passengers...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Passengers: {passengers}");
    }
}

class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int speed, int fuel, int cargoWeight)
        : base(speed, fuel)
    {
        this.cargoWeight = cargoWeight;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine("Truck is moving with cargo...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Cargo Weight: {cargoWeight}");
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Vehicle(80, 100);
        vehicles[1] = new Car(100, 120, 4);
        vehicles[2] = new Truck(60, 150, 2000);

        Console.WriteLine("\n--- Demonstrating Polymorphism ---");
        foreach (Vehicle v in vehicles)
        {
            v.Drive();
            v.ShowInfo();
            Console.WriteLine();
        }
    }
}
