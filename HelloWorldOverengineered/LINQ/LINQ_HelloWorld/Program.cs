using System;
using System.Collections.Generic;
using System.Linq;

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
            yield return GetAlphabetUpper().ElementAt(7);
            yield return GetAlphabet().ElementAt(4);
            yield return GetAlphabet().ElementAt(11);
            yield return GetAlphabet().ElementAt(11);
            yield return GetAlphabet().ElementAt(14);
            
            yield return GetUnicodeUtf16().ElementAt(32);
            
            yield return GetAlphabetUpper().ElementAt(22);
            yield return GetAlphabet().ElementAt(14);
            yield return GetAlphabet().ElementAt(17);
            yield return GetAlphabet().ElementAt(11);
            yield return GetAlphabet().ElementAt(3);
            
            yield return GetUnicodeUtf16().ElementAt(33);
            foreach (char character in Environment.NewLine)
            {
                yield return character;
            }
        }

        private static IEnumerable<char> GetUnicodeUtf16() => Enumerable.Range(char.MinValue, char.MaxValue).Select(number => (char)number);
        private static IEnumerable<char> GetAlphabet() => GetUnicodeUtf16().Skip(97).Take(24);
        private static IEnumerable<char> GetAlphabetUpper() => GetUnicodeUtf16().Skip(65).Take(24);
    }
}