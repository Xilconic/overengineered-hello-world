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

        public override Sentence AsCommand()
        {
            var newMinorSentenceText = ReplaceLastCharacterOfStringWith(_text, '!');
            return new MinorSentence(newMinorSentenceText);
        }

        public override Sentence AsExclamation()
        {
            var newMinorSentenceText = ReplaceLastCharacterOfStringWith(_text, '!');
            return new MinorSentence(newMinorSentenceText);
        }

        public override Sentence AsQuestion()
        {
            var newMinorSentenceText = ReplaceLastCharacterOfStringWith(_text, '?');
            return new MinorSentence(newMinorSentenceText);
        }

        public override Sentence AsStatement()
        {
            var newMinorSentenceText = ReplaceLastCharacterOfStringWith(_text, '.');
            return new MinorSentence(newMinorSentenceText);
        }

        public override Sentence AsSuggestion()
        {
            var newMinorSentenceText = ReplaceLastCharacterOfStringWith(_text, '.');
            return new MinorSentence(newMinorSentenceText);
        }

        protected override string GetStringRepresentation()
        {
            return _text;
        }

        private static string ReplaceLastCharacterOfStringWith(string source, char replacementCharacter) =>
            source[0..^1] + replacementCharacter;
    }
}
