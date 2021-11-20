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
            string[] separateWordsInText = text.Split(" ");
            for (int i = 0; i < separateWordsInText.Length; i++)
            {
                char firstCharacter = separateWordsInText[i][0];
                string remainder = separateWordsInText[i][1..];
                string wordWithFirstCharacterCapitalized = firstCharacter.ToString().ToUpper() + remainder;
                separateWordsInText[i] = wordWithFirstCharacterCapitalized;
            }
            return string.Join(" ", separateWordsInText)+"!";
        }
        
        private static void OutputText(string formattedText)
        {
            Console.WriteLine(formattedText);
        }
    }
}