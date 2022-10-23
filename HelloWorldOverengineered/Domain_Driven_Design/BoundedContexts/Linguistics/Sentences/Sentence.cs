namespace Linguistics.Sentences
{
    public abstract class Sentence
    {
        protected abstract string GetStringRepresentation();

        public override string ToString()
        {
            return GetStringRepresentation();
        }
    }
}
