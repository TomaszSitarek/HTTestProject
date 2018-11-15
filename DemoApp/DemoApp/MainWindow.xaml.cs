using System.Collections.Generic;
using System.Windows;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] Items = new[] {"a","d","c","e" };

        public MainWindow()
        {
            int a;
            InitializeComponent();
            this.ComboBox.ItemsSource = Items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.TextBlock.Text = this.ComboBox.SelectedItem?.ToString();
        }
    }
}
