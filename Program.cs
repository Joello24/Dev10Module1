using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        DoStuff();
    }

    static void DoStuff()
    {
        int first;
        int second;
        Console.WriteLine("Enter a number between 1 and 10");

        String input = Console.ReadLine();
        first = int.Parse(input);
        Console.WriteLine("Enter another number between 1 and 10");

        input = Console.ReadLine();
        second = int.Parse(input);

        int total = first + second;
        Console.WriteLine(total);
    }
}