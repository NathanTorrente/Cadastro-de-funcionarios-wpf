using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace Socorro
{
    public partial class MainWindow : Window
    {
        private Window activeForm = null;
        private TelaMenuEscola TelaMenuEscola;
        private ContentControl contentControl;

        public MainWindow()
        {
            InitializeComponent();
            TelaMenuEscola = new TelaMenuEscola();
            TelaMenuEscola.Left = 274; // Adjust position to fit the left grid width
            TelaMenuEscola.Top = 0;
           
            
           
        }
       
        private void AbrirTelaMenuEscola()
        {
            TelaMenuEscola telaMenuInicio = new TelaMenuEscola();
           telaMenuInicio.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            AbrirTelaMenuEscola();
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
