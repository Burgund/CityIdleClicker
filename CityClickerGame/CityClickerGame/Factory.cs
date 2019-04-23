using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CityClickerGame
{
    class Factory
    {
        public void BuildAchivementsArray(Achivement[] achivements)
        {
            achivements[0] = new Achivement("Focus", "Turn off music ", 1);
            achivements[1] = new Achivement("Curiostity", "Open credits window", 2);
            achivements[2] = new Achivement("Gon on!", "Open achivements window", 3);
            achivements[3] = new Achivement("Louder!", "Load game", 4);
            achivements[4] = new Achivement("Poor guy", "Collect 10000 (10 tousand)", 5);
            achivements[5] = new Achivement("Your first car!", "Collect 1000000 (million)", 6);
            achivements[6] = new Achivement("Cream of the crop", "Collect 1000000000 (milliard)", 7);
            achivements[7] = new Achivement("Businessman", "Collect 1000000000000 (billion)", 8);
            achivements[8] = new Achivement("Rockefeller, is it you?", "Collect 1000000000000000 (billiard)", 9);
            achivements[9] = new Achivement("Golden Pepe apeared", "Collect 1000000000000000000 (Trillion)", 10);
            achivements[10] = new Achivement("Wow!", "Build your first building", 11);
            achivements[11] = new Achivement("Amazing!", "Build the most expensive building", 12);
            achivements[12] = new Achivement("Stahp!", "Have at least 100 building of whichever kind of building", 13);
            achivements[13] = new Achivement("A", "Have 10 GPC", 14);
            achivements[14] = new Achivement("B", "Have 100 GPC", 15);
            achivements[15] = new Achivement("C", "Have 1000 GPC", 16);
            achivements[16] = new Achivement("D", "Have 1000000 GPC", 17);
            achivements[17] = new Achivement("Newbie", "Have 100 GPS", 18);
            achivements[18] = new Achivement("It's over 9000!!!11", "Have 9000 GPS", 19);
            achivements[19] = new Achivement("Global Elite", "Have 10000000 GPS", 20);
            achivements[20] = new Achivement("Motion defeated", "Try to buy something without enough money", 21);
            achivements[21] = new Achivement("What are you doing?!", "Click this achivement", 22);
            achivements[22] = new Achivement("Geek", "Open technology window", 23);
            achivements[23] = new Achivement("<todo>", "<todo>", 24);
            achivements[24] = new Achivement("<todo>", "<todo>", 25);
            achivements[25] = new Achivement("<todo>", "<todo>", 26);
            achivements[26] = new Achivement("<todo>", "<todo>", 27);
            achivements[27] = new Achivement("<todo>", "<todo>", 28);
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
    }
}
