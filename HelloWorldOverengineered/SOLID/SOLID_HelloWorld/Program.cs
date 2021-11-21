namespace SOLID_HelloWorld
{
    class Program
    {
        private static readonly TextTokenizer Tokenizer = new(" ");
        private static readonly TextDeterminator TextDeterminator = new();
        private static readonly TextFormatter TextFormatter = new(Tokenizer, Tokenizer);
        private static readonly TextOutputter TextOutputter = new();

        static void Main(string[] args)
        {
            string text = TextDeterminator.GetText();
            string formattedText = TextFormatter.FormatText(text);
            TextOutputter.OutputText(formattedText);
        }
    }
}