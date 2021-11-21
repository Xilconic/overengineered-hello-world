namespace SOLID_HelloWorld
{
    internal class TextTokenizer : ITokenCombinator, ITextSplitter
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