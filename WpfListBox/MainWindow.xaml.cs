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

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 2, Score2 = 3, Completion = 85 });
            matches.Add(new Match()
            {
                Team1 = "PSG", Team2 = "Barca", Score1 = 1, Score2 = 4, Completion = 55
            });
            matches.Add(new Match()
            {
                Team1 = "BVB Dortmund", Team2 = "As Roma", Score1 = 2, Score2 = 2, Completion = 77
            });
            matches.Add(new Match()
            {
                Team1 = "Manchester United",
                Team2 = "LA Galaxy",
                Score1 = 3,
                Score2 = 2,
                Completion = 80
            });

            lbMatches.ItemsSource = matches;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: " + (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " +
                    (lbMatches.SelectedItem as Match).Team2 + " " +
                    (lbMatches.SelectedItem as Match).Score2);
            }
        }

       
    }
}
