using Linguistics.Sentences.Minor;

namespace Linguistics.Sentences
{
    public class WellKnownSentences
    {
        public static Sentence HelloWorld { get; } = new MinorSentence("Hello World.").AsExclamation();
    }
}
