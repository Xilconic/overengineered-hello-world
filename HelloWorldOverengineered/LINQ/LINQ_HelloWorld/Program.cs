using System;
using System.Collections.Generic;

namespace LINQ_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(char character in GetText())
            {
                Console.Write(character);
            }
        }

        private static IEnumerable<char> GetText() => "Hello World!"+Environment.NewLine;
    }
}