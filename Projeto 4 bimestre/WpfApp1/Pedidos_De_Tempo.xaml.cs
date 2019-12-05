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
using System.Windows.Shapes;
using NegocioComprar_Tempo;
using ModeloComprar_Tempo;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para Pedidos_De_Tempo.xaml
    /// </summary>
    public partial class Pedidos_De_Tempo : Window
    {
        public Pedidos_De_Tempo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NComprar_Tempo compraTempo = new NComprar_Tempo();
            MComprar_Tempo m = new MComprar_Tempo();
            List<MComprar_Tempo> list = compraTempo.ListarCompras();
            MComprar_Tempo compra = compraTempo.ListarCompras()[listBox.SelectedIndex];
            compraTempo.PermitirCompra(compra);
        }
    }
}
