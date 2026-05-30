using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace WpfApp4
{
    public partial class Obchod : Window
    {
        GameState gameState;
        double price1 = 10;
        double price2 = 50;
        double price3 = 100;
        double price4 = 500;
        double price5 = 2500;

        public Obchod(GameState gameState)
        {
            InitializeComponent();
            this.gameState = gameState;

            firstcena.Content = price1;
            secondcena.Content = price2;
            thirdcena.Content = price3;
            fourthcena.Content = price4;
            fifthcena.Content = price5;
        }
      
        private void upgrade1(object sender, RoutedEventArgs e)
        {
            if (gameState.Cookies >= price1)
            {
                gameState.Cookies -= price1;
                gameState.CookiesPerClick += 1;
                price1 *= 1.5;
                firstcena.Content = price1.ToString();
                gameState.TotalUpgradesBought++;
                SystemSounds.Beep.Play();
            }
            else
            {
                MessageBox.Show("Mas malo passatu!!");
            }
        }
      

        private void upgrade2(object sender, RoutedEventArgs e)
        {
            if (gameState.Cookies >= price2)
            {
                gameState.Cookies -= price2;
                gameState.CookiesPerClick += 4;
                price2 *= 1.5;
                secondcena.Content = price2.ToString();
                gameState.TotalUpgradesBought++;
                SystemSounds.Beep.Play();
            }
            else
            {
                MessageBox.Show("Mas malo passatu!!");
            }
        }
        private void upgrade3(object sender, RoutedEventArgs e)
        {
            if (gameState.Cookies >= price3)
            {
                gameState.Cookies -= price3;
                gameState.CookiesPerSecond += 1;
                price3 *= 1.5;
                thirdcena.Content = price3.ToString();
                gameState.TotalUpgradesBought++;
                SystemSounds.Beep.Play();
            }
            else
            {
                MessageBox.Show("Mas malo passatu!!");
            }
        }
        private void upgrade4(object sender, RoutedEventArgs e)
        {
            if (gameState.Cookies >= price4)
            {
                gameState.Cookies -= price4;
                gameState.CookiesPerSecond += 5;
                price4 *= 1.5;
                fourthcena.Content = price4.ToString();
                gameState.TotalUpgradesBought++;
                SystemSounds.Beep.Play();
            }
            else
            {
                MessageBox.Show("Mas malo passatu!!");
            }
        }
        private void upgrade5(object sender, RoutedEventArgs e)
        {
            if (gameState.Cookies >= price5)
            {
                gameState.Cookies -= price5;
                gameState.CookiesPerSecond += 25;
                price5 *= 1.5;
                fifthcena.Content = price5.ToString();
                gameState.TotalUpgradesBought++;
                SystemSounds.Beep.Play();
            }
            else
            {
                MessageBox.Show("Mas malo passatu!!");
            }
        }
    }
}
