using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace CityClickerGame
{
    class Achivements
    {
        private string name;
        private bool isAchived;
        private string picture;
        private string condition;

        public string Name { get => name; set => name = value; }
        public bool IsAchived { get => isAchived; set => isAchived = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Condition { get => condition; set => condition = value; }

        public void WhenAchived()
        {
            MessageBox.Show("Congratulations! You just unlocked achivement " + name);
        }
    }
}
