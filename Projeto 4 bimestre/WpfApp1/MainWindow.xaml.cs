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
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Login_Senha tela_Senha = 
                this.Content = new Login_Senha();
        }

        private void Button_Criar_Conta(object sender, RoutedEventArgs e)
        {
            Inscricao insc = new Inscricao();
            this.Content = insc;
        }

        /// ///////////////////////////
        /// 
        public void Tela_Senha()
        {
            this.Content = new Page_Administrador();
        }
    }
}
