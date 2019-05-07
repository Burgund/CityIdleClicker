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
using System.Windows.Shapes;

namespace CityClickerGame
{
    public partial class Technologies : Window
    {
        Technology[] technologies = new Technology[28];
        TextBlock[] prices = new TextBlock[28];

        public Technologies(Technology[] technologies)
        {
            this.technologies = technologies;
            InitializeComponent();
            CreatePrices();

            foreach (Technology x in technologies)
            {
                if (x.IsInvented)
                {
                    SetInvented(x.Id);
                }
            }
        }

        private void CreatePrices()
        {
            this.techPrice1.Text = Convert.ToString(technologies[0].Price);
            this.techPrice2.Text = Convert.ToString(technologies[1].Price);
            this.techPrice3.Text = Convert.ToString(technologies[2].Price);
            this.techPrice4.Text = Convert.ToString(technologies[3].Price);
            this.techPrice5.Text = Convert.ToString(technologies[4].Price);
            this.techPrice6.Text = Convert.ToString(technologies[5].Price);
            this.techPrice7.Text = Convert.ToString(technologies[6].Price);
            this.techPrice8.Text = Convert.ToString(technologies[7].Price);
            this.techPrice9.Text = Convert.ToString(technologies[8].Price);
            this.techPrice10.Text = Convert.ToString(technologies[9].Price);
            this.techPrice11.Text = Convert.ToString(technologies[10].Price);
            this.techPrice12.Text = Convert.ToString(technologies[11].Price);
            this.techPrice13.Text = Convert.ToString(technologies[12].Price);
            this.techPrice14.Text = Convert.ToString(technologies[13].Price);
            this.techPrice15.Text = Convert.ToString(technologies[14].Price);
            this.techPrice16.Text = Convert.ToString(technologies[15].Price);
            this.techPrice17.Text = Convert.ToString(technologies[16].Price);
            this.techPrice18.Text = Convert.ToString(technologies[17].Price);
            this.techPrice19.Text = Convert.ToString(technologies[18].Price);
            this.techPrice20.Text = Convert.ToString(technologies[19].Price);
            this.techPrice21.Text = Convert.ToString(technologies[20].Price);
            this.techPrice22.Text = Convert.ToString(technologies[21].Price);
            this.techPrice23.Text = Convert.ToString(technologies[22].Price);
            this.techPrice24.Text = Convert.ToString(technologies[23].Price);
            this.techPrice25.Text = Convert.ToString(technologies[24].Price);
            this.techPrice26.Text = Convert.ToString(technologies[25].Price);
            this.techPrice27.Text = Convert.ToString(technologies[26].Price);
            this.techPrice28.Text = Convert.ToString(technologies[27].Price);
        }

        private void InventElectricity(object sender, MouseEventArgs e)
        {
            if(CheckForAvability(0))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[0].Price);
                SetInvented(1);
                technologies[0].IsInvented = true;
            }
        }

        private void InventElectronics(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(1))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[1].Price);
                SetInvented(2);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.01);
                technologies[1].IsInvented = true;
            }
        }

        private void InventRailroad(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(2))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[2].Price);
                SetInvented(3);
                technologies[2].IsInvented = true;
                if(technologies[19].IsInvented)
                {
                    CheckForAchivement(24);
                }
            }
        }

        private void InventAtomicTheory(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(3))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[3].Price);
                SetInvented(4);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.02);
                technologies[3].IsInvented = true;
                if (technologies[6].IsInvented && technologies[11].IsInvented)
                {
                    CheckForAchivement(25);
                }
            }
        }

        private void InventComputers(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(4))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[4].Price);
                SetInvented(5);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.02);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.02);
                technologies[4].IsInvented = true;
                if (technologies[8].IsInvented && technologies[16].IsInvented && technologies[21].IsInvented && technologies[27].IsInvented)
                {
                    CheckForAchivement(27);
                }
            }
        }

        private void InventEcology(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(5))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[5].Price);
                SetInvented(6);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.03);
                technologies[5].IsInvented = true;
                CheckForAchivement(23);
            }
        }

        private void InventNuclearFission(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(6))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[6].Price);
                SetInvented(7);
                technologies[6].IsInvented = true;
                if (technologies[3].IsInvented && technologies[11].IsInvented)
                {
                    CheckForAchivement(25);
                }
            }
        }

        private void InventLasers(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(7))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[7].Price);
                SetInvented(8);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.03);
                technologies[7].IsInvented = true;
            }
        }

        private void InventRobotics(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(8))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[8].Price);
                SetInvented(9);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.05);
                technologies[8].IsInvented = true;
                if (technologies[4].IsInvented && technologies[16].IsInvented && technologies[21].IsInvented && technologies[27].IsInvented)
                {
                    CheckForAchivement(27);
                }
            }
        }

        private void InventSatelites(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(9))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[9].Price);
                SetInvented(10);
                technologies[9].IsInvented = true;
                if (technologies[14].IsInvented && technologies[26].IsInvented)
                {
                    CheckForAchivement(25);
                }
            }
        }

        private void InventTheInternet(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(10))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[10].Price);
                SetInvented(11);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.02);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.05);
                technologies[10].IsInvented = true;
            }
        }

        private void InventNuclearFusion(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(11))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[11].Price);
                SetInvented(12);
                ((MainWindow)this.Owner).buildings[9].IncreaseMultiplier(1);
                technologies[11].IsInvented = true;
                if (technologies[3].IsInvented && technologies[6].IsInvented)
                {
                    CheckForAchivement(25);
                }
            }
        }

        private void InventGraphen(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(12))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[12].Price);
                SetInvented(13);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.05);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.05);
                technologies[12].IsInvented = true;
            }
        }

        private void InventAutonomusSystem(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(13))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[13].Price);
                SetInvented(14);
                ((MainWindow)this.Owner).buildings[7].IncreaseMultiplier(1);
                technologies[13].IsInvented = true;
            }
        }

        private void InventOrbitalNetworks(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(14))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[14].Price);
                SetInvented(15);
                ((MainWindow)this.Owner).buildings[13].IncreaseMultiplier(1);
                technologies[14].IsInvented = true;
                if (technologies[9].IsInvented && technologies[26].IsInvented)
                {
                    CheckForAchivement(26);
                }
            }
        }

        private void InventNanotechnology(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(15))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[15].Price);
                SetInvented(16);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.05);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.05);
                technologies[15].IsInvented = true;
            }
        }

        private void InventArtificalInteligence(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(16))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[16].Price);
                SetInvented(17);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.06);
                technologies[16].IsInvented = true;
                if (technologies[4].IsInvented && technologies[8].IsInvented && technologies[21].IsInvented && technologies[27].IsInvented)
                {
                    CheckForAchivement(27);
                }
            }
        }

        private void InventFieldTheory(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(17))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[17].Price);
                SetInvented(18);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.06);
                technologies[17].IsInvented = true;
            }
        }

        private void InventMechatronics(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(18))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[18].Price);
                SetInvented(19);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.05);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.05);
                technologies[18].IsInvented = true;
            }
        }

        private void InventMaglevTrain(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(19))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[19].Price);
                SetInvented(20);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.1);
                technologies[19].IsInvented = true;
                if (technologies[1].IsInvented)
                {
                    CheckForAchivement(24);
                }
            }
        }

        private void InventVerticalBiofarming(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(20))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[20].Price);
                SetInvented(21);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.1);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.1);
                //<TODO> overpopulation
                technologies[20].IsInvented = true;
            }
        }

        private void InventBioengineering(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(21))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[21].Price);
                SetInvented(22);
                //<TODO> random events for biotechnology here
                technologies[21].IsInvented = true;
                if (technologies[4].IsInvented && technologies[8].IsInvented && technologies[16].IsInvented && technologies[27].IsInvented)
                {
                    CheckForAchivement(27);
                }
            }
        }

        private void InventBioMetallurgy(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(22))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[22].Price);
                SetInvented(23);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(0.2);
                technologies[22].IsInvented = true;
            }
        }

        private void InventSwarmInteligence(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(23))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[23].Price);
                SetInvented(24);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerSecond(0.2);
                technologies[23].IsInvented = true;
            }
        }

        private void InventHyperComputing(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(24))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[24].Price);
                SetInvented(25);
                //<TODO> protect from random events from Hyper Computing
                technologies[24].IsInvented = true;
            }
        }

        private void InventExoticMaterials(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(25))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[25].Price);
                SetInvented(26);
                technologies[25].IsInvented = true;
            }
        }

        private void InventPlanetEngineering(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(26))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[26].Price);
                SetInvented(27);
                technologies[26].IsInvented = true;
                if (technologies[14].IsInvented && technologies[9].IsInvented)
                {
                    CheckForAchivement(26);
                }
            }
        }

        private void InventNeuralUploading(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(27))
            {
                ((MainWindow)this.Owner).wallet.SubstractMoney(technologies[27].Price);
                SetInvented(28);
                ((MainWindow)this.Owner).wallet.AddMultiplierPerClick(1);
                technologies[27].IsInvented = true;
                if (technologies[4].IsInvented && technologies[8].IsInvented && technologies[16].IsInvented && technologies[21].IsInvented)
                {
                    CheckForAchivement(27);
                }
            }
        }

        private bool CheckForAvability(int id)
        {
            if(technologies[id].IsInvented)
            {
                return false;
            }

            if(((MainWindow)this.Owner).CheckMoney() < technologies[id].Price)
            {
                ((MainWindow)this.Owner).CallMessageWindow("You dont have enough money! " + technologies[id].Name + " price is " + technologies[id].Price);
                return false;
            }

            return true;
        }

        public void SetInvented(int number)
        {
            switch (number)
            {
                case 1:
                    this.technology1.Source = new BitmapImage(new Uri("Resources/tech01.PNG", UriKind.Relative));
                    break;
                case 2:
                    this.technology2.Source = new BitmapImage(new Uri("Resources/tech02.PNG", UriKind.Relative));
                    break;
                case 3:
                    this.technology3.Source = new BitmapImage(new Uri("Resources/tech03.PNG", UriKind.Relative));
                    break;
                case 4:
                    this.technology4.Source = new BitmapImage(new Uri("Resources/tech04.PNG", UriKind.Relative));
                    break;
                case 5:
                    this.technology5.Source = new BitmapImage(new Uri("Resources/tech05.PNG", UriKind.Relative));
                    break;
                case 6:
                    this.technology6.Source = new BitmapImage(new Uri("Resources/tech06.PNG", UriKind.Relative));
                    break;
                case 7:
                    this.technology7.Source = new BitmapImage(new Uri("Resources/tech07.PNG", UriKind.Relative));
                    break;
                case 8:
                    this.technology8.Source = new BitmapImage(new Uri("Resources/tech08.PNG", UriKind.Relative));
                    break;
                case 9:
                    this.technology9.Source = new BitmapImage(new Uri("Resources/tech09.PNG", UriKind.Relative));
                    break;
                case 10:
                    this.technology10.Source = new BitmapImage(new Uri("Resources/tech10.PNG", UriKind.Relative));
                    break;
                case 11:
                    this.technology11.Source = new BitmapImage(new Uri("Resources/tech11.PNG", UriKind.Relative));
                    break;
                case 12:
                    this.technology12.Source = new BitmapImage(new Uri("Resources/tech12.PNG", UriKind.Relative));
                    break;
                case 13:
                    this.technology13.Source = new BitmapImage(new Uri("Resources/tech13.PNG", UriKind.Relative));
                    break;
                case 14:
                    this.technology14.Source = new BitmapImage(new Uri("Resources/tech14.PNG", UriKind.Relative));
                    break;
                case 15:
                    this.technology15.Source = new BitmapImage(new Uri("Resources/tech15.PNG", UriKind.Relative));
                    break;
                case 16:
                    this.technology16.Source = new BitmapImage(new Uri("Resources/tech16.PNG", UriKind.Relative));
                    break;
                case 17:
                    this.technology17.Source = new BitmapImage(new Uri("Resources/tech17.PNG", UriKind.Relative));
                    break;
                case 18:
                    this.technology18.Source = new BitmapImage(new Uri("Resources/tech18.PNG", UriKind.Relative));
                    break;
                case 19:
                    this.technology19.Source = new BitmapImage(new Uri("Resources/tech19.PNG", UriKind.Relative));
                    break;
                case 20:
                    this.technology20.Source = new BitmapImage(new Uri("Resources/tech20.PNG", UriKind.Relative));
                    break;
                case 21:
                    this.technology21.Source = new BitmapImage(new Uri("Resources/tech21.PNG", UriKind.Relative));
                    break;
                case 22:
                    this.technology22.Source = new BitmapImage(new Uri("Resources/tech22.PNG", UriKind.Relative));
                    break;
                case 23:
                    this.technology23.Source = new BitmapImage(new Uri("Resources/tech23.PNG", UriKind.Relative));
                    break;
                case 24:
                    this.technology24.Source = new BitmapImage(new Uri("Resources/tech24.PNG", UriKind.Relative));
                    break;
                case 25:
                    this.technology25.Source = new BitmapImage(new Uri("Resources/tech25.PNG", UriKind.Relative));
                    break;
                case 26:
                    this.technology26.Source = new BitmapImage(new Uri("Resources/tech26.PNG", UriKind.Relative));
                    break;
                case 27:
                    this.technology27.Source = new BitmapImage(new Uri("Resources/tech27.PNG", UriKind.Relative));
                    break;
                case 28:
                    this.technology28.Source = new BitmapImage(new Uri("Resources/tech28.PNG", UriKind.Relative));
                    break;
            }
        }

        public void CheckForAchivement(int x)
        {
            if (!((MainWindow)this.Owner).achivementsArray[x].IsAchived)
            {
                ((MainWindow)this.Owner).achivementsArray[x].IsAchived = true;
                ((MainWindow)this.Owner).achivementsArray[x].WhenAchived();
            }
        }
    }
}
