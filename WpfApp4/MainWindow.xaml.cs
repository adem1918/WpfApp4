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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameState gameState;
        Obchod obchod;
        public MainWindow()
        {
            InitializeComponent();
            gameState = new GameState();
           
        }

       

        private void Passatbutton_Click(object sender, RoutedEventArgs e)
        {
            gameState.Cookies += gameState.CookiesPerClick;
            lblPocetPassatu.Content = $"Počet Passatů: {gameState.Cookies}";
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