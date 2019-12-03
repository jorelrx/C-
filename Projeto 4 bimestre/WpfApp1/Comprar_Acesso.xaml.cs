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
using NegocioCliente;
using ModeloComprar_Tempo;
using ModeloCliente;
using NegocioProgram;

namespace WpfApp1
{
    public partial class Comprar_Acesso : Window
    {
        public Comprar_Acesso()
        {
            InitializeComponent();
        }

        private void Button_ComprarTempo(object sender, RoutedEventArgs e)
        {
            NProgram p = new NProgram();
            NCliente c = new NCliente();
            foreach (MCliente m in p.ListarClientes())
                if (m.Id == int.Parse(IdAccount.Text))
                {
                    MComprar_Tempo compra = new MComprar_Tempo(m.Id, m.Nome, double.Parse(valorCompra.Text));
                    c.ComprarTempo(compra);
                    MessageBox.Show("Solicitação enviada!");
                    this.Close();
                }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
