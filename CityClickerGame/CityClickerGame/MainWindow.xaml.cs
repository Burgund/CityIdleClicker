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
        SoundPlayer player = new SoundPlayer();
        Achivement[] achivementsArray = new Achivement[28];

        public MainWindow()
        {
            try
            {
                timer.Tick += new EventHandler(ClockEvents);
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Start();
                factory.BuildObjectArray(buildings);
                factory.BuildAchivementsArray(achivementsArray);
                InitializeComponent();
                factory.CreatePrices(buildings);
                factory.BuildWindowArrays(pricesTextBoxes, amountTextBlocks);
                MusicPlays();
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("-----------------------------------------------------------------");
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        private void ClockEvents(object sender, EventArgs e)
        {
            wallet.AddMoney(wallet.MoneyPerSecond);
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);
            if (wallet.TotalMoney >= 10000)
            {
                CheckForAchivement(4);
            }

            if (wallet.TotalMoney >= 1000000)
            {
                CheckForAchivement(5);
            }

            if (wallet.TotalMoney >= 1000000000)
            {
                CheckForAchivement(6);
            }

            if (wallet.TotalMoney >= 1000000000000)
            {
                CheckForAchivement(7);
            }

            if (wallet.TotalMoney >= 1000000000000000)
            {
                CheckForAchivement(8);
            }

            if (wallet.TotalMoney >= 1000000000000000000)
            {
                CheckForAchivement(9);
            }
        }

        private void ClickArea_Click(object sender, RoutedEventArgs e)
        {
            wallet.AddMoney(Convert.ToUInt64(wallet.MoneyPerClick));
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
                wallet.AddMoneyPerClick(buildings[id].AddMPC);

                CheckForAchivement(10);

                if (id == 15)
                {
                    CheckForAchivement(11);
                }

                if (buildings[id].Amount >= 100)
                {
                    CheckForAchivement(12);
                }

                if (wallet.MoneyPerClick >= 10)
                {
                    CheckForAchivement(13);
                }

                if (wallet.MoneyPerClick >= 100)
                {
                    CheckForAchivement(14);
                }

                if (wallet.MoneyPerClick >= 1000)
                {
                    CheckForAchivement(15);
                }

                if (wallet.MoneyPerClick >= 1000000)
                {
                    CheckForAchivement(16);
                }

                if (wallet.MoneyPerSecond >= 100)
                {
                    CheckForAchivement(17);
                }

                if (wallet.MoneyPerSecond >= 9000)
                {
                    CheckForAchivement(18);
                }

                if (wallet.MoneyPerSecond >= 10000000)
                {
                    CheckForAchivement(19);
                }
            }
            else
            {
                MessageBox.Show("Not enough money!");

                CheckForAchivement(20);
            }
        }

        private void MusicPlays()
        {
            try
            {
                player.Stream = Properties.Resources.Airglow___03___Electrifying_Landscape__online_audio_converter_com_;
                player.PlayLooping();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("-----------------------------------------------------------------");
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            //falling down is the same as being hit by a planet
            //music plays
        }

        private void achivements_button_Click(object sender, RoutedEventArgs e)
        {
            Achivements achivements = new Achivements(achivementsArray);
            achivements.Owner = this;
            achivements.Show();

            CheckForAchivement(2);
        }

        private void technologies_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not available in SynthCity alpha 1.0.2");
            CheckForAchivement(22);
        }

        private void credits_button_Click(object sender, RoutedEventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
            CheckForAchivement(1);
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not available in SynthCity alpha 1.0.2");
        }

        private void load_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not available in SynthCity alpha 1.0.2");
            CheckForAchivement(3);
        }

        private void music_button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)music_button.Content == "MUSIC")
            {
                player.Stop();
                music_button.Content = "PLAY MUSIC";
                CheckForAchivement(0);
            }
            else
            {
                player.PlayLooping();
                music_button.Content = "MUSIC";
            }
        }

        public void CheckForAchivement(int x)
        {
            if (!achivementsArray[x].IsAchived)
            {
                achivementsArray[x].IsAchived = true;
                achivementsArray[x].WhenAchived();
            }
        }
    }
}
