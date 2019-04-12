using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class Wallet
    {
        private double moneyPerClick = 0;
        private ulong moneyPerSecond = 0;
        private ulong totalMoney = 0;

        public ulong MoneyPerSecond { get => moneyPerSecond; }
        public ulong TotalMoney { get => totalMoney; }
        public double MoneyPerClick { get => moneyPerClick; }

        public Wallet(ulong moneyPerClick)
        {
            this.moneyPerClick = moneyPerClick;
        }

        public void AddMoney(ulong money)
        {
            totalMoney = totalMoney + money;
        }

        public void SubstractMoney(ulong money)
        {
            totalMoney = totalMoney - money;
        }

        public void AddMPS(ulong money)
        {
            moneyPerSecond = moneyPerSecond + money;
        }

        public void AddMoneyPerClick(double money)
        {
            moneyPerClick = moneyPerClick + money;
        }
    }
}
