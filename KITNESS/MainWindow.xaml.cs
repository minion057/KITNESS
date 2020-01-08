using System;
using System.Windows;
using System.Windows.Input;

namespace Kitness
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start(object sender, RoutedEventArgs e)
        {
            PartSelection selection = new PartSelection();
            Close();
            selection.ShowDialog();
        }

        private void bt_Exit(object sender, RoutedEventArgs e)
        {
            Exit exit = new Exit();
            Close();
            exit.ShowDialog();
        }
        private void bt_Information(object sender, RoutedEventArgs e)
        {
            Information info = new Information();
            info.ShowDialog();
        }
    }
}
