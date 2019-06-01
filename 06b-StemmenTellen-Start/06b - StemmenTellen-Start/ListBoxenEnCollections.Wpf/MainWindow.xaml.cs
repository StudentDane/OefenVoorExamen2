using System.Windows;
using System.Windows.Input;

namespace ListBoxenEnCollections.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] kandidaten;
        int[] aantalStemmen;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
    }
}
