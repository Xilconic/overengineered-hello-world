using Linguistics.Sentences;

namespace Domain_Driven_Design_HelloWorld.AntiCorruptionLayers.Linguistics
{
    internal static class Text
    {
        static Text()
        {
            Sentence sentence = WellKnownSentences.HelloWorld;

            HelloWorld = sentence.ToString();
        }

        public static string HelloWorld { get; }
    }
}
