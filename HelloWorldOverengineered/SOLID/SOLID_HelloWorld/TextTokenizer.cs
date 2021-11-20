namespace SOLID_HelloWorld
{
    internal class TextTokenizer
    {
        private readonly string _separator = " ";

        public string[] Tokenize(string text)
        {
            return text.Split(_separator);
        }
        
        public string CombineTokens(string[] tokens)
        {
            return string.Join(_separator, tokens);
        }
    }
}