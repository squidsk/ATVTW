using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TWLibrary;


namespace ATVTW
{
    /// <summary>
    /// Interaction logic for ATVTWWindow.xaml
    /// </summary>
    public partial class ATVTWWindow : Window
    {
        private Settings settings;
        private readonly HardcodedLists hcLists;
        private readonly CustomLists cLists;
        private readonly Options options;

        public ATVTWWindow() {
            options = new Options();
        }

        private void CommandCanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }

        private void CommandNeedsSettingsToExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = settings != null;
        }

        private void OpenSetting(object sender, RoutedEventArgs e) {
            MessageBox.Show("Open Setting is not yet implemented!", "Open Setting", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void NewSetting(object sender, RoutedEventArgs e) {
            MessageBox.Show("New Setting is not yet implemented!", "New Setting", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void ExitProgram(object sender, ExecutedRoutedEventArgs e) {
            Close();
        }

        private void StopForWarnings(object sender, ExecutedRoutedEventArgs e) {
            //options.StopForWarnings = OptionsWarningsMenuItem.IsChecked;
        }

        private void About(object sender, RoutedEventArgs e) {
            ATVTWAbout aboutWindow = new ATVTWAbout(this);
            aboutWindow.ShowDialog();
        }


    }
}
