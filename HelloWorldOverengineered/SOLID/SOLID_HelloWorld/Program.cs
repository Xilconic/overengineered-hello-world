using System;

namespace SOLID_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = GetText();
            string formattedText = new TextFormatter().FormatText(text);
            OutputText(formattedText);
        }

        private static string GetText()
        {
            return "hello world";
        }
        
        private static void OutputText(string formattedText)
        {
            Console.WriteLine(formattedText);
        }
    }
}