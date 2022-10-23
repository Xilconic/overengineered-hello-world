namespace Linguistics.Sentences.Major
{
    /// <summary>
    /// A clause is a group of words that includes a subject and a verb (it has a subject and a predicate)
    /// and forms a simple sentence or part of the non-simple sentence. A clause is a major unit of grammar
    /// and we define it by the elements it could contain: the subject, predicator, complement and the adjunct.
    /// As the finite verb is the most central to a clause, it is necessary to identify a clause by its main verb.
    /// </summary>
    /// <remarks>Read https://akademia.com.ng/the-english-clause-definition-types-and-examples/ for more details.</remarks>
    internal class Clause
    {
        private readonly string _clauseText;

        public Clause(string clauseText)
        {
            _clauseText = clauseText;
        }

        public override string ToString()
        {
            return _clauseText;
        }

        public Clause AsCommand()
        {
            var newClause = ReplaceLastCharacterOfStringWith(_clauseText, '!');
            return new Clause(newClause);
        }

        public Clause AsExclamation()
        {
            var newClause = ReplaceLastCharacterOfStringWith(_clauseText, '!');
            return new Clause(newClause);
        }

        public Clause AsQuestion()
        {
            var newClause = ReplaceLastCharacterOfStringWith(_clauseText, '?');
            return new Clause(newClause);
        }

        public Clause AsStatement()
        {
            var newClause = ReplaceLastCharacterOfStringWith(_clauseText, '.');
            return new Clause(newClause);
        }

        public Clause AsSuggestion()
        {
            var newClause = ReplaceLastCharacterOfStringWith(_clauseText, '.');
            return new Clause(newClause);
        }

        private static string ReplaceLastCharacterOfStringWith(string source, char replacementCharacter) =>
            source[0..^1] + replacementCharacter;
    }
}
