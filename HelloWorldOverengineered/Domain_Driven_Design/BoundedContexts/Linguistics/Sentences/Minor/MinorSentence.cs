namespace Linguistics.Sentences.Minor
{
    /// <summary>
    /// Defined as a word, phrase, or clause functioning as a sentence and having in speech an intonation
    /// characteristic of a sentence but lacking the grammatical completeness and independence of a
    /// full sentence (Examples: "Yes, indeed"." or "Hello, Sandra!"). A minor sentence expresses a complete
    /// unit of meaning albeit without the presence of a verb; that is it omits one of the structural element
    /// like the subject, predicator, or even complement.
    /// </summary>
    /// <remarks>Read https://akademia.com.ng/what-is-a-minor-sentence/ for more details.</remarks>
    /// <seealso cref="Major.MajorSentence"/>
    internal class MinorSentence : Sentence
    {
        private readonly string _text;

        public MinorSentence(string text)
        {
            _text = text;
        }

        protected override string GetStringRepresentation()
        {
            return _text;
        }
    }
}
