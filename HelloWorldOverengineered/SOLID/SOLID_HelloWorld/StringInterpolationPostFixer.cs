namespace SOLID_HelloWorld
{
    internal class StringInterpolationPostFixer : ITextPostFixer
    {
        public string PostfixText(string source, string postFix) => $"{source}{postFix}";
    }
}