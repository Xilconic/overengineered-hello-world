namespace SOLID_HelloWorld
{
    internal interface ITextTokenizer
    {
        string[] Tokenize(string text);
        string CombineTokens(string[] tokens);
    }
}