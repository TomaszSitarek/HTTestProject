using System.Collections.Generic;
using System.Windows;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] Items = new[] {"a","b","c" };

        public MainWindow()
        {
            InitializeComponent();
            this.ComboBox.ItemsSource = Items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.TextBlock.Text = this.ComboBox.SelectedItem.ToString();
        }
    }
}
