using System;
using SOLID_HelloWorld.Formatting.TextPostfixing;
using SOLID_HelloWorld.Formatting.TextTokenization;

namespace SOLID_HelloWorld.Formatting
{
    internal class TextFormatter
    {
        private readonly ITokenCombinator _tokenCombinator;
        private readonly ITextSplitter _textSplitter;
        private readonly ITextPostFixer _textPostFixer;

        public TextFormatter(
            ITokenCombinator tokenizer,
            ITextSplitter splitter,
            ITextPostFixer textPostFixer)
        {
            _tokenCombinator = tokenizer;
            _textSplitter = splitter;
            _textPostFixer = textPostFixer;
        }

        /// <param name="text">Cannot be null.</param>
        /// <exception cref="System.OutOfMemoryException">Thrown when the formatted text based on <paramref name="text"/>
        /// is too big.</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="text"/> is null.</exception>
        /// <returns>Guarantees returning a formatted <see cref="string"/> based on <paramref name="text"/>,
        /// given that memory limits were not exceeded.</returns>
        public string FormatText(string text)
        {
            if (text is null) throw new ArgumentNullException(nameof(text));
            
            string[] separateWordsInText = GetWordsFromText(text);
            CapitalizeFirstCharacterOfEachWork(separateWordsInText);

            string textWithFirstCharactersOfEachWordCapitalized = CombineWordsIntoSentence(separateWordsInText);
            return PostFixWithExclamationMark(textWithFirstCharactersOfEachWordCapitalized);
        }

        /// <returns>Guarantees returning an array of at least 1 element.
        /// Also guarantees the array itself does not contain null.</returns>
        private string[] GetWordsFromText(string text) => _textSplitter.Tokenize(text);

        /// <param name="separateWordsInText">Cannot be null.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="separateWordsInText"/> is null.</exception>
        /// <exception cref="System.OutOfMemoryException">Thrown when the combination of
        ///   <paramref name="separateWordsInText"/> results in a string that is too big.</exception>
        private string CombineWordsIntoSentence(string[] separateWordsInText) => _tokenCombinator.CombineTokens(separateWordsInText);

        private static void CapitalizeFirstCharacterOfEachWork(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var wordWithFirstCharacterCapitalized = CapitalizeFirstCharacter(words[i]);
                words[i] = wordWithFirstCharacterCapitalized;
            }
        }

        private static string CapitalizeFirstCharacter(string word)
        {
            char firstCharacter = word[0];
            string remainder = word[1..];
            return firstCharacter.ToString().ToUpper() + remainder;
        }
        
        /// <param name="textWithFirstCharactersOfEachWordCapitalized">Cannot be null.</param>
        /// <exception cref="System.ArgumentException">Thrown when <paramref name="textWithFirstCharactersOfEachWordCapitalized"/> is null.</exception>
        private string PostFixWithExclamationMark(string textWithFirstCharactersOfEachWordCapitalized)
        {
            return _textPostFixer.PostfixText(textWithFirstCharactersOfEachWordCapitalized, "!");
        }
    }
}