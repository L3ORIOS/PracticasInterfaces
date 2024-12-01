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

namespace Practica6
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

        private void btn_label_Click(object sender, RoutedEventArgs e)
        {
            Label label = new Label();
            label.Show();   
        }

        private void btn_tooltip_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btn_frame2_Click(object sender, RoutedEventArgs e)
        {
            Frame2 frame2 = new Frame2();   
            frame2.Show();
        }

        private void btn_groupbox_Click(object sender, RoutedEventArgs e)
        {
            GroupBox groupBox = new GroupBox(); 
            groupBox.Show();
        }

        private void btn_expander_Click(object sender, RoutedEventArgs e)
        {
            Expander expander = new Expander(); 
            expander.Show();
        }

        private void btn_frame1_Click_1(object sender, RoutedEventArgs e)
        {
            Frame1 frame1 = new Frame1();
            frame1.Show();  
        }
    }
}
