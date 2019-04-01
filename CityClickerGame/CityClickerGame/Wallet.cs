using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class Wallet
    {
        private int moneyPerClick = 1;
        private ulong moneyPerSecond = 0;
        private ulong totalMoney = 0;

        public ulong MoneyPerSecond { get => moneyPerSecond; }
        public ulong TotalMoney { get => totalMoney; }
        public int MoneyPerClick { get => moneyPerClick; }

        public void AddMoney(int money)
        {
            totalMoney = totalMoney + Convert.ToUInt64(money);
        }

        public void SubstractMoney(int money)
        {
            totalMoney = totalMoney - Convert.ToUInt64(money);
        }

        public void AddMPS(int money)
        {
            moneyPerSecond = moneyPerSecond + Convert.ToUInt64(money);
        }

        public void IncreaseMoneyPerClick(int money)
        {
            moneyPerClick = moneyPerClick + money;
        }
    }
}
