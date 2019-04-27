using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    public class Wallet
    {
        private double moneyPerClick = 0;
        private ulong moneyPerSecond = 0;
        private ulong totalMoney = 0;
        private double multiplierPerSecond = 1;
        private double multiplierPerClick = 1;

        public ulong MoneyPerSecond { get => moneyPerSecond; }
        public ulong TotalMoney { get => totalMoney; }
        public double MoneyPerClick { get => moneyPerClick; }
        public double MultiplierPerSecond { get => multiplierPerSecond; set => multiplierPerSecond = value; }
        public double MultiplierPerClick { get => multiplierPerClick; set => multiplierPerClick = value; }

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

        public void AddMultiplierPerSecond(double multiplier)
        {
            this.multiplierPerSecond += multiplier;
        }

        public void AddMultiplierPerClick(double multiplier)
        {
            this.multiplierPerClick += multiplier;
        }

        public ulong GetRealMoneyPerSecond()
        {
            return Convert.ToUInt64((double)moneyPerSecond * multiplierPerSecond);
        }

        public double GetRealMoneyPerClick()
        {
            return moneyPerClick * multiplierPerClick;
        }
    }
}
