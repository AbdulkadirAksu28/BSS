using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
namespace BSS2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int SpelerScore = 0, PcScore = 0;
        private string Text = "";
        private int tijd = 3;
        private DispatcherTimer Timer;      
        public MainWindow()
        {
            InitializeComponent();
            timer();
            btnPaper.MouseEnter += new MouseEventHandler(btnPaper_MouseEnter);
            btnSteen.MouseEnter += new MouseEventHandler(btnSteen_MouseEnter);
            btnSchaar.MouseEnter += new MouseEventHandler(btnSchaar_MouseEnter);
            btnPaper.MouseLeave += new MouseEventHandler(btnPaper_MouseLeave);
            btnSteen.MouseLeave += new MouseEventHandler(btnSteen_MouseLeave);
            btnSchaar.MouseLeave += new MouseEventHandler(btnSchaar_MouseLeave);         
        }
        private void btnSchaar_MouseLeave(object sender, MouseEventArgs e)
        {
            this.btnSchaar.Content = LeaveFotoKeuze(btnSchaar);
        }
        private void btnSteen_MouseLeave(object sender, MouseEventArgs e)
        {
            this.btnSteen.Content = LeaveFotoKeuze(btnSteen);
        }
        private void btnPaper_MouseLeave(object sender, MouseEventArgs e)
        {
            this.btnPaper.Content = LeaveFotoKeuze(btnPaper);
        }
        private void btnSchaar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.btnSchaar.Content = EnterFotoKeuze(btnSchaar);
        }
        private void btnSteen_MouseEnter(object sender, MouseEventArgs e)
        {
            this.btnSteen.Content = EnterFotoKeuze(btnSteen);
        }
        private void btnPaper_MouseEnter(object sender, MouseEventArgs e)
        {
            this.btnPaper.Content = EnterFotoKeuze(btnPaper);
        }
        private Image EnterFotoKeuze(Button btn)
        {
            Image afb = new Image();
            if (btn.Name == "btnPaper")
            {

                afb.Source = new BitmapImage(new Uri(@"images\paper-tint.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (btn.Name == "btnSteen")
            {
                afb.Source = new BitmapImage(new Uri(@"images\rocks.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                afb.Source = new BitmapImage(new Uri(@"images\scissor.jpg", UriKind.RelativeOrAbsolute));
            }
            afb.Stretch = Stretch.Fill;
            return afb;
        }
        private Image LeaveFotoKeuze(Button btn)
        {
            Image afb = new Image();
            if (btn.Name == "btnPaper")
            {
                afb.Source = new BitmapImage(new Uri(@"images\papers.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (btn.Name == "btnSteen")
            {
                afb.Source = new BitmapImage(new Uri(@"images\rock-tint.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                afb.Source = new BitmapImage(new Uri(@"images\scissorstint.jpg", UriKind.RelativeOrAbsolute));
            }
            afb.Stretch = Stretch.Fill;
            return afb;
        }
        private void timer()
        {
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tijd > 0)
            {
                tijd--;               
            }
            else
            {
                Timer.Stop();
                tijdOp();
                MessageBox.Show("Tijd is op, Computer wint");          
            }
            lblTijd.Content = string.Format("{0}", tijd % 60);
            if (tijd < 2)
            {
                lblTijd.Foreground = Brushes.Red;
            }
            else
            {
                lblTijd.Foreground = Brushes.Black;
            }
            lblPuntSpeler.Content = SpelerScore;
            lblPuntPC.Content = PcScore;
        }
        private void tijdOp()
        {
            if (tijd == 0)
            {
                AlgemeenPuntSpeler.Content = "LOSER";
                AlgemeenPuntPC.Content = "WINNAAR";
                TextPlayer.Background = Brushes.DarkRed;
                TextPC.Background = Brushes.DarkGreen;
                PcScore += 1;
                imgPlayer.Content = tijdOpFoto();
                imgPc.Content = tijdOpFoto();
                verhoogZindex(imgPlayer);
                verhoogZindex(imgPc);
                tijd = 4;
                lblTijd.Content = string.Format("{0}", tijd % 60 - 1);
                Timer.Start();
            }
        }
        private Image tijdOpFoto()
        {
            Image afb = new Image();
            afb.Source = new BitmapImage(new Uri(@"images\time.jpg", UriKind.RelativeOrAbsolute));
            afb.Stretch = Stretch.Fill;
            return afb;
        }
        private void Random(ref string tekst)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 4) == 1)
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
            imgPlayer.Content = FotoKeuze(TextPlayer.Text);
            imgPc.Content = FotoKeuze(TextPC.Text);
            verhoogZindex(imgPlayer);
            verhoogZindex(imgPc);
            tijd = 4;
            lblTijd.Content = string.Format("{0}", tijd % 60 -1);
            Timer.Start();
            btnPaper.BorderBrush = Brushes.Black;          
            btnSteen.BorderBrush = Brushes.Gray;
            btnSchaar.BorderBrush = Brushes.Gray;
            EindeGame(ref SpelerScore, ref PcScore);
        }
        private void Button_Steen_Click(object sender, RoutedEventArgs e)
        {
            TextPlayer.Text = "Steen";
            Random(ref Text);
            TextPC.Text = Text;
            Voorwaarden(ref SpelerScore, ref PcScore);
            imgPlayer.Content = FotoKeuze(TextPlayer.Text);
            imgPc.Content = FotoKeuze(TextPC.Text);
            verhoogZindex(imgPlayer);
            verhoogZindex(imgPc);   
            tijd = 4;
            lblTijd.Content = string.Format("{0}", tijd % 60 - 1);
            Timer.Start();
            btnSteen.BorderBrush = Brushes.Black;
            btnPaper.BorderBrush = Brushes.Gray;
            btnSchaar.BorderBrush = Brushes.Gray;
            EindeGame(ref SpelerScore, ref PcScore);
        }
        private void Button_Schaar_Click(object sender, RoutedEventArgs e)
        {
            TextPlayer.Text = "Schaar";
            Random(ref Text);
            TextPC.Text = Text;
            Voorwaarden(ref SpelerScore, ref PcScore);
            imgPlayer.Content = FotoKeuze(TextPlayer.Text);
            imgPc.Content = FotoKeuze(TextPC.Text);
            verhoogZindex(imgPlayer);
            verhoogZindex(imgPc);   
            tijd = 4;    
            lblTijd.Content = string.Format("{0}", tijd % 60 - 1);
            Timer.Start();         
            btnSchaar.BorderBrush = Brushes.Black;              
            btnSteen.BorderBrush = Brushes.Gray;
            btnPaper.BorderBrush = Brushes.Gray;
            EindeGame(ref SpelerScore, ref PcScore);
        }
        private void verhoogZindex(Button but)
        {
            Grid.SetZIndex(but, 5);
        }
        private Image FotoKeuze(string tekst)
        {
            Image afb = new Image();
            
            if (tekst == "Blad")
            {
                
                afb.Source = new BitmapImage(new Uri(@"images\paper-tint.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (tekst == "Steen")
            {
                afb.Source = new BitmapImage(new Uri(@"images\rocks.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                afb.Source = new BitmapImage(new Uri(@"images\scissor.jpg", UriKind.RelativeOrAbsolute));
            }
            afb.Stretch = Stretch.Fill;           
            return afb;
        }
        private void EindeGame(ref int scoreSpeler, ref int scorePc)
        {
            if (scoreSpeler == 10)
            {
                Timer.Stop();
                MessageBoxResult antwoord = MessageBox.Show("Proficiat jij wint", "Wil je opniew spelen?", MessageBoxButton.YesNo);

                if (antwoord == MessageBoxResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Environment.Exit(0);
                    Close();
                }
                               
            }
            else if (scorePc == 10)
            {
                Timer.Stop(); 
                MessageBoxResult antwoord = MessageBox.Show("Helaas, de computer wint", "Wil je opniew spelen?", MessageBoxButton.YesNo);

                if (antwoord == MessageBoxResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Environment.Exit(0);
                }
            }         
        }
        private void ResetGame()
        {
            SpelerScore = 0;
            PcScore = 0;
            Text = "";
            tijd = 3;
            lblPuntSpeler.Content = "";
            lblPuntPC.Content = "";
            btnSteen.BorderBrush = Brushes.Gray;
            btnPaper.BorderBrush = Brushes.Gray;
            btnSchaar.BorderBrush = Brushes.Gray;
            Grid.SetZIndex(imgPlayer, 0);
            Grid.SetZIndex(imgPc, 0);
            Timer.Start();
            TextPlayer.Text = "";
            TextPC.Text = "";
            TextPlayer.Background = Brushes.LightBlue;
            TextPC.Background = Brushes.LightSkyBlue;
            AlgemeenPuntPC.Content = "";
            AlgemeenPuntSpeler.Content = "";
            AlgemeenPuntPC.Background = Brushes.Transparent;
            AlgemeenPuntSpeler.Background = Brushes.Transparent;
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

