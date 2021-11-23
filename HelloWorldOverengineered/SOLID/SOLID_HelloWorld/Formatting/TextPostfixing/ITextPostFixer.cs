namespace SOLID_HelloWorld.Formatting.TextPostfixing
{
    internal interface ITextPostFixer
    {
        string PostfixText(string source, string postFix);
    }
}