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
        TextBox[] pricesTextBoxes = new TextBox[16];
        TextBlock[] amountTextBlocks = new TextBlock[16];
        Factory factory = new Factory();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            timer.Tick += new EventHandler(ClockEvents);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            factory.BuildObjectArray(buildings);
            InitializeComponent();
            factory.CreatePrices(buildings);
            factory.BuildWindowArrays(pricesTextBoxes, amountTextBlocks);
        }

        private void ClockEvents(object sender, EventArgs e)
        {
            wallet.AddMoney(wallet.MoneyPerSecond);
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);
        }

        private void ClickArea_Click(object sender, RoutedEventArgs e)
        {
            wallet.AddMoney(wallet.MoneyPerClick);
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);
        }

        private void BuyObject(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string name = button.Name;
            int id = Convert.ToInt32(string.Join("", name.ToCharArray().Where(Char.IsDigit))) - 1;
            
            if(buildings[id].Price <= wallet.TotalMoney)
            {
                wallet.SubstractMoney(buildings[id].Price);
                buildings[id].IncreaseAmount();
                wallet.AddMPS(buildings[id].Earnings);
                pricesTextBoxes[id].Text = Convert.ToString(buildings[id].Price);
                amountTextBlocks[id].Text = Convert.ToString(buildings[id].Amount);
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }
    }
}
