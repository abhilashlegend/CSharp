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

namespace WPFRadioImg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMaybe.IsChecked = true;
        }

        private void NoChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes");
        }

        private void YesChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you");
        }

        private void MayBeChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes");
        }
    }
}
