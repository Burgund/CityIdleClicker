using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    public class CityObject
    {
        //Private variables, getters, setters and constructors ----------------------------------
        private string name;
        private ulong price = 0;
        private int amount = 0;
        private ulong earnings = 0;
        private double addMPC = 0;
        private double multiplier = 1;

        public ulong Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Name { get => name; }
        public ulong Earnings { get => earnings; set => earnings = value; }
        public double AddMPC { get => addMPC; }
        public double Multiplier { get => multiplier; set => multiplier = value; }

        public CityObject(ulong price, ulong earnings, double mpc)
        {
            this.earnings = earnings;
            this.price = price;
            this.addMPC = mpc;
        }

        public CityObject(string name, ulong price, ulong earnings, double mpc)
        {
            this.name = name;
            this.earnings = earnings;
            this.price = price;
            this.addMPC = mpc;
        }

        //When new object is built, this function increases price of the next one
        public void IncreaseAmount()
        {
            ulong increase = Convert.ToUInt64(Convert.ToDouble(price) * 0.2);
            if (increase > 1)
            {
                price = price + increase;
            }
            else
            {
                price = price + 2;
            }

            amount += 1;
        }

        //Increases earnings multiplier (can be done by technologies) 
        public void IncreaseMultiplier(double multiplier)
        {
            this.Multiplier += multiplier;
        }

        //Returns earnings including the multiplier
        public ulong GetRealEarnings()
        {
            return Convert.ToUInt64((double)earnings * Multiplier);
        }
    }
}
