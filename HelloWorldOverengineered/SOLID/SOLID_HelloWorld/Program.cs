namespace SOLID_HelloWorld
{
    class Program
    {
        private static readonly TextDeterminator TextDeterminator = new();
        private static readonly TextFormatter TextFormatter = new();
        private static readonly TextOutputter TextOutputter = new();

        static void Main(string[] args)
        {
            string text = TextDeterminator.GetText();
            string formattedText = TextFormatter.FormatText(text);
            TextOutputter.OutputText(formattedText);
        }
    }
}