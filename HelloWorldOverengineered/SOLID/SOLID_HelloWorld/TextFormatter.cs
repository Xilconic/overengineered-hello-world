namespace SOLID_HelloWorld
{
    internal class TextFormatter
    {
        private readonly TextTokenizer _textTokenizer;

        public TextFormatter()
        {
            _textTokenizer = new TextTokenizer(" ");
        }

        public string FormatText(string text)
        {
            string[] separateWordsInText = GetWordsFromText(text);
            CapitalizeFirstCharacterOfEachWork(separateWordsInText);

            string textWithFirstCharactersOfEachWordCapitalized = CombineWordsIntoSentence(separateWordsInText);
            return PostFixWithExclamationMark(textWithFirstCharactersOfEachWordCapitalized);
        }

        private string[] GetWordsFromText(string text) => _textTokenizer.Tokenize(text);
        private string CombineWordsIntoSentence(string[] separateWordsInText) => _textTokenizer.CombineTokens(separateWordsInText);

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