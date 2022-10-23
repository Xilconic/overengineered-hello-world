namespace Linguistics.Sentences.Minor
{
    /// <summary>
    /// The person or thing about whom the statement in a sentence is made.
    /// </summary>
    internal class Subject
    {
        private readonly string _subject;

        public Subject(string subject)
        {
            _subject = subject;
        }

        public override string ToString()
        {
            return _subject.ToString();
        }
    }
}
