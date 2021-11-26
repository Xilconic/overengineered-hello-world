using System;

namespace LINQ_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(char character in "Hello World!")
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }
    }
}