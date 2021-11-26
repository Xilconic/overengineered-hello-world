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

        private static IEnumerable<char> GetText()
        {
            yield return 'H';
            yield return 'e';
            yield return 'l';
            yield return 'l';
            yield return 'o';
            yield return ' ';
            yield return 'W';
            yield return 'o';
            yield return 'r';
            yield return 'l';
            yield return 'd';
            yield return '!';
            foreach (char character in Environment.NewLine)
            {
                yield return character;
            }
        }
    }
}