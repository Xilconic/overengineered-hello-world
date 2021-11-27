using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(char character in GetText())
            {
                Console.Write(character);
            }
        }

        private static IEnumerable<char> GetText()
        {
            var word1 = new[] { 7, 4, 11, 11, 14 };
            var word2 = new[] { 22, 14, 17, 11, 3 };
            var sentence = new[]
            {
                word1,
                word2
            };

            return sentence.GetSentenceFromIndices()
                .Concat(CharacterSets.GetUnicodeUtf16().LazyGetElementAt(33))
                .Concat(Environment.NewLine);
        }
    }
    
    internal static class CharacterSets
    {
        public static IEnumerable<char> GetUnicodeUtf16() => Enumerable.Range(char.MinValue, char.MaxValue).Select(number => (char)number);
        public static IEnumerable<char> GetAlphabet() => GetUnicodeUtf16().Skip(97).Take(24);
        public static IEnumerable<char> GetAlphabetUpper() => GetUnicodeUtf16().Skip(65).Take(24);
    }
    
    internal static class SentenceBasedExtensionMethods
    {
        public static IEnumerable<char> GetWordFromIndices(this IEnumerable<int> alphabetIndices)
        {
            return alphabetIndices
                .Select((letterIndex, sequenceIndex) => 
                    sequenceIndex == 0 ? 
                        CharacterSets.GetAlphabetUpper().LazyGetElementAt(letterIndex) :
                        CharacterSets.GetAlphabet().LazyGetElementAt(letterIndex)
                )
                .SelectMany(character => character);
        }
        
        public static IEnumerable<char> GetSentenceFromIndices(this IEnumerable<IEnumerable<int>> wordAlphabetIndices) => 
            new WordsToSentenceAggregator(wordAlphabetIndices);
    }

    internal static class IEnumerableExtensions
    {
        public static IEnumerable<T> LazyGetElementAt<T>(this IEnumerable<T> source, int index) =>
            source.Skip(index).Take(1);
    }
    
    internal class WordsToSentenceAggregator : IEnumerator<char>, IEnumerable<char>
    {
        private ProcessingState _state = ProcessingState.Start;
        private readonly IEnumerator<IEnumerable<int>> _enumerator;
        private IEnumerator<char> _currentWordEnumerator;
        private readonly char _wordSpacer;

        public WordsToSentenceAggregator(IEnumerable<IEnumerable<int>> wordAlphabetIndices)
        {
            _enumerator = wordAlphabetIndices.GetEnumerator();
            _wordSpacer = CharacterSets.GetUnicodeUtf16().ElementAt(32);
        }
        
        public bool MoveNext()
        {
            var hasNext = false;
            switch (_state)
            {
                case ProcessingState.Start:
                {
                    var hasNextWord = _enumerator.MoveNext();
                    if (hasNextWord)
                    {
                        SetCurrentWordEnumerator();
                        // NOTE: We assume all words always have at least 1 element!
                        hasNext = _currentWordEnumerator.MoveNext();
                        Current = _currentWordEnumerator.Current;
                        
                        _state = ProcessingState.ProcessingWord;
                    }

                    break;
                }
                case ProcessingState.ProcessingWord:
                {
                    var currentWordHasNextCharacter = _currentWordEnumerator.MoveNext();
                    if (currentWordHasNextCharacter)
                    {
                        Current = _currentWordEnumerator.Current;
                        hasNext = true;
                    }
                    else
                    {
                        var hasNextWord = _enumerator.MoveNext();
                        if (hasNextWord)
                        {
                            SetCurrentWordEnumerator();
                            Current = _wordSpacer;
                            hasNext = true;
                        }
                    }
                    break;
                }
                    
            }
            
            return hasNext;
        }

        private void SetCurrentWordEnumerator()
        {
            IEnumerable<char> currentWord = _enumerator.Current.GetWordFromIndices();
            _currentWordEnumerator = currentWord.GetEnumerator();
        }

        public void Reset()
        {
            Current = default;
            _state = ProcessingState.Start;
            _enumerator.Reset();
            _currentWordEnumerator = null;
        }

        public char Current { get; private set; }
        object IEnumerator.Current => Current;

        public void Dispose() {}
        
        public IEnumerator<char> GetEnumerator() => this;
        IEnumerator IEnumerable.GetEnumerator() => this;
        
        private enum ProcessingState
        {
            Start,
            ProcessingWord
        }
    }
}