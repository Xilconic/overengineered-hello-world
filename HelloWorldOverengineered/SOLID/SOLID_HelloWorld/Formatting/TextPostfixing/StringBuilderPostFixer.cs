using System;
using System.Text;

namespace SOLID_HelloWorld.Formatting.TextPostfixing
{
    internal class StringBuilderPostFixer : ITextPostFixer
    {
        /// <inheritdoc cref="ITextPostFixer"/>
        public string PostfixText(string source, string postFix)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            if (postFix is null) throw new ArgumentNullException(nameof(postFix));
            
            var builder = new StringBuilder();
            builder.Append(source);
            builder.Append(postFix);
            return builder.ToString();
        }
    }
}