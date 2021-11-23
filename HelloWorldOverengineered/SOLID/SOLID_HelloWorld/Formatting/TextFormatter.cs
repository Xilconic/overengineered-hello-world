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

        public string FormatText(string text)
        {
            string[] separateWordsInText = GetWordsFromText(text);
            CapitalizeFirstCharacterOfEachWork(separateWordsInText);

            string textWithFirstCharactersOfEachWordCapitalized = CombineWordsIntoSentence(separateWordsInText);
            return PostFixWithExclamationMark(textWithFirstCharactersOfEachWordCapitalized);
        }

        private string[] GetWordsFromText(string text) => _textSplitter.Tokenize(text);
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
        
        private string PostFixWithExclamationMark(string textWithFirstCharactersOfEachWordCapitalized)
        {
            return _textPostFixer.PostfixText(textWithFirstCharactersOfEachWordCapitalized, "!");
        }
    }
}