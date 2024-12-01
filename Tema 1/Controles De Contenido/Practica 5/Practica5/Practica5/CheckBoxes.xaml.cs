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

namespace Practica5
{
    /// <summary>
    /// Lógica de interacción para CheckBoxes.xaml
    /// </summary>
    public partial class CheckBoxes : Window
    {
        public CheckBoxes()
        {
            InitializeComponent();
        }

        private void ckbx0_Checked(object sender, RoutedEventArgs e)
        {
            ckbx1.IsEnabled = true;
            ckbx2.IsEnabled = true;
            ckbx3.IsEnabled = true;
   
        }
    }
}
