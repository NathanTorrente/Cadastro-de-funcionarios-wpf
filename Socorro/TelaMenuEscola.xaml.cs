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

namespace Socorro
{
    /// <summary>
    /// Lógica interna para TelaMenuEscola.xaml
    /// </summary>
    public partial class TelaMenuEscola : Window
    {
        public TelaMenuEscola()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            MessageBox.Show("botão 1 Clicked!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("botão 2 Clicked!");
        }

        private void Button_Click_sair(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
