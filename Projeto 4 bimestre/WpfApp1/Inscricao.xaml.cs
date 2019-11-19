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
    /// Interação lógica para Inscricao.xam
    /// </summary>
    public partial class Inscricao : Page
    {
        public Inscricao()
        {
            InitializeComponent();
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            this.Content = mW;
        }
    }
}
