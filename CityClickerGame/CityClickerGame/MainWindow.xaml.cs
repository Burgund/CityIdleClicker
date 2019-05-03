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
using System.Drawing;

namespace CityClickerGame
{
    public partial class MainWindow : Window
    {
        //Wallet contains informations about basic and multiplied PPC, PPS and total money
        public Wallet wallet = new Wallet(1);
        //All game objects (called "buildings") to buy and develop the city
        public CityObject[] buildings = new CityObject[16];
        //All textboxes contains buildings prices
        TextBox[] pricesTextBoxes = new TextBox[16];
        //All textblocks contains buildings amount
        TextBlock[] amountTextBlocks = new TextBlock[16];
        //Factory is a class for adding and changing hardcoded data
        Factory factory = new Factory();
        DispatcherTimer timer = new DispatcherTimer();
        SoundPlayer player = new SoundPlayer();
        public Achivement[] achivementsArray = new Achivement[28];
        Technology[] technologiesArray = new Technology[28];
        //backgroundsArrays contains all images for clickArea
        BackgroundImage[] backgroundsArray = new BackgroundImage[5];

        public MainWindow()
        {
            try
            {
                timer.Tick += new EventHandler(ClockEvents);
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Start();
                InitializeComponent();
                //All Factory stuff - adding hardcoded data
                factory.BuildObjectArray(buildings);
                factory.BuildAchivementsArray(achivementsArray);
                factory.CreatePrices(buildings);
                factory.BuildWindowArrays(pricesTextBoxes, amountTextBlocks);
                factory.BuildTechnologiesArray(technologiesArray);
                factory.BuildBackgroundImagesArray(backgroundsArray);
                //Initial music plays
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
            //Following code is executed each second -------------------------------
            //Add money (palms) per second and put current value into textblock
            wallet.AddMoney(wallet.GetRealMoneyPerSecond());
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);

            //Checking if it's a time to change clickArea image
            CheckForClickArea();

            //Update textblocks info about PPC and PPS
            ppsValueTextBlock.Text = Convert.ToString(wallet.GetRealMoneyPerSecond());
            ppcValueTextBlock.Text = Convert.ToString(Convert.ToInt64(wallet.GetRealMoneyPerClick()));

            //Checking for achivements depending on total money in wallet
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

        //Adding PPC to wallets total money when clickArea is clicked
        private void ClickArea_Click(object sender, RoutedEventArgs e)
        {
            wallet.AddMoney(Convert.ToUInt64(wallet.GetRealMoneyPerClick()));
            moneyAmount.Text = Convert.ToString(wallet.TotalMoney);
        }

        private void BuyObject(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string name = button.Name;
            //taking id from button to use it in buildingsArray
            int id = Convert.ToInt32(string.Join("", name.ToCharArray().Where(Char.IsDigit))) - 1;
            
            if(CheckForBuildingAvability(id))
            {
                wallet.SubstractMoney(buildings[id].Price);
                buildings[id].IncreaseAmount();
                wallet.AddMPS(buildings[id].GetRealEarnings());
                pricesTextBoxes[id].Text = Convert.ToString(buildings[id].Price);
                amountTextBlocks[id].Text = Convert.ToString(buildings[id].Amount);
                wallet.AddMoneyPerClick(buildings[id].AddMPC);

                //Checking for achivements ---------------------------------------------------
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
        }

        //Handling music
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
            Technologies technologies = new Technologies(technologiesArray);
            technologies.Owner = this;
            technologies.Show();

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
            MessageBox.Show("Not available in SynthCity alpha 1.2.1");
        }

        private void load_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not available in SynthCity alpha 1.2.1");
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

        public void SetTwentyTwo()
        {
            achivementsArray[21].IsAchived = true;
        }

        public ulong CheckMoney()
        {
            return wallet.TotalMoney;
        }

        public void DecreaseMoney(ulong price)
        {
            wallet.SubstractMoney(price);
        }

        public bool CheckForBuildingAvability(int id)
        {
            if((id == 0) || (buildings[id-1].Amount != 0))
            {
                if(id == 3)
                {
                    if (!technologiesArray[1].IsInvented)
                    {
                        MessageBox.Show("You have no technology to build this! You need " + technologiesArray[1].Name);
                        return false;
                    }
                }

                if(id == 7)
                {
                    if(!technologiesArray[2].IsInvented)
                    {
                        MessageBox.Show("You have no technology to build this! You need " + technologiesArray[2].Name);
                        return false;
                    }
                }

                if(id == 9)
                {
                    if (!technologiesArray[6].IsInvented)
                    {
                        MessageBox.Show("You have no technology to build this! You need " + technologiesArray[6].Name);
                        return false;
                    }
                }

                if(id == 13)
                {
                    if (!technologiesArray[9].IsInvented)
                    {
                        MessageBox.Show("You have no technology to build this! You need " + technologiesArray[9].Name);
                        return false;
                    }
                }

                if(id == 14)
                {
                    if (!technologiesArray[25].IsInvented)
                    {
                        MessageBox.Show("You have no technology to build this! You need " + technologiesArray[25].Name);
                        return false;
                    }
                }

                if(id == 15)
                {
                    if (!technologiesArray[26].IsInvented)
                    {
                        MessageBox.Show("You have no technology to build this! You need " + technologiesArray[26].Name);
                        return false;
                    }
                }

                if (buildings[id].Price <= wallet.TotalMoney)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Not enough money!");
                    CheckForAchivement(20);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Not available! You have to have at least one " + buildings[id-1].Name);
                return false;
            }
        }

        private void CheckForClickArea()
        {
            for (int x = 0; x < backgroundsArray.Length; x++)
            {
                if (!backgroundsArray[x].WasActive)
                {
                    if (backgroundsArray[x].PpsNeededToUnlock <= wallet.GetRealMoneyPerSecond())
                    {
                        clickArea.Source = backgroundsArray[x].Image;
                        backgroundsArray[x].WasActive = true;
                    }
                }
            }
        }
    }
}
