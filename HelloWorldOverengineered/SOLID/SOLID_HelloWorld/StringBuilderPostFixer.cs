using System.Text;

namespace SOLID_HelloWorld
{
    internal class StringBuilderPostFixer : ITextPostFixer
    {
        public string PostfixText(string source, string postFix)
        {
            var builder = new StringBuilder();
            builder.Append(source);
            builder.Append(postFix);
            return builder.ToString();
        }
    }
}