namespace Linguistics.Sentences.Major
{
    /// <summary>
    /// A major sentence is a full sentence, consisting out of at least 1 clause.
    /// The completeness can be defined as the sentence having a verb and subject,
    /// directly present or easily identified.
    /// </summary>
    /// <remarks>For more details on major sentence structures,
    /// see https://akademia.com.ng/types-sentences-according-structure-examples/.</remarks>
    /// <seealso cref="Minor.MinorSentence"/>
    internal class MajorSentence : Sentence
    {
        private readonly Clause _clause;

        /// <summary>
        /// Constructs a major sentence following the 'simple sentence' scheme, through a single clause.
        /// </summary>
        /// <param name="clause"></param>
        public MajorSentence(Clause clause)
        {
            _clause = clause;
        }

        public override Sentence AsCommand()
        {
            return new MajorSentence(_clause.AsCommand());
        }

        public override Sentence AsExclamation()
        {
            return new MajorSentence(_clause.AsExclamation());
        }

        public override Sentence AsQuestion()
        {
            return new MajorSentence(_clause.AsQuestion());
        }

        public override Sentence AsStatement()
        {
            return new MajorSentence(_clause.AsStatement());
        }

        public override Sentence AsSuggestion()
        {
            return new MajorSentence(_clause.AsSuggestion());
        }

        protected override string GetStringRepresentation()
        {
            return _clause.ToString();
        }
    }
}
