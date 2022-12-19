using System.Windows.Input;

namespace ATVTW
{
    static class TWCommands {
        public static RoutedUICommand CreateSetting { get; private set; }
        public static RoutedUICommand About { get; private set; }
        public static RoutedUICommand Validate { get; private set; }
        public static RoutedUICommand StopForWarnings { get; private set; }
        public static RoutedUICommand AutoIndent { get; private set; }

        static TWCommands() {
            CreateSetting = new RoutedUICommand("Create Setting", "Create Setting", typeof(TWCommands));
            CreateSetting.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control | ModifierKeys.Alt));
            About = new RoutedUICommand("About", "About", typeof(TWCommands));
            Validate = new RoutedUICommand("Validate", "Validate", typeof(TWCommands));
            Validate.InputGestures.Add(new KeyGesture(Key.V, ModifierKeys.Alt));
            StopForWarnings = new RoutedUICommand("StopForWarnings", "StopForWarnings", typeof(TWCommands));
            AutoIndent = new RoutedUICommand("AutoIndent", "AutoIndent", typeof(TWCommands));
        }
    }
}