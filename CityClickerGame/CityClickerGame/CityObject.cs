﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class CityObject
    {
        private string name;
        private ulong price = 0;
        private int amount = 0;
        private ulong earnings = 0;

        public CityObject(ulong price, ulong earnings)
        {
            this.earnings = earnings;
            this.price = price;
        }

        public ulong Price { get => price; }
        public int Amount { get => amount; }
        public string Name { get => name; }
        public ulong Earnings { get => earnings; }

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
    }
}