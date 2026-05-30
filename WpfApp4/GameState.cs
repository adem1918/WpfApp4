using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class GameState
    {
        public double Cookies { get; set; }
        public double CookiesPerClick { get; set; }
        public double CookiesPerSecond { get; set; }
        public int TotalClicks { get; set; }
        public int TotalUpgradesBought { get; set; }

        public GameState()
        {
            Cookies = 0;
            CookiesPerClick = 1;
            CookiesPerSecond = 0;
            TotalClicks = 0;
            TotalUpgradesBought = 0;
        }   
    }
}
