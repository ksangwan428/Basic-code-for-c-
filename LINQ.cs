using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using LINQ to find even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.Write(number + " ");
        }

        // Using LINQ to find numbers greater than 5
        var greaterThanFive = numbers.Where(n => n > 5);

        Console.WriteLine("\nNumbers greater than 5:");
        foreach (var number in greaterThanFive)
        {
            Console.Write(number + " ");
        }

        // Using LINQ to find the first even number
        int firstEvenNumber = numbers.First(n => n % 2 == 0);

        Console.WriteLine("\n\nThe first even number is: " + firstEvenNumber);

        Console.ReadLine();
    }
}
