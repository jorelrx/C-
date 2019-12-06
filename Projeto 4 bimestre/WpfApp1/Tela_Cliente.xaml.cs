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
using ModeloCliente;
using NegocioProgram;
using NegocioCliente;
using NegocioComprar_Tempo;

namespace WpfApp1
{
    public partial class Tela_Cliente : Window
    {
        public Tela_Cliente()
        {
            InitializeComponent();
        }
        NProgram p = new NProgram();
        private void Button_Sair(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void Button_ComprarTempo(object sender, RoutedEventArgs e)
        {
            Comprar_Acesso cA = new Comprar_Acesso();
            cA.Show();
            cA.IdAccount.Text = IdAccount.Text;
        }

        private void Button_Meus_Dados(object sender, RoutedEventArgs e)
        {
            Meus_Dados Md = new Meus_Dados();
            foreach (MCliente f in p.ListarClientes())
                if (f.Id == int.Parse(IdAccount.Text))
                {
                    Md.TypeAccount.Text = TypeAccount.Text;
                    Md.IdAccount.Text = f.Id.ToString();
                    Md.nomeConta.Text = f.Nome.ToString();
                    Md.emailConta.Text = f.Email.ToString();
                    Md.senhaConta.Text = f.Senha.ToString();
                }
            Md.Show();
        }

        private void Button_ListarTempo(object sender, RoutedEventArgs e)
        {
            foreach (MCliente f in p.ListarClientes()) if (f.Id == int.Parse(IdAccount.Text)) MessageBox.Show(f.Tempo.ToString()+"Horas");
        }

        private void Button_ExtratoDeCompra(object sender, RoutedEventArgs e)
        {
            NComprar_Tempo c = new NComprar_Tempo();
            Extratos_de_Compra a = new Extratos_de_Compra();
            foreach (MCliente f in p.ListarClientes())
                if (f.Id == int.Parse(IdAccount.Text))
                {
                    a.listBox.ItemsSource = c.ListarMinhasCompras(f);
                    a.Show();
                }
        }
    }
}
