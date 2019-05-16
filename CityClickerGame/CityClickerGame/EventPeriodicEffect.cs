using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace CityClickerGame
{
    public class EventPeriodicEffect : RandomEvent
    {
        private string name;
        private string description;
        private bool isNegative;
        private int index;
        DispatcherTimer timer = new DispatcherTimer();

        public override string Name { get => name; set => name = value; }
        public override string Description { get => description; set => description = value; }
        public override bool IsNegative { get => isNegative; set => isNegative = value; }

        public EventPeriodicEffect(string name, string description, bool isNegative, int index)
        {
            this.name = name;
            this.description = description;
            this.isNegative = isNegative;
            this.index = index;
        }

        public override void Happens()
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MultiplierPerClick -= 0.8;
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MultiplierPerSecond -= 0.8;
            CallMessage();

            timer.Tick += new EventHandler(CloseEvent);
            timer.Interval = new TimeSpan(0, 2, 0);
            timer.Start();
        }

        public override void CallMessage()
        {
            Event e = new Event(this.name, this.description, index);
            e.Show();
        }

        private void CloseEvent(object sender, EventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MultiplierPerClick += 0.8;
            ((MainWindow)System.Windows.Application.Current.MainWindow).wallet.MultiplierPerSecond += 0.8;

            timer.Stop();
        }
    }
}
