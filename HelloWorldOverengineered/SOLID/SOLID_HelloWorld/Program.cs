using System;

namespace SOLID_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = GetText();
            string formattedText = FormatText(text);
            OutputText(formattedText);
        }

        private static string GetText()
        {
            return "hello world";
        }
        
        private static string FormatText(string text)
        {
            string[] separateWordsInText = GetWordsFromText(text);
            CapitalizeFirstCharacterOfEachWork(separateWordsInText);

            string textWithFirstCharactersOfEachWordCapitalized = CombineWordsIntoSentence(separateWordsInText);
            return PostFixWithExclamationMark(textWithFirstCharactersOfEachWordCapitalized);
        }

        private static string[] GetWordsFromText(string text)
        {
            return new TextTokenizer().Tokenize(text);
        }
        
        private static void CapitalizeFirstCharacterOfEachWork(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var wordWithFirstCharacterCapitalized = CapitalizeFirstCharacter(words[i]);
                words[i] = wordWithFirstCharacterCapitalized;
            }
        }

        private static string CapitalizeFirstCharacter(string word)
        {
            char firstCharacter = word[0];
            string remainder = word[1..];
            return firstCharacter.ToString().ToUpper() + remainder;
        }
        
        private static string CombineWordsIntoSentence(string[] separateWordsInText)
        {
            return new TextTokenizer().CombineTokens(separateWordsInText);
        }
        
        private static string PostFixWithExclamationMark(string textWithFirstCharactersOfEachWordCapitalized)
        {
            return textWithFirstCharactersOfEachWordCapitalized+"!";
        }

        private static void OutputText(string formattedText)
        {
            Console.WriteLine(formattedText);
        }
    }
}