
using System.Windows;

namespace Laba6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBoxResult messageBoxResult = MessageBox.Show("Dima Pidor");

            System.Console.WriteLine();
        }
    }
}
