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
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "Barca", Score1 = 3, Score2 = 2, Completion = 55 });
            matches.Add(new Match() { Team1 = "BVB Dortmund", Team2 = "AS Roma", Score1 = 0, Score2 = 1, Completion = 25 });
            matches.Add(new Match() { Team1 = "Man United", Team2 = "La Galaxy", Score1 = 1, Score2 = 1, Completion = 35 });
            lbMatches.ItemsSource = matches;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " + ":" +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                    (lbMatches.SelectedItem as Match).Team2 + " \n" +
                    (lbMatches.SelectedItem as Match).Completion + " min played");

            }
        }
    }
}
