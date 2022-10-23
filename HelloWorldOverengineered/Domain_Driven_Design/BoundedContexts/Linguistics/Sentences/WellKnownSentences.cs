using Linguistics.Sentences.Minor;

namespace Linguistics.Sentences
{
    public class WellKnownSentences
    {
        public static Sentence HelloWorld { get; } = MinorSentence.AsGreeting(new Subject("World")).AsExclamation();
    }
}
