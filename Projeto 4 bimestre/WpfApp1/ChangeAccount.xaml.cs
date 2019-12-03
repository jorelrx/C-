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
using ModeloCliente;
using ModeloFuncionario;
using ModeloUsuario;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para ChangeAccount.xaml
    /// </summary>
    public partial class ChangeAccount : Window
    {
        public ChangeAccount()
        {
            InitializeComponent();
        }
        NProgram p = new NProgram();
        private void Button_AlterarConta(object sender, RoutedEventArgs e)
        {
            int num = listBox.SelectedIndex;
            MUsuario u = p.AllAccount()[num];
            AlterarConta alterarConta = new AlterarConta(TypeAccount.Text);
            alterarConta.nomeConta.Text = u.Nome;
            alterarConta.emailConta.Text = u.Email;
            alterarConta.senhaConta.Text = u.Senha;
            alterarConta.IdAccount.Text = u.Id.ToString();
            alterarConta.Show();
        }

        private void Button_ExcluirConta(object sender, RoutedEventArgs e)
        {
            int num = listBox.SelectedIndex;
            MUsuario u = p.AllAccount()[num];
            foreach (MCliente c in p.ListarClientes()) if (c.Id == u.Id) p.DeleteCliente(c);
            foreach (MFuncionario c in p.ListarFuncionario()) if (c.Id == u.Id) p.DeleteFuncionario(c);
            listBox.ItemsSource = p.AllAccount();
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
