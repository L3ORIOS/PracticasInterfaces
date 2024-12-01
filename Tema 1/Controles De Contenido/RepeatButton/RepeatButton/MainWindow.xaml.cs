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

namespace RepeatButton
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

        private void BtnMas_Click(object sender, RoutedEventArgs e)
        {
            Texto.FontSize += 10;
            txtb_size.Text = "Tamaña de letra: " + Texto.FontSize.ToString();
        }

        private void BtnMenos_Click(object sender, RoutedEventArgs e)
        {
            if (Texto.FontSize > 10)
                Texto.FontSize -= 10;
                txtb_size.Text = "Tamaña de letra: " + Texto.FontSize.ToString();
        }
    }
}
