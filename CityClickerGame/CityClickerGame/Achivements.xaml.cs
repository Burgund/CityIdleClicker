using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CityClickerGame
{
    public partial class Achivements : Window
    {
        Achivement[] achivements = new Achivement[28];

        public Achivements(Achivement[] achivements)
        {
            InitializeComponent();

            this.achivements = achivements;
        }
    }
}
