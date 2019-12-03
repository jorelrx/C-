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
using ModeloUsuario;
using ModeloCliente;
using ModeloFuncionario;
using NegocioProgram;

namespace WpfApp1
{
    public partial class Inscricao : Window
    {
        public Inscricao()
        {
            InitializeComponent();
        }
        int contas = 0;
        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        NProgram p = new NProgram();

        private void Button_NewAccount(object sender, RoutedEventArgs e)
        {
            foreach (MUsuario u in p.ListarFuncionario()) if (u.Id > contas) contas = u.Id;
            if (contas == 0)
            {
                MFuncionario c = new MFuncionario(nomeConta.Text, senhaConta.Text, emailConta.Text, true);
                p.InserirFuncionario(c);
            }
            else
            {
                MCliente c = new MCliente(nomeConta.Text, senhaConta.Text, emailConta.Text);
                p.InserirCliente(c);
            }
            Button_Cancelar(sender, e);
        }
    }
}
