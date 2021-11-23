namespace SOLID_HelloWorld.Formatting.TextTokenization
{
    internal interface ITokenCombinator
    {
        /// <param name="tokens">Cannot be null.</param>
        /// <returns>Will never return null.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="tokens"/> is null.</exception>
        /// <exception cref="System.OutOfMemoryException">Thrown when the combination of <paramref name="tokens"/>
        /// results in a <see cref="string"/> that exceeds it's maximum size.</exception>
        string CombineTokens(string[] tokens);
    }
}