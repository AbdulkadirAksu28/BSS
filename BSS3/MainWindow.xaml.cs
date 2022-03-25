using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Microsoft.VisualBasic;

namespace BSS3
{
    /// -----------------------------------------
    /// Auteur:     Abdulkadir Aksu
    /// Datum:      08/01/2021
    /// Descriptie: Werkplekleren 1 Project Blad-Steen-Schaar
    /// -----------------------------------------
    public partial class MainWindow : Window
    {
        private int spelerScore = 0, pcScore = 0, aantalSpelerBlad = 0, aantalSpelerSchaar = 0, aantalSpelerSteen = 0, aantalPcBlad = 0, aantalPcSchaar = 0, aantalPcSteen = 0;
        private string text = "";
        private int tijd = 3;
        private DispatcherTimer timer;
        private const string Paper = "Blad";
        private const string Scissors = "Schaar";
        private const string Rock = "Steen";

        public MainWindow()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Beginnen van het spel.
        /// <para>Zal ervoor zorgen dat je op de buttons kan klikken.</para>
        /// </summary>
        private void StartBtn(object sender, RoutedEventArgs e)
        {
            Timer();
            startBtn.IsEnabled = false;
            startBtn.Background = Brushes.Transparent;
            btnPaper.Visibility = Visibility.Visible;
            btnSchaar.Visibility = Visibility.Visible;
            btnSteen.Visibility = Visibility.Visible;
            imgPlayer.Visibility = Visibility.Visible;
            imgPc.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// De afbeeldingen krijgen een andere kleur wanneer de muis over de button hovert.
        /// </summary>
        private void BtnEnter(object sender, MouseEventArgs e)
        {
            if (e.Source == btnSchaar)
            {
                btnSchaar.Content = new Image() { Source = new BitmapImage(new Uri(@"images\scissors.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill };
            }
            else if (e.Source == btnPaper)
            {
                btnPaper.Content = new Image() { Source = new BitmapImage(new Uri(@"images\papers.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill };
            }
            else
            {
                btnSteen.Content = new Image() { Source = new BitmapImage(new Uri(@"images\rock.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill };
            }
        }
        /// <summary>
        /// De afbeeldingen krijgen terug hun originele lay-out na het verlaten van de muis over de button.
        /// </summary>
        private void BtnLeave(object sender, MouseEventArgs e)
        {
            if (e.Source == btnSchaar)
            {
                btnSchaar.Content = new Image() { Source = new BitmapImage(new Uri(@"images\scissorstint.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill };
            }
            else if (e.Source == btnPaper)
            {
                btnPaper.Content = new Image() { Source = new BitmapImage(new Uri(@"images\paper-tint.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill };
            }
            else
            {
                btnSteen.Content = new Image() { Source = new BitmapImage(new Uri(@"images\rock-tint.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill };
            }
        }
        /// <summary>
        /// Aanmaak van timer die elk seconde tikt.
        /// </summary>
        private void Timer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        /// <summary>
        /// Aanmaak van timer die daalt en stop bij 0.
        /// <para>Kleurverandering naard rood van de timer indien het kleiner dan 2 is.</para>
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tijd > 0)
            {
                tijd--;
            }
            else
            {
                timer.Stop();
                TijdOp();
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
            lblPuntSpeler.Content = spelerScore;
            lblPuntPC.Content = pcScore;
        }
        /// <summary>
        /// Wanneer het tijd op is zal de computer winnen en de timer zal herstarten.
        /// </summary>
        private void TijdOp()
        {
            if (tijd == 0)
            {
                algemeenPuntSpeler.Content = "LOSER";
                algemeenPuntPC.Content = "WINNAAR";
                textPlayer.Background = Brushes.DarkRed;
                textPC.Background = Brushes.DarkGreen;
                pcScore += 1;
                imgPlayer.Content = new Image() { Source = new BitmapImage(new Uri(@"images\time.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill }; ;
                imgPc.Content = new Image() { Source = new BitmapImage(new Uri(@"images\time.png", UriKind.RelativeOrAbsolute)), Stretch = Stretch.Fill }; ;
                VerhoogZindex(imgPlayer);
                VerhoogZindex(imgPc);
                tijd = 4;
                lblTijd.Content = string.Format("{0}", tijd % 60 - 1);
                timer.Start();
            }
        }
        /// <summary>
        /// Genereert de keuze van de computer.
        /// </summary>
        /// <param name="tekst">Keuze van de computer.</param>
        private void KeuzeComputer(ref string tekst)
        {
            Random rnd = new Random();
            int randomGtl = rnd.Next(1, 4);
            if (randomGtl == 1)
            {
                text = Paper;
            }
            else if (randomGtl == 2)
            {
                text = Rock;
            }
            else
            {
                text = Scissors;
            }
        }
        /// <summary>
        /// De activiteiten dat er geberut wanneer je op een button klikt, bepaald aan de button zal de correcte borderkleuren aangepast worden.
        /// </summary>
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            btnSchaar.BorderBrush = Brushes.Gray;
            btnSteen.BorderBrush = Brushes.Gray;
            btnPaper.BorderBrush = Brushes.Gray;
            (e.Source as Button).BorderBrush = Brushes.Black;
            if (e.Source == btnPaper)
            {
                textPlayer.Text = Paper;                
            }
            else if (e.Source == btnSchaar)
            {
                textPlayer.Text = Scissors;
            }
            else
            {
                textPlayer.Text = Rock;             
            }
            ButtonActiviteit();
        }
        /// <summary>
        /// Verhoogd een button zijn Z-index.
        /// </summary>
        private void VerhoogZindex(Button but)
        {
            Grid.SetZIndex(but, 5);
        }
        /// <summary>
        /// Bepaald aan de knop dat geklikt word zal de correcte foto tevoorkomen.
        /// </summary>
        private Image FotoKeuze(string tekst)
        {
            Image afb = new Image();

            if (tekst == Paper)
            {
                afb.Source = new BitmapImage(new Uri(@"images\papers.png", UriKind.RelativeOrAbsolute));
            }
            else if (tekst == Rock)
            {
                afb.Source = new BitmapImage(new Uri(@"images\rock.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                afb.Source = new BitmapImage(new Uri(@"images\scissors.png", UriKind.RelativeOrAbsolute));
            }
            afb.Stretch = Stretch.Fill;
            return afb;
        }
        /// <summary>
        /// De activiteiten dat een button doet wanneer er op geklikt zal worden.
        /// </summary>
        private void ButtonActiviteit()
        {
            KeuzeComputer(ref text);
            textPC.Text = text;
            Voorwaarden(ref spelerScore, ref pcScore);
            imgPlayer.Content = FotoKeuze(textPlayer.Text);
            imgPc.Content = FotoKeuze(textPC.Text);
            VerhoogZindex(imgPlayer);
            VerhoogZindex(imgPc);
            tijd = 4;
            lblTijd.Content = string.Format("{0}", tijd % 60 - 1);
            timer.Start();
            PlayerAantal(textPlayer.Text);
            PcAantal(textPC.Text);
            lblAantalPcBlad.Content = aantalPcBlad;
            lblAantalPcSchaar.Content = aantalPcSchaar;
            lblAantalPcSteen.Content = aantalPcSteen;
            lblAantalSpelerBlad.Content = aantalSpelerBlad;
            lblAantalSpelerSchaar.Content = aantalSpelerSchaar;
            lblAantalSpelerSteen.Content = aantalSpelerSteen;
            EindeGame(ref spelerScore, ref pcScore);          
        }
        /// <summary>
        /// Aanmaak van de historiek als de speler wint.
        /// <para>Naam van de speler en computer, de score en tijd is gegeven.</para>
        /// </summary>
        private void HistoriekAanmaken()
        {
            StringBuilder historiek = new StringBuilder();
            DateTime tijdVandaag = DateTime.Now;
            string wintijd = tijdVandaag.ToLongTimeString();
            if (spelerScore == 10)
            {
                historiek.AppendFormat("{0} - {1} {2} - {3} ({4}) \n", playerName.Content, naamPc.Content, spelerScore, pcScore, wintijd);
            }
            historiekText.Text = historiek.ToString() + historiekText.Text;
        }
        /// <summary>
        /// <para>Wanneer de speler of de computer 10 punten scoort zal er gevraagd worden of de speler verder wilt spelen of niet.</para>
        /// <para>Wanneer de speler of de computer 10 punten scoort zal er gevraagd worden voor de naam van de speler.</para>
        /// </summary>
        private void EindeGame(ref int scoreSpeler, ref int scorePc)
        {
            if (scoreSpeler == 10 || scorePc == 10)
            {
                timer.Stop();
                string name = Interaction.InputBox("Schrijf je naam", "Speler naam", (string) playerName.Content, 50, 50);
                playerName.Content = name;
                if ((string)playerName.Content == "")
                {
                    playerName.Content = "Anonieme speler";
                }
                HistoriekAanmaken();
                if (scoreSpeler == 10)
                {
                    MessageBoxResult antwoord = MessageBox.Show("Wil je opnieuw spelen?", "Proficiat jij wint", MessageBoxButton.YesNo);

                    if (antwoord == MessageBoxResult.Yes)
                    {
                        ResetGame();
                    }
                    else
                    {
                        //Environment.Exit(0);
                        Close();
                    }
                }
                else if (scorePc == 10)
                {
                    timer.Stop();
                    MessageBoxResult antwoord = MessageBox.Show("Wil je opnieuw spelen?", "Helaas, de computer wint", MessageBoxButton.YesNo);

                    if (antwoord == MessageBoxResult.Yes)
                    {
                        ResetGame();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }
        /// <summary>
        /// Resetten van de gegevens om opnieuw te beginnen wanner de speler klikt om terug te spelen.
        /// </summary>
        private void ResetGame()
        {
            spelerScore = 0;
            pcScore = 0;
            text = "";
            tijd = 3;
            lblPuntSpeler.Content = ""; lblPuntPC.Content = "";
            btnSteen.BorderBrush = Brushes.Gray; btnPaper.BorderBrush = Brushes.Gray; btnSchaar.BorderBrush = Brushes.Gray;
            Grid.SetZIndex(imgPlayer, 0);
            Grid.SetZIndex(imgPc, 0);
            timer.Start();
            textPlayer.Text = "";
            textPC.Text = "";
            textPlayer.Background = Brushes.LightBlue;
            textPC.Background = Brushes.LightSkyBlue;
            algemeenPuntPC.Content = "";
            algemeenPuntSpeler.Content = "";
            algemeenPuntPC.Background = Brushes.Transparent;
            algemeenPuntSpeler.Background = Brushes.Transparent;
            aantalSpelerSteen = 0; aantalSpelerSchaar = 0; aantalSpelerBlad = 0; aantalPcSteen = 0; aantalPcSchaar = 0; aantalPcBlad = 0;
            lblAantalSpelerSteen.Content = ""; lblAantalSpelerSchaar.Content = ""; lblAantalSpelerBlad.Content = "";
            lblAantalPcSteen.Content = ""; lblAantalPcSchaar.Content = ""; lblAantalPcBlad.Content = "";
        }
        /// <summary>
        /// <para>Laat aantal keren blad gekozen door de speler up-to-date.</para>
        /// <para>Laat aantal keren steen gekozen door de speler up-to-date.</para>
        /// <para>Laat aantal keren schaar gekozen door de speler up-to-date.</para>
        /// </summary>
        private void PlayerAantal(string keuze)
        {
            if (keuze == Paper)
            {
                aantalSpelerBlad++;
            }
            else if (keuze == Scissors)
            {
                aantalSpelerSchaar++;
            }
            else if (keuze == Rock)
            {
                aantalSpelerSteen++;
            }
        }
        /// <summary>
        /// <para>Laat aantal keren blad gekozen door de computer up-to-date.</para>
        /// <para>Laat aantal keren steen gekozen door de computer up-to-date.</para>
        /// <para>Laat aantal keren schaar gekozen door de computer up-to-date.</para>
        /// </summary>
        private void PcAantal(string keuze)
        {
            if (keuze == Paper)
            {
                aantalPcBlad++;
            }
            else if (keuze == Scissors)
            {
                aantalPcSchaar++;
            }
            else if (keuze == Rock)
            {
                aantalPcSteen++;
            }
        }
        /// <summary>
        /// <para>Logica van het spel.</para>
        /// <para>Puntenverandering aan de hand van de winnaar.</para>
        /// <para>Kleurenverandering aan de hand van de winnaar.</para>
        /// </summary>
        private void Voorwaarden(ref int puntSpeler, ref int puntPc)
        {
            string playerKeuze = textPlayer.Text;
            string pcKeuze = textPC.Text;
            if (playerKeuze == "Blad" && pcKeuze == "Steen" ||
                playerKeuze == "Steen" && pcKeuze == "Schaar" ||
                playerKeuze == "Schaar" && pcKeuze == "Blad")
            {
                algemeenPuntSpeler.Content = "WINNAAR";
                algemeenPuntPC.Content = "LOSER";
                textPlayer.Background = Brushes.DarkGreen;
                textPC.Background = Brushes.DarkRed;
                puntSpeler += 1;
            }
            else if
                (pcKeuze == "Blad" && playerKeuze == "Steen" ||
                 pcKeuze == "Steen" && playerKeuze == "Schaar" ||
                 pcKeuze == "Schaar" && playerKeuze == "Blad")
            {
                algemeenPuntSpeler.Content = "LOSER";
                algemeenPuntPC.Content = "WINNAAR";
                textPlayer.Background = Brushes.DarkRed;
                textPC.Background = Brushes.DarkGreen;
                puntPc += 1;
            }
            else
            {
                algemeenPuntSpeler.Content = "gelijkspel";
                algemeenPuntPC.Content = "gelijkspel";
                textPlayer.Background = Brushes.DimGray;
                textPC.Background = Brushes.DimGray;
            }
            lblPuntSpeler.Content = spelerScore;
            lblPuntPC.Content = pcScore;
            algemeenPuntSpeler.Background = Brushes.AntiqueWhite;
            algemeenPuntPC.Background = Brushes.AntiqueWhite;
        }
    }
}

