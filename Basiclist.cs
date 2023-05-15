using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list of integers
        List<int> numbers = new List<int>();

        // Add some elements to the list
        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(15);

        // Access and modify elements in the list
        Console.WriteLine(numbers[0]); // prints 5
        numbers[1] = 20;
        Console.WriteLine(numbers[1]); // prints 20

        // Iterate over the elements in the list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
