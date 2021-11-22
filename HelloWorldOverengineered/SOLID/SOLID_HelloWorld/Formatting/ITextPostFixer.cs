namespace SOLID_HelloWorld.Formatting
{
    internal interface ITextPostFixer
    {
        string PostfixText(string source, string postFix);
    }
}