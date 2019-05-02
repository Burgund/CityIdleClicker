using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    class Factory
    {
        public void BuildTechnologiesArray(Technology[] technologies)
        {
            technologies[0] = new Technology("Electricity", "+1% PPS", 1, 1000);
            technologies[1] = new Technology("Electronics", "Unlocks energy lines", 2, 2000);
            technologies[2] = new Technology("Railroad", "Unlocks railstations", 3, 5000);
            technologies[3] = new Technology("Atomic theory", "+2% PPS", 4, 10000);
            technologies[4] = new Technology("Computers", "+2% PPS and +2% PPC", 5, 20000);
            technologies[5] = new Technology("Ecology", "+3% PPC", 6, 50000);
            technologies[6] = new Technology("Nuclear Fission", "Unlocks Nuclear Power Plant", 7, 100000);
            technologies[7] = new Technology("Lasers", "+3% PPC", 8, 200000);
            technologies[8] = new Technology("Robotics", "+5% PPC", 9, 500000);
            technologies[9] = new Technology("Satelites", "Unlocks Space Port", 10, 1000000);
            technologies[10] = new Technology("The Internet", "+5% PPC and +2% PPS", 11, 2000000);
            technologies[11] = new Technology("Nuclear Fusion", "New Nuclear Power Plants are twice as effective", 12, 5000000);
            technologies[12] = new Technology("Graphen", "+5% PPC and +5% PPS", 13, 10000000);
            technologies[13] = new Technology("Autonomus System", "New Trains are twice as effective", 14, 20000000);
            technologies[14] = new Technology("Orbital Networks", "New Space Ports are twice as effective", 15, 50000000);
            technologies[15] = new Technology("Nanotechnology", "+5% PPC and +5% PPS", 16, 100000000);
            technologies[16] = new Technology("Artifical Inteligence", "+6% PPS", 17, 200000000);
            technologies[17] = new Technology("Field Theory", "+6% PPC", 18, 500000000);
            technologies[18] = new Technology("Mechatronics", "+5% PPC and +5% PPS", 19, 1000000000);
            technologies[19] = new Technology("Maglev Train", "+10% PPC", 20, 2000000000);
            technologies[20] = new Technology("Vertical Bio-farming", "+10% PPC and +10% PPS but may cause overpopulation! [Warning! You CAN'T undo this]", 21, 5000000000);
            technologies[21] = new Technology("Bioengineering", "Bioengineering is always risky... What would happend? [Warning! You CAN'T undo this]", 22, 10000000000);
            technologies[22] = new Technology("Bio-Metallurgy", "+20% PPC", 23, 20000000000);
            technologies[23] = new Technology("Swarm Inteligence", "+20% PPS", 24, 50000000000);
            technologies[24] = new Technology("Hyper Computing", "Protects you from devastating events", 25, 100000000000);
            technologies[25] = new Technology("Exotic Materials", "Unlocks second most expensive building", 26, 200000000000);
            technologies[26] = new Technology("Planet Engineering", "Unlocks the most expensive building", 27, 500000000000);
            technologies[27] = new Technology("Neural Uploading", "+100% PPC", 28, 1000000000000);
        }

        public void BuildAchivementsArray(Achivement[] achivements)
        {
            achivements[0] = new Achivement("Focus", "Turn off music ", 1);
            achivements[1] = new Achivement("Curiostity", "Open credits window", 2);
            achivements[2] = new Achivement("Gon on!", "Open achivements window", 3);
            achivements[3] = new Achivement("Louder!", "Load game", 4);
            achivements[4] = new Achivement("Poor guy", "Collect 10000 (10 tousand palms)", 5);
            achivements[5] = new Achivement("Your first car!", "Collect 1000000 (million palms)", 6);
            achivements[6] = new Achivement("Cream of the crop", "Collect 1000000000 (milliard palms)", 7);
            achivements[7] = new Achivement("Businessman", "Collect 1000000000000 (billion palms)", 8);
            achivements[8] = new Achivement("Rockefeller, is it you?", "Collect 1000000000000000 (billiard palms)", 9);
            achivements[9] = new Achivement("Golden Pepe apeared", "Collect 1000000000000000000 (Trillion palms)", 10);
            achivements[10] = new Achivement("Wow!", "Build your first building", 11);
            achivements[11] = new Achivement("Amazing!", "Build the most expensive building", 12);
            achivements[12] = new Achivement("Stahp!", "Have at least 100 buildings of whichever kind", 13);
            achivements[13] = new Achivement("A", "Have 10 PPC", 14);
            achivements[14] = new Achivement("B", "Have 100 PPC", 15);
            achivements[15] = new Achivement("C", "Have 1000 PPC", 16);
            achivements[16] = new Achivement("D", "Have 1000000 PPC", 17);
            achivements[17] = new Achivement("Newbie", "Have 100 PPS", 18);
            achivements[18] = new Achivement("It's over 9000!!!11", "Have 9000 PPS", 19);
            achivements[19] = new Achivement("Global Elite", "Have 10000000 PPS", 20);
            achivements[20] = new Achivement("Motion defeated", "Try to buy something without enough money", 21);
            achivements[21] = new Achivement("What are you doing?!", "Click this achivement", 22);
            achivements[22] = new Achivement("Geek", "Open technologies window", 23);
            achivements[23] = new Achivement("Ecologist", "Invent Ecology", 24);
            achivements[24] = new Achivement("Wooosh", "Invent Railroads and Maglev Train", 25);
            achivements[25] = new Achivement("DEFCON 1", "Invent Nuclear Fission, Fusion and Atomic Theory", 26);
            achivements[26] = new Achivement("Sky is the limit", "Invent Satelites, Orbital Networks and Planet Engineering", 27);
            achivements[27] = new Achivement("Cyborg", "Invite Computers, Robotics, AI, Bioengineering and Neural Uploading", 28);
        }

        public void BuildObjectArray(CityObject[] buildings)
        {
            buildings[0] = new CityObject(100, 1, 0.1);
            buildings[1] = new CityObject(600, 2, 0.2);
            buildings[2] = new CityObject(1200, 5, 0.5);
            buildings[3] = new CityObject(3000, 10, 1);
            buildings[4] = new CityObject(8000, 25, 2.5);
            buildings[5] = new CityObject(15000, 100, 4);
            buildings[6] = new CityObject(100000, 900, 10);
            buildings[7] = new CityObject(150000, 1200, 12);
            buildings[8] = new CityObject(250000, 1600, 15);
            buildings[9] = new CityObject(500000, 2500, 22);
            buildings[10] = new CityObject(1000000, 4500, 40);
            buildings[11] = new CityObject(5000000, 10000, 100);
            buildings[12] = new CityObject(10000000, 15000, 140);
            buildings[13] = new CityObject(50000000, 50000, 400);
            buildings[14] = new CityObject(100000000, 100000, 600);
            buildings[15] = new CityObject(1000000000, 2000000, 1000);
        }

        public void CreatePrices(CityObject[] buildings)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).priceOfObject1.Text = Convert.ToString(buildings[0].Price);
                    (window as MainWindow).priceOfObject2.Text = Convert.ToString(buildings[1].Price);
                    (window as MainWindow).priceOfObject3.Text = Convert.ToString(buildings[2].Price);
                    (window as MainWindow).priceOfObject4.Text = Convert.ToString(buildings[3].Price);
                    (window as MainWindow).priceOfObject5.Text = Convert.ToString(buildings[4].Price);
                    (window as MainWindow).priceOfObject6.Text = Convert.ToString(buildings[5].Price);
                    (window as MainWindow).priceOfObject7.Text = Convert.ToString(buildings[6].Price);
                    (window as MainWindow).priceOfObject8.Text = Convert.ToString(buildings[7].Price);
                    (window as MainWindow).priceOfObject9.Text = Convert.ToString(buildings[8].Price);
                    (window as MainWindow).priceOfObject10.Text = Convert.ToString(buildings[9].Price);
                    (window as MainWindow).priceOfObject11.Text = Convert.ToString(buildings[10].Price);
                    (window as MainWindow).priceOfObject12.Text = Convert.ToString(buildings[11].Price);
                    (window as MainWindow).priceOfObject13.Text = Convert.ToString(buildings[12].Price);
                    (window as MainWindow).priceOfObject14.Text = Convert.ToString(buildings[13].Price);
                    (window as MainWindow).priceOfObject15.Text = Convert.ToString(buildings[14].Price);
                    (window as MainWindow).priceOfObject16.Text = Convert.ToString(buildings[15].Price);
                }
            }
        }

        public void BuildWindowArrays(TextBox[] prices, TextBlock[] amount)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    prices[0] = (window as MainWindow).priceOfObject1;
                    prices[1] = (window as MainWindow).priceOfObject2;
                    prices[2] = (window as MainWindow).priceOfObject3;
                    prices[3] = (window as MainWindow).priceOfObject4;
                    prices[4] = (window as MainWindow).priceOfObject5;
                    prices[5] = (window as MainWindow).priceOfObject6;
                    prices[6] = (window as MainWindow).priceOfObject7;
                    prices[7] = (window as MainWindow).priceOfObject8;
                    prices[8] = (window as MainWindow).priceOfObject9;
                    prices[9] = (window as MainWindow).priceOfObject10;
                    prices[10] = (window as MainWindow).priceOfObject11;
                    prices[11] = (window as MainWindow).priceOfObject12;
                    prices[12] = (window as MainWindow).priceOfObject13;
                    prices[13] = (window as MainWindow).priceOfObject14;
                    prices[14] = (window as MainWindow).priceOfObject15;
                    prices[15] = (window as MainWindow).priceOfObject16;

                    amount[0] = (window as MainWindow).object1Amount;
                    amount[1] = (window as MainWindow).object2Amount;
                    amount[2] = (window as MainWindow).object3Amount;
                    amount[3] = (window as MainWindow).object4Amount;
                    amount[4] = (window as MainWindow).object5Amount;
                    amount[5] = (window as MainWindow).object6Amount;
                    amount[6] = (window as MainWindow).object7Amount;
                    amount[7] = (window as MainWindow).object8Amount;
                    amount[8] = (window as MainWindow).object9Amount;
                    amount[9] = (window as MainWindow).object10Amount;
                    amount[10] = (window as MainWindow).object11Amount;
                    amount[11] = (window as MainWindow).object12Amount;
                    amount[12] = (window as MainWindow).object13Amount;
                    amount[13] = (window as MainWindow).object14Amount;
                    amount[14] = (window as MainWindow).object15Amount;
                    amount[15] = (window as MainWindow).object16Amount;
                }
            }
        }

        public void BuildBackgroundImagesArray(BackgroundImage[] images)
        {
            images[0] = new BackgroundImage(new BitmapImage(new Uri("Resources/clickAreaBackground2.png", UriKind.Relative)), 8);
            images[1] = new BackgroundImage(new BitmapImage(new Uri("Resources/clickAreaBackground3.png", UriKind.Relative)), 100000);
            images[2] = new BackgroundImage(new BitmapImage(new Uri("Resources/clickAreaBackground4.png", UriKind.Relative)), 10000000);
            images[3] = new BackgroundImage(new BitmapImage(new Uri("Resources/clickAreaBackground5.png", UriKind.Relative)), 800000000);
            images[4] = new BackgroundImage(new BitmapImage(new Uri("Resources/clickAreaBackground6.png", UriKind.Relative)), 10000000000);
        }
    }
}
