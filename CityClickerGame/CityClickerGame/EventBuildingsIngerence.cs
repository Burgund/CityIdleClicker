using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    public class EventBuildingsIngerence : RandomEvent
    {
        private string name;
        private string description;
        private bool isNegative;
        private int index;
        private Random rand = new Random();

        public override string Name { get => name; set => name = value; }
        public override string Description { get => description; set => description = value; }
        public override bool IsNegative { get => isNegative; set => isNegative = value; }
        public int Index { get => index; set => index = value; }

        public EventBuildingsIngerence(string name, string description, bool isNegative, int index)
        {
            this.name = name;
            this.description = description;
            this.isNegative = isNegative;
            this.index = index;
        }

        public override void Happens()
        {
            int index = rand.Next(16);
            int amount = ((MainWindow)System.Windows.Application.Current.MainWindow).buildings[index].Amount;
            if (amount > 0)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).buildings[index].Amount = amount - 1;
                CallMessage();
            }
        }

        public override void CallMessage()
        {
            Event e = new Event(this.name, this.description, index);
            e.Show();
        }
    }
}
