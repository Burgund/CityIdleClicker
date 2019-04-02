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
using System.Windows.Threading;

namespace CityClickerGame
{
    public partial class MainWindow : Window
    {
        Wallet wallet = new Wallet(1);
        CityObject[] buildings = new CityObject[16];
        Factory factory = new Factory();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            timer.Tick += new EventHandler(clockEvents);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            factory.BuildObjectArray(buildings);
            InitializeComponent();
        }

        private void clockEvents(object sender, EventArgs e)
        {
            wallet.AddMoney(wallet.MoneyPerSecond);
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);
        }

        private void clickArea_Click(object sender, RoutedEventArgs e)
        {
            wallet.AddMoney(wallet.MoneyPerClick);
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);
        }
    }
}
