using Display;
using Domain_Driven_Design_HelloWorld.AntiCorruptionLayers.Linguistics;

namespace Domain_Driven_Design_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var display = new VisualDisplay();
            display.Visualize(Text.HelloWorld);
        }
    }
}