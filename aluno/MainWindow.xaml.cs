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

namespace aluno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            bool sabia = (ck_sabia.IsChecked == true ? true : false);
            bool fui = (ck_fui.IsChecked == true ? true : false);
            bool estudei = (ck_estudei.IsChecked == true ? true : false);
            bool colei = (ck_colei.IsChecked == true ? true : false);


            bool resultado = sabia || fui && estudei || !fui && !estudei && colei;


            if (resultado == true)
            {
                la_resultado.Foreground = new SolidColorBrush(Colors.Green);
                la_resultado.Text = "Aprovado ";
            }
            else if (resultado == false)
            {
                la_resultado.Foreground = new SolidColorBrush(Colors.Red);
                la_resultado.Text = "Reprovado";
            }
            else
            {
                la_resultado.Text = "Error 404, NOT FOUND";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            la_resultado.Text="";
            ck_sabia.IsChecked = false;
            ck_fui.IsChecked = false;
            ck_estudei.IsChecked = false;
            ck_colei.IsChecked = false;
        }
    }
}
