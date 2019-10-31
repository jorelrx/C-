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

namespace Ex05
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Dicionario<string, string> d = new Dicionario<string, string>();
        private void ButtonClick_Add(object sender, RoutedEventArgs e)
        {
            d.Add(chave.Text, valor.Text);
            foreach (string s in d.Chaves) listBox.Items.Add(s);
        }

        private void ButtonClick_Remove(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClick_Contains(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClick_Clear(object sender, RoutedEventArgs e)
        {

        }
    }
}
