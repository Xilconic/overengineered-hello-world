namespace SOLID_HelloWorld.Formatting.TextPostfixing
{
    internal interface ITextPostFixer
    {
        /// <param name="source">Cannot be null.</param>
        /// <param name="postFix">Cannot be null.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="source"/>
        /// or <paramref name="postFix"/> is null.</exception>
        string PostfixText(string source, string postFix);
    }
}