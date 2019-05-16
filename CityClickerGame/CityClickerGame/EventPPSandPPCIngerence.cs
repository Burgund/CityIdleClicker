using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    public class EventPPSandPPCIngerence : RandomEvent
    {
        private string name;
        private string description;
        private bool isNegative;
        private bool isPPC;
        private double modifier;
        private int index;

        public override string Name { get => name; set => name = value; }
        public override string Description { get => description; set => description = value; }
        public override bool IsNegative { get => isNegative; set => isNegative = value; }
        public bool IsPPC { get => isPPC; set => isPPC = value; }
        public int Index { get => index; set => index = value; }

        public EventPPSandPPCIngerence(string name, string description, bool isNegative, bool isPPC, double modifier, int index)
        {
            this.name = name;
            this.description = description;
            this.isNegative = isNegative;
            this.isPPC = isPPC;
            this.modifier = modifier;
            this.index = index;
        }

        public override void Happens()
        {
            if (isPPC)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.AddMultiplierPerClick(modifier);
            }
            else
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.AddMultiplierPerSecond(modifier);
            }
            CallMessage();
        }

        public override void CallMessage()
        {
            Event e = new Event(this.name, this.description, index);
            e.Show();
        }
    }
}
