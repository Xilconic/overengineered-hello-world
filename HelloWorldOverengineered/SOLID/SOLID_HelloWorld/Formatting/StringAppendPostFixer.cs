namespace SOLID_HelloWorld.Formatting
{
    internal class StringAppendPostFixer : ITextPostFixer
    {
        public string PostfixText(string source, string postFix) => source + postFix;
    }
}