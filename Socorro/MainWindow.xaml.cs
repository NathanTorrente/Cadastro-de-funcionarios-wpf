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
            TelaMenuEscola.Left = 274; 
            TelaMenuEscola.Top = 0;
           
        }
       
      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            
        }
      


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TelaMenuEscola telaMenuInicio = new TelaMenuEscola();
            telaMenuInicio.ShowDialog();
        }

       
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

    
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Aluno(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
