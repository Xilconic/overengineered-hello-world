namespace SOLID_HelloWorld.Formatting.TextTokenization
{
    internal class TextTokenizer : ITokenCombinator, ITextSplitter
    {
        private readonly string _separator;

        public TextTokenizer(string separator)
        {
            _separator = separator;
        }

        /// <inheritdoc cref="ITextSplitter"/>
        public string[] Tokenize(string text) => text.Split(_separator);
        
        /// <inheritdoc cref="ITokenCombinator"/>
        public string CombineTokens(string[] tokens) => string.Join(_separator, tokens);
    }
}