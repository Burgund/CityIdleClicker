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

            }
        }

        private void InventRailroad(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(1))
            {

            }
        }

        private void InventElectronics(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(2))
            {

            }
        }

        private void InventAtomicTheory(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(3))
            {

            }
        }

        private void InventComputers(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(4))
            {

            }
        }

        private void InventEcology(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(5))
            {

            }
        }

        private void InventNuclearFission(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(6))
            {

            }
        }

        private void InventLasers(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(7))
            {

            }
        }

        private void InventRobotics(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(8))
            {

            }
        }

        private void InventSatelites(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(9))
            {

            }
        }

        private void InventTheInternet(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(10))
            {

            }
        }

        private void InventNuclearFusion(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(11))
            {

            }
        }

        private void InventGraphen(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(12))
            {

            }
        }

        private void InventAutonomusSystem(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(13))
            {

            }
        }

        private void InventOrbitalNetworks(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(14))
            {

            }
        }

        private void InventNanotechnology(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(15))
            {

            }
        }

        private void InventArtificalInteligence(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(16))
            {

            }
        }

        private void InventFieldTheory(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(17))
            {

            }
        }

        private void InventMechatronics(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(18))
            {

            }
        }

        private void InventMaglevTrain(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(19))
            {

            }
        }

        private void InventVerticalBiofarming(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(20))
            {

            }
        }

        private void InventBioengineering(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(21))
            {

            }
        }

        private void InventBioMetallurgy(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(22))
            {

            }
        }

        private void InventSwarmInteligence(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(23))
            {

            }
        }

        private void InventHyperComputing(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(24))
            {

            }
        }

        private void InventExoticMaterials(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(25))
            {

            }
        }

        private void InventPlanetEngineering(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(26))
            {

            }
        }

        private void InventNeuralUploading(object sender, MouseEventArgs e)
        {
            if (CheckForAvability(27))
            {

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
                MessageBox.Show("You dont have enough money! " + technologies[id].Name + " price is " + technologies[id].Price);
                return false;
            }

            return true;
        }
    }
}
