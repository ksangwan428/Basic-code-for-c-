using System;

// Define a base class named "Vehicle"
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

// Define a derived class named "Car" that inherits from "Vehicle"
class Car : Vehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Car accelerating");
    }
}

// Main method
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of Car
        Car myCar = new Car();

        // Call the Start method inherited from Vehicle
        myCar.Start();

        // Call the Accelerate method defined in Car
        myCar.Accelerate();

        // Output:
        // Vehicle started
        // Car accelerating
    }
}
