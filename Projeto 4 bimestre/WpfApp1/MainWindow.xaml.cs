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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Tela_Senha(object sender, RoutedEventArgs e) // Botão pra carregar segunda tela de login;
        {
            Login_Senha login_Senha = new Login_Senha();
            login_Senha.Show();
            this.Close();
        }

        private void Button_Criar_Conta(object sender, RoutedEventArgs e) // Botão pra carregar tela de inscrição
        {
            Inscricao inscricao = new Inscricao();
            inscricao.Show();
            this.Close();
        }
    }
}
