using Display;
using Linguistics;

namespace Domain_Driven_Design_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Sentence sentence = Sentences.HelloWorld;

            var display = new VisualDisplay();
            display.Visualize(sentence.ToString());
        }
    }
}