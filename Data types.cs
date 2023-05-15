using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaring and initializing variables
        int age = 25;
        string name = "John";
        float weight = 65.5f;
        double height = 1.75;


        // Using constants
        const int MAX_SCORE = 100;

        // Displaying the values of variables and constants
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight + " kg");
        Console.WriteLine("Height: " + height + " m");
        Console.WriteLine("Max Score: " + MAX_SCORE);

        // Using arithmetic operators
        int sum = age + 10;
        int diff = age - 5;
       
        float bmi = (float) (weight / (height * height));

        Console.WriteLine("Age after 10 years: " + sum);
        Console.WriteLine("Age 5 years ago: " + diff);
        Console.WriteLine("BMI: " + bmi);

        // Using comparison operators
        bool isAdult = age >= 18;
        bool isOverweight = weight > 80;

        Console.WriteLine("Is adult: " + isAdult);
        Console.WriteLine("Is overweight: " + isOverweight);

        // Using logical operators
        bool hasGoodBMI = bmi >= 18.5 && bmi <= 24.9;
        bool isHealthy = isAdult && !isOverweight && hasGoodBMI;

        Console.WriteLine("Has good BMI: " + hasGoodBMI);
        Console.WriteLine("Is healthy: " + isHealthy);

        // Waiting for user input
        Console.ReadLine();
    }
}
