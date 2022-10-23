namespace Linguistics.Sentences
{
    public abstract class Sentence
    {
        protected abstract string GetStringRepresentation();

        public override string ToString()
        {
            return GetStringRepresentation();
        }

        public abstract Sentence AsStatement();
        public abstract Sentence AsExclamation();
        public abstract Sentence AsQuestion();
        public abstract Sentence AsCommand();
        public abstract Sentence AsSuggestion();
    }
}
