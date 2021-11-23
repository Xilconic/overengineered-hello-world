namespace SOLID_HelloWorld.Formatting.TextPostfixing
{
    internal class StringInterpolationPostFixer : ITextPostFixer
    {
        public string PostfixText(string source, string postFix) => $"{source}{postFix}";
    }
}