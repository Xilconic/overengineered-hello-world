namespace SOLID_HelloWorld.Formatting
{
    internal class StringInterpolationPostFixer : ITextPostFixer
    {
        public string PostfixText(string source, string postFix) => $"{source}{postFix}";
    }
}