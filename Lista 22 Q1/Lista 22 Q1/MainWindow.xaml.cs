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
using Modelo;
using Negocio;

namespace Lista_22_Q1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SelectClick(null, null);
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NGame n = new NGame();
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            MGame m = new MGame();
            m.Id = int.Parse(txtId.Text);
            m.Nome = txtNome.Text;
            m.Fabricante = txtFabricante.Text;
            m.DataCompra = DateTime.Parse(txtNasc.Text);
            m.Estrelas = int.Parse(txtEstrelas.Text);

            NGame n = new NGame();
            n.Insert(m);

            SelectClick(sender, e);
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            MGame m = new MGame();
            m.Id = int.Parse(txtId.Text);
            m.Nome = txtNome.Text;
            m.Fabricante = txtFabricante.Text;
            m.DataCompra = DateTime.Parse(txtNasc.Text);
            m.Estrelas = int.Parse(txtEstrelas.Text);

            NGame n = new NGame();
            n.Update(m);

            SelectClick(sender, e);
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            MGame m = new MGame();
            m.Id = int.Parse(txtId.Text);

            NGame n = new NGame();
            n.Delete(m);

            SelectClick(sender, e);
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MGame c = grid.SelectedItem as MGame;
                txtId.Text = c.Id.ToString();
                txtNome.Text = c.Nome;
                txtFabricante.Text = c.Fabricante;
                txtNasc.Text = c.DataCompra.ToString("dd/MM/yyyy");
                txtEstrelas.Text = c.Estrelas.ToString();
            }
        }
    }
}
