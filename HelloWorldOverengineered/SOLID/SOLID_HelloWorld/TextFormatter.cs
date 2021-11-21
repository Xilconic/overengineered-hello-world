namespace SOLID_HelloWorld
{
    internal class TextFormatter
    {
        private readonly ITokenCombinator _tokenCombinator;
        private readonly ITextSplitter _textSplitter;

        public TextFormatter(ITokenCombinator tokenizer, ITextSplitter splitter)
        {
            _tokenCombinator = tokenizer;
            _textSplitter = splitter;
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
        
        private static string PostFixWithExclamationMark(string textWithFirstCharactersOfEachWordCapitalized)
        {
            return textWithFirstCharactersOfEachWordCapitalized+"!";
        }
    }
}