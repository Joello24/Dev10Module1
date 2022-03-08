using System;
using System.Linq;
using HelloWorld.Backend;

namespace HelloWorld.Backend
{
    class StringConcat
    {
        public void Run()
        {
            // STRING CONCATINATION

            Console.Write("Please enter a string: ");
            String value = Console.ReadLine();
            Console.Write("Please enter a search string: ");
            String search = Console.ReadLine();
            Console.Write("Please enter a replacement string: ");
            String replacement = Console.ReadLine();

            value = value.Replace($"{search}", $"{replacement}");

            Console.Write($"{value}");
        }
    }
}
