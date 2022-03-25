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

namespace BSS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int SpelerScore = 0, PcScore = 0;
        private string Text = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Random(ref string tekst)
        {
            Random rnd = new Random();
            if (rnd.Next(1,4) == 1)
            {
                Text = "Blad";
            }
            else if (rnd.Next(1, 4) == 2)
            {
                Text = "Steen";
            }
            else
            {
                Text = "Schaar";
            }
        }

        private void Button_Blad_Click(object sender, RoutedEventArgs e)
        {
            TextPlayer.Text = "Blad";
            Random(ref Text);
            TextPC.Text = Text;
            Voorwaarden(ref SpelerScore, ref PcScore);


        }

        private void Button_Steen_Click(object sender, RoutedEventArgs e)
        {
            TextPlayer.Text = "Steen";
            Random(ref Text);
            TextPC.Text = Text;
            Voorwaarden(ref SpelerScore, ref PcScore);

        }

        private void Button_Schaar_Click(object sender, RoutedEventArgs e)
        {
            TextPlayer.Text = "Schaar";
            Random(ref Text);
            TextPC.Text = Text;
            Voorwaarden(ref SpelerScore, ref PcScore);
        }

        private void Voorwaarden(ref int PuntSpeler, ref int PuntPC)
        {
            string playerKeuze = TextPlayer.Text;
            string pcKeuze = TextPC.Text;
            if (playerKeuze == "Blad" && pcKeuze == "Steen" ||
                playerKeuze == "Steen" && pcKeuze == "Schaar" ||
                playerKeuze == "Schaar" && pcKeuze == "Blad")
            {
                AlgemeenPuntSpeler.Content = "WINNAAR";
                AlgemeenPuntPC.Content = "LOSER";
                TextPlayer.Background = Brushes.DarkGreen;
                TextPC.Background = Brushes.DarkRed;
                PuntSpeler += 1;
            }
            else if 
                (pcKeuze == "Blad" && playerKeuze == "Steen" ||
                 pcKeuze == "Steen" && playerKeuze == "Schaar" ||
                 pcKeuze == "Schaar" && playerKeuze == "Blad")
            {
                AlgemeenPuntSpeler.Content = "LOSER";
                AlgemeenPuntPC.Content = "WINNAAR";
                TextPlayer.Background = Brushes.DarkRed;
                TextPC.Background = Brushes.DarkGreen;
                PuntPC += 1;
            }
            else
            {
                AlgemeenPuntSpeler.Content = "gelijkspel";
                AlgemeenPuntPC.Content = "gelijkspel";
                TextPlayer.Background = Brushes.LightGray;
                TextPC.Background = Brushes.LightGray;
            }
            lblPuntSpeler.Content = SpelerScore;
            lblPuntPC.Content = PcScore;
            AlgemeenPuntSpeler.Background = Brushes.AntiqueWhite;
            AlgemeenPuntPC.Background = Brushes.AntiqueWhite;
        }    
    }
}
