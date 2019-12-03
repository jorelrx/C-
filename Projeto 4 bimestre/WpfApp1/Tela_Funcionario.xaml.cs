using ModeloFuncionario;
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
using NegocioProgram;
using ModeloFuncionario;
using PersistenciaComprar_Tempo;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para Tela_Funcionario.xaml
    /// </summary>
    public partial class Tela_Funcionario : Window
    {
        public Tela_Funcionario()
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

        private void Button_Meus_Dados(object sender, RoutedEventArgs e)
        {
            Meus_Dados Md = new Meus_Dados();
            foreach (MFuncionario f in p.ListarFuncionario())
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

        private void Button_PedidoDeTempo(object sender, RoutedEventArgs e)
        {
            PComprar_Tempo c = new PComprar_Tempo();
            Pedidos_De_Tempo pedidos = new Pedidos_De_Tempo();
            pedidos.listBox.ItemsSource = c.OpenCompras();
            pedidos.Show();
        }

        private void Button_AddConta(object sender, RoutedEventArgs e)
        {
            AddConta addConta = new AddConta(TypeAccount.Text);
            addConta.Show();
        }

        private void Button_GerenciarConta(object sender, RoutedEventArgs e)
        {
            ChangeAccount cA = new ChangeAccount();
            cA.Show();
            cA.TypeAccount.Text = TypeAccount.Text;
            cA.listBox.ItemsSource = p.AllAccount();
        }
    }
}
