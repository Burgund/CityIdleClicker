using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class Loader
    {
        CityObject[] buildings = new CityObject[16];
        Achivement[] achivementsArray = new Achivement[28];
        Technology[] technologiesArray = new Technology[28];
        string path = Directory.GetCurrentDirectory() + "\\SynthCitySave.txt";
        string convertedBuildings;
        string convertedAchivements;
        string convertedTechnologies;
        string convertedWallet;

        public Loader(CityObject[] buildings, Achivement[] achivementsArray, Technology[] technologiesArray)
        {
            this.buildings = buildings;
            this.achivementsArray = achivementsArray;
            this.technologiesArray = technologiesArray;
        }

        public void LoadFile()
        {
            if (File.Exists(path))
            {
                string loadedData = File.ReadAllText(path);
                string[] lines = loadedData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                convertedBuildings = lines[0];
                convertedTechnologies = lines[1];
                convertedAchivements = lines[2];
                convertedWallet = lines[3];
            }
            else
            {
                MessageWindow mw = new MessageWindow("None save has been found!");
                mw.Show();
            }
        }

        public void LoadData(CityObject[] buil, Achivement[] achi, Technology[] tech)
        {
            string[] buildingsDecrypted = convertedBuildings.Split(new[] { "<B>" }, StringSplitOptions.None);
            string[] technologiesDecrypted = convertedTechnologies.Split(new[] { "<T>" }, StringSplitOptions.None);
            string[] achivementsDecrypted = convertedAchivements.Split(new[] { "<A>" }, StringSplitOptions.None);

            for(int i = 1; i < buildingsDecrypted.Length; i++)
            {
                string[] grainyData = buildingsDecrypted[i].Split(new[] { "<%>" }, StringSplitOptions.None);

                buil[i-1].Amount = Convert.ToInt32(grainyData[1]);
                buil[i-1].Earnings = Convert.ToUInt64(grainyData[2]);
                buil[i-1].Price = Convert.ToUInt64(grainyData[3]);
                buil[i-1].Multiplier = Convert.ToDouble(grainyData[4]);
            }

            for(int i = 1; i < technologiesDecrypted.Length; i++)
            {
                string[] grainyData = technologiesDecrypted[i].Split(new[] { "<%>" }, StringSplitOptions.None);
                tech[i - 1].IsInvented = grainyData[2] == "True";
            }

            for (int i = 1; i < achivementsDecrypted.Length; i++)
            {
                string[] grainyData = achivementsDecrypted[i].Split(new[] { "<%>" }, StringSplitOptions.None);
                achi[i - 1].IsAchived = grainyData[2] == "True";
            }

            string[] grainyDataWallet = convertedWallet.Split(new[] { "<%>" }, StringSplitOptions.None);

            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MoneyPerClick = Convert.ToDouble(grainyDataWallet[1]);
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MoneyPerSecond = Convert.ToUInt64(grainyDataWallet[2]);
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MultiplierPerClick = Convert.ToDouble(grainyDataWallet[3]);
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MultiplierPerSecond = Convert.ToDouble(grainyDataWallet[4]);
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.TotalMoney = Convert.ToUInt64(grainyDataWallet[5]);
        }

        public void BuildLoadedBuildings(CityObject[] buil)
        {
            //building object 1
            ((MainWindow)System.Windows.Application.Current.MainWindow).object1Amount.Text = Convert.ToString(buil[0].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject1.Text = Convert.ToString(buil[0].Price);
            //building object 2
            ((MainWindow)System.Windows.Application.Current.MainWindow).object2Amount.Text = Convert.ToString(buil[1].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject2.Text = Convert.ToString(buil[1].Price);
            //building object 3
            ((MainWindow)System.Windows.Application.Current.MainWindow).object3Amount.Text = Convert.ToString(buil[2].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject3.Text = Convert.ToString(buil[2].Price);
            //building object 4
            ((MainWindow)System.Windows.Application.Current.MainWindow).object4Amount.Text = Convert.ToString(buil[3].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject4.Text = Convert.ToString(buil[3].Price);
            //building object 5
            ((MainWindow)System.Windows.Application.Current.MainWindow).object5Amount.Text = Convert.ToString(buil[4].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject5.Text = Convert.ToString(buil[4].Price);
            //building object 6
            ((MainWindow)System.Windows.Application.Current.MainWindow).object6Amount.Text = Convert.ToString(buil[5].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject6.Text = Convert.ToString(buil[5].Price);
            //building object 7
            ((MainWindow)System.Windows.Application.Current.MainWindow).object7Amount.Text = Convert.ToString(buil[6].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject7.Text = Convert.ToString(buil[6].Price);
            //building object 8
            ((MainWindow)System.Windows.Application.Current.MainWindow).object8Amount.Text = Convert.ToString(buil[7].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject8.Text = Convert.ToString(buil[7].Price);
            //building object 9
            ((MainWindow)System.Windows.Application.Current.MainWindow).object9Amount.Text = Convert.ToString(buil[8].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject9.Text = Convert.ToString(buil[8].Price);
            //building object 10
            ((MainWindow)System.Windows.Application.Current.MainWindow).object10Amount.Text = Convert.ToString(buil[9].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject10.Text = Convert.ToString(buil[9].Price);
            //building object 11
            ((MainWindow)System.Windows.Application.Current.MainWindow).object11Amount.Text = Convert.ToString(buil[10].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject11.Text = Convert.ToString(buil[10].Price);
            //building object 12
            ((MainWindow)System.Windows.Application.Current.MainWindow).object12Amount.Text = Convert.ToString(buil[11].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject12.Text = Convert.ToString(buil[11].Price);
            //building object 13
            ((MainWindow)System.Windows.Application.Current.MainWindow).object13Amount.Text = Convert.ToString(buil[12].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject13.Text = Convert.ToString(buil[12].Price);
            //building object 14
            ((MainWindow)System.Windows.Application.Current.MainWindow).object14Amount.Text = Convert.ToString(buil[13].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject14.Text = Convert.ToString(buil[13].Price);
            //building object 15
            ((MainWindow)System.Windows.Application.Current.MainWindow).object15Amount.Text = Convert.ToString(buil[14].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject15.Text = Convert.ToString(buil[14].Price);
            //building object 16
            ((MainWindow)System.Windows.Application.Current.MainWindow).object16Amount.Text = Convert.ToString(buil[15].Amount);
            ((MainWindow)System.Windows.Application.Current.MainWindow).priceOfObject16.Text = Convert.ToString(buil[15].Price);
        }
    }
}
