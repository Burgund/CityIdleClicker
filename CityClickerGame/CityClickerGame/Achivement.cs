using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace CityClickerGame
{
    public class Achivement
    {
        private string name;
        private bool isAchived = false;
        private string picture;
        private string condition;
        private int id;

        public string Name { get => name; set => name = value; }
        public bool IsAchived { get => isAchived; set => isAchived = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Condition { get => condition; set => condition = value; }
        public int Id { get => id; set => id = value; }

        public Achivement(string name, string picture, string condition, bool isAchived)
        {
            this.name = name;
            this.isAchived = isAchived;
            this.picture = picture;
            this.condition = condition;
        }

        public Achivement(string name, string condition, int id)
        {
            this.name = name;
            this.condition = condition;
            this.id = id;
        }

        public void WhenAchived()
        {
            AchivedNotification achived = new AchivedNotification(this.name, this.condition);
            achived.Show();
            //MessageBox.Show("Congratulations! You just unlocked achivement " + name);
        }
    }
}
