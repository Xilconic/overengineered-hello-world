using Display;

namespace Domain_Driven_Design_HelloWorld.AntiCorruptionLayers.Display
{
    internal static class System
    {
        private static readonly VisualDisplay _visualDisplay;

        static System()
        {
            _visualDisplay = new VisualDisplay();
        }

        public static void WriteLine(string text)
        {
            _visualDisplay.Visualize(text);
        }
    }
}
