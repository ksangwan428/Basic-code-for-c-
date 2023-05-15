using System;
using System.Collections.Generic;

namespace ListInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();

            Console.WriteLine("Enter items to add to the list (type 'done' to finish):");

            string input = Console.ReadLine();
            while (input != "done")
            {
                mylist.Add(input);
                input = Console.ReadLine();
            }

            Console.WriteLine("Your list contains:");
            foreach (string item in mylist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
