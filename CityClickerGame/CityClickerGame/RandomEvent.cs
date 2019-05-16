using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    abstract public class RandomEvent
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract bool IsNegative { get; set; }

        public abstract void Happens();
        public abstract void CallMessage();
    }
}
