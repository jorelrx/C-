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
    ///     Interação lógica para MainWindow.xam
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
            listBoxChave.ItemsSource = null;
            listBoxValores.ItemsSource = null;
            listBoxChave.ItemsSource = d.Chaves;
            listBoxValores.ItemsSource = d.Valores;
        }

        private void ButtonClick_Remove(object sender, RoutedEventArgs e)
        {
            if (d.Remove(chaveRemove.Text))
            {
                MessageBox.Show("Item removido do dicionário com sucesso");
            }
            else
            {
                MessageBox.Show("Chave não existe");
            }
            listBoxChave.ItemsSource = null;
            listBoxValores.ItemsSource = null;
            listBoxChave.ItemsSource = d.Chaves;
            listBoxValores.ItemsSource = d.Valores;
        }

        private void ButtonClick_Contains(object sender, RoutedEventArgs e)
        {
            if (d.Contains(chaveContains.Text))
            {
                MessageBox.Show("Chave existe no dicionário.");
            }
            else
            {
                MessageBox.Show("Chave não existe no dicionário.");
            }
        }

        private void ButtonClick_Clear(object sender, RoutedEventArgs e)
        {
            d.Clear();
            listBoxChave.ItemsSource = null;
            listBoxValores.ItemsSource = null;
            listBoxChave.ItemsSource = d.Chaves;
            listBoxValores.ItemsSource = d.Valores;
        }
    }
}
