namespace SOLID_HelloWorld.Formatting.TextTokenization
{
    internal interface ITextSplitter
    {
        /// <returns>Guarantees returning an array of at least 1 element.
        /// Also guarantees the array itself does not contain null.</returns>
        string[] Tokenize(string text);
    }
}