using System.Collections.Generic;
using SOLID_HelloWorld.Displaying;
using SOLID_HelloWorld.Formatting;
using SOLID_HelloWorld.Formatting.TextTokenization;
using SOLID_HelloWorld.TextSourcing;
using SOLID_HelloWorld.Utilities;

namespace SOLID_HelloWorld
{
    class Program
    {
        private static readonly RandomIntegerProvider Random = new();
        private static readonly TextTokenizer Tokenizer = new(" ");
        private static readonly TextDeterminator TextDeterminator = new();
        private static readonly IReadOnlyList<ITextPostFixer> PossiblePostFixers = new ITextPostFixer[]
        {
            new StringAppendPostFixer(),
            new StringInterpolationPostFixer(),
            new StringBuilderPostFixer(),
        };
        private static readonly TextFormatter TextFormatter = new(Tokenizer, Tokenizer, PossiblePostFixers[Random.GetRandomInteger(PossiblePostFixers.Count)]);
        private static readonly TextOutputter TextOutputter = new();

        static void Main(string[] args)
        {
            string text = TextDeterminator.GetText();
            string formattedText = TextFormatter.FormatText(text);
            TextOutputter.OutputText(formattedText);
        }
    }
}