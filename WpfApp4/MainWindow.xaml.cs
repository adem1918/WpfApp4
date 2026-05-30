using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        GameState gameState;
        Obchod obchod;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            gameState = new GameState();
           
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Passatbutton_Click(object sender, RoutedEventArgs e)
        {
            gameState.Cookies += gameState.CookiesPerClick;
            gameState.TotalClicks++;
            lblPocetPassatu.Content = $"Počet passatů: {gameState.Cookies}";
            lblPocetKliknuti.Content = $"Počet kliknuti: {gameState.TotalClicks}";
            lblPassatyZaKlik.Content = $"Passatů za klik: {gameState.CookiesPerClick}";
            lblPocetVyleps.Content = $"Počet vylepšení: {gameState.TotalUpgradesBought}";
            lblPassatySekund.Content = $"Passatů za sekundu: {gameState.CookiesPerSecond}";
            SystemSounds.Beep.Play();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            gameState.Cookies += gameState.CookiesPerSecond;
            lblPocetPassatu.Content = $"Počet passatů: {gameState.Cookies}";
            lblPocetKliknuti.Content = $"Počet kliknuti: {gameState.TotalClicks}";
            lblPassatyZaKlik.Content = $"Passatů za klik: {gameState.CookiesPerClick}";
            lblPocetVyleps.Content = $"Počet vylepšení: {gameState.TotalUpgradesBought}";
            lblPassatySekund.Content = $"Passatů za sekundu: {gameState.CookiesPerSecond}";
        }

        private void Obchodbutton_Click(object sender, RoutedEventArgs e)
        {
            if (obchod == null)
            {
                obchod = new Obchod(gameState);
                obchod.Show();
            }
            else
            {
                obchod.Activate();
            }
        }
    }
}