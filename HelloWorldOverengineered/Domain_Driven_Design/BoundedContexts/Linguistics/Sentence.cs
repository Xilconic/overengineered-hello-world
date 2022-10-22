namespace Linguistics
{
    public class Sentence
    {
        private string _text;

        internal Sentence(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return _text;
        }
    }
}
