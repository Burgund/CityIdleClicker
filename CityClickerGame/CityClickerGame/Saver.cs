using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class Saver
    {
        string path = Directory.GetCurrentDirectory() + "\\SynthCitySave.txt";
        string[][] convertedBuildings = new string[16][];
        string[][] convertedAchivements = new string[28][];
        string[][] convertedTechnologies = new string[28][];
        string[] convertedWallet = new string[7];

        public Saver(CityObject[] buildings, Achivement[] achivementsArray, Technology[] technologiesArray, Wallet wallet)
        {
            BuildingsZipper(buildings);
            AchivementsZipper(achivementsArray);
            TechnologiesZipper(technologiesArray);
            WalletZipper(wallet);
        }

        private void BuildingsZipper(CityObject[] buildings)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                //For each building build an array where index 1 = amount, 2 = earnings, 3 = price and 4 = multiplier
                string[] converionBuilding = new string[6];
                converionBuilding[0] = "<B>";
                converionBuilding[5] = "</>";
                converionBuilding[1] = "<%>" + Convert.ToString(buildings[i].Amount) + "<%>";
                converionBuilding[2] = "<%>" + Convert.ToString(buildings[i].Earnings) + "<%>";
                converionBuilding[3] = "<%>" + Convert.ToString(buildings[i].Price) + "<%>";
                converionBuilding[4] = "<%>" + Convert.ToString(buildings[i].Multiplier) + "<%>";
                convertedBuildings[i] = converionBuilding;
            }
        }

        private void AchivementsZipper(Achivement[] achivementsArray)
        {
            for (int i = 0; i < achivementsArray.Length; i++)
            {
                //For each achivement build an array where index 1 = id, 2 = bool if achived
                string[] convertionAchivements = new string[4];
                convertionAchivements[0] = "<A>";
                convertionAchivements[3] = "</>";
                convertionAchivements[1] = "<%>" + Convert.ToString(achivementsArray[i].Id) + "<%>";
                convertionAchivements[2] = "<%>" + achivementsArray[i].IsAchived.ToString() + "<%>";
                convertedAchivements[i] = convertionAchivements;
            }
        }

        private void TechnologiesZipper(Technology[] technologiesArray)
        {
            for (int i = 0; i < technologiesArray.Length; i++)
            {
                //For each technology build an array where index 1 = id, 2 = bool if invented
                string[] convertionTechnologies = new string[4];
                convertionTechnologies[0] = "<T>";
                convertionTechnologies[3] = "</>";
                convertionTechnologies[1] = "<%>" + Convert.ToString(technologiesArray[i].Id) + "<%>";
                convertionTechnologies[2] = "<%>" + technologiesArray[i].IsInvented.ToString() + "<%>";
                convertedTechnologies[i] = convertionTechnologies;
            }
        }

        private void WalletZipper(Wallet wallet)
        {
            convertedWallet[0] = "<W>";
            convertedWallet[1] = "<%>" + Convert.ToString(wallet.MoneyPerClick) + "<%>";
            convertedWallet[2] = "<%>" + Convert.ToString(wallet.MoneyPerSecond) + "<%>";
            convertedWallet[3] = "<%>" + Convert.ToString(wallet.MultiplierPerClick) + "<%>";
            convertedWallet[4] = "<%>" + Convert.ToString(wallet.MultiplierPerSecond) + "<%>";
            convertedWallet[5] = "<%>" + Convert.ToString(wallet.TotalMoney) + "<%>";
            convertedWallet[6] = "</>";
        }

        public void SaveGame()
        {
            string output = "";
            for (int i = 0; i < convertedBuildings.Length; i++)
            {
                output += string.Join("", convertedBuildings[i]);
            }
            output += Environment.NewLine;
            for (int i = 0; i <  convertedTechnologies.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine("-----------------------------------------------------------------");
                System.Diagnostics.Debug.WriteLine(i);
                output += string.Join("", convertedTechnologies[i]);
            }
            output += Environment.NewLine;
            for (int i = 0; i < convertedAchivements.Length; i++)
            {
                output += string.Join("", convertedAchivements[i]);
            }
            output += Environment.NewLine;
            output += string.Join("", convertedWallet);
            File.WriteAllText(path, output);
        }
    }
}
