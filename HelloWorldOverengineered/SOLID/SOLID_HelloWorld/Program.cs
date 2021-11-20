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
            return "Hello World!";
        }
        
        private static string FormatText(string text)
        {
            return text;
        }
        
        private static void OutputText(string formattedText)
        {
            Console.WriteLine(formattedText);
        }
    }
}