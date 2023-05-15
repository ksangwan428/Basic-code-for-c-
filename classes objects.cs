// Defining a class named Person
using System;

public class Person
{
    // Fields or properties of the class
    public string Name;
    public int Age;

    // Constructor of the class
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method of the class
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }

    static void Main(string[] args)
    {
        // Creating an object of the Person class
        Person john = new Person("John", 30);

        // Calling the Greet method of the Person class
        john.Greet();
    }
}




    

