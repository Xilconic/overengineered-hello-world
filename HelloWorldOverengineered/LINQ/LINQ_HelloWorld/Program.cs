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
            var word1 = new[] { 7, 4, 11, 11, 14 };
            foreach (char character in word1.GetWordFromIndices())
            {
                yield return character;
            }
            
            yield return CharacterSets.GetUnicodeUtf16().ElementAt(32);
            
            var word2 = new[] { 22, 14, 17, 11, 3 };
            foreach (char character in word2.GetWordFromIndices())
            {
                yield return character;
            }
            
            yield return CharacterSets.GetUnicodeUtf16().ElementAt(33);
            foreach (char character in Environment.NewLine)
            {
                yield return character;
            }
        }
    }
    
    internal static class CharacterSets
    {
        public static IEnumerable<char> GetUnicodeUtf16() => Enumerable.Range(char.MinValue, char.MaxValue).Select(number => (char)number);
        public static IEnumerable<char> GetAlphabet() => GetUnicodeUtf16().Skip(97).Take(24);
        public static IEnumerable<char> GetAlphabetUpper() => GetUnicodeUtf16().Skip(65).Take(24);
    }
    
    internal static class SentenceBasedExtensionMethods
    {
        public static IEnumerable<char> GetWordFromIndices(this IEnumerable<int> alphabetIndices)
        {
            return alphabetIndices
                .Select((letterIndex, sequenceIndex) => 
                    sequenceIndex == 0 ? 
                        CharacterSets.GetAlphabetUpper().ElementAt(letterIndex) :
                        CharacterSets.GetAlphabet().ElementAt(letterIndex)
                );
        }
    }
}