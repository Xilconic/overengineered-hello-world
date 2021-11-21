namespace SOLID_HelloWorld
{
    internal class TextTokenizer : ITextTokenizer
    {
        private readonly string _separator;

        public TextTokenizer(string separator)
        {
            _separator = separator;
        }

        public string[] Tokenize(string text) => text.Split(_separator);
        public string CombineTokens(string[] tokens) => string.Join(_separator, tokens);
    }
}