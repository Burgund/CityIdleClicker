using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class CityObject
    {
        private string name;
        private long price = 0;
        private int amount = 0;
        private int earnings = 0;

        public CityObject(int price, int earnings)
        {
            this.earnings = earnings;
            this.price = price;
        }

        public long Price { get => price; }
        public int Amount { get => amount; }
        public string Name { get => name; }
        public int Earnings { get => earnings; }

        public void IncreasePrice()
        {
            int increase = Convert.ToInt32(Convert.ToDouble(price) * 0.2);
            if (increase > 1)
            {
                price = price + increase;
            }
            else
            {
                price = price + 2;
            }
        }
    }
}
