using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    public class EventNeutral : RandomEvent
    {
        private string name;
        private string description;
        private bool isNegative;
        private int index;

        public override string Name { get => name; set => name = value; }
        public override string Description { get => description; set => description = value; }
        public override bool IsNegative { get => isNegative; set => isNegative = value; }
        public int Index { get => index; set => index = value; }

        public EventNeutral(string name, string description, bool isNegative, int index)
        {
            this.name = name;
            this.description = description;
            this.isNegative = isNegative;
            this.index = index;
        }

        public override void Happens()
        {
            CallMessage();
        }

        public override void CallMessage()
        {
            Event e = new Event(this.name, this.description, index);
            e.Show();
        }
    }
}
