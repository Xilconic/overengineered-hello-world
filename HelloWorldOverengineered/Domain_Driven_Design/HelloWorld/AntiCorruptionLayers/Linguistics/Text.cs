using Linguistics;

namespace Domain_Driven_Design_HelloWorld.AntiCorruptionLayers.Linguistics
{
    internal static class Text
    {
        static Text()
        {
            Sentence sentence = Sentences.HelloWorld;

            HelloWorld = sentence.ToString();
        }

        public static string HelloWorld { get; }
    }
}
