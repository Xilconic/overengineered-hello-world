namespace SOLID_HelloWorld
{
    internal class StringAppendPostFixer : ITextPostFixer
    {
        public string PostfixText(string source, string postFix) => source + postFix;
    }
}