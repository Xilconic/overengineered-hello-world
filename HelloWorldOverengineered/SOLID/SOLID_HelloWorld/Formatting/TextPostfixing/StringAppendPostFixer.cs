using System;

namespace SOLID_HelloWorld.Formatting.TextPostfixing
{
    internal class StringAppendPostFixer : ITextPostFixer
    {
        /// <inheritdoc cref="ITextPostFixer"/>
        public string PostfixText(string source, string postFix)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            if (postFix is null) throw new ArgumentNullException(nameof(postFix));
            
            return source + postFix;
        }
    }
}