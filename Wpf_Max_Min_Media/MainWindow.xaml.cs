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

namespace Wpf_Max_Min_Media
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

        private void btn_Calcola_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TxtN1.Text);
            int b = int.Parse(TxtN2.Text);
            int max = Es_n1_Vacanze.LibraryEsN1.Massimo(a, b);
            int min = Es_n1_Vacanze.LibraryEsN1.Minimo(a, b);
            double media = Es_n1_Vacanze.LibraryEsN1.Media(a, b);
            Txt_ris.Text = $"il massimo è {max}, il minimo è {min}, la media è {media}";
        }
    }
}
