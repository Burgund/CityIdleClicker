using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    public class EventWalletIngerence : RandomEvent
    {
        private string name;
        private string description;
        private bool isNegative;
        private double percent;
        private int index;

        public override string Name { get => name; set => name = value; }
        public override string Description { get => description; set => description = value; }
        public override bool IsNegative { get => isNegative; set => isNegative = value; }
        public int Index { get => index; set => index = value; }

        public EventWalletIngerence(string name, string description, bool isNegative, double percent, int index)
        {
            this.name = name;
            this.description = description;
            this.isNegative = isNegative;
            this.percent = percent;
            this.index = index;
        }

        public override void Happens()
        {
            double money = ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.TotalMoney * percent;
            if (money > 0)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.TotalMoney += Convert.ToUInt64(money);
            }
            else
            {
                if (((MainWindow)System.Windows.Application.Current.MainWindow).wallet.TotalMoney > money)
                {
                    money = money * -1;
                    ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.TotalMoney -= Convert.ToUInt64(money);
                }
                else
                {
                    return;
                }
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
