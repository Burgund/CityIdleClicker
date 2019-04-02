using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class Factory
    {
        public void BuildObjectArray(CityObject[] buildings)
        {
            buildings[0] = new CityObject(100, 1);
            buildings[1] = new CityObject(600, 2);
            buildings[2] = new CityObject(1200, 5);
            buildings[3] = new CityObject(3000, 10);
            buildings[4] = new CityObject(8000, 25);
            buildings[5] = new CityObject(15000, 100);
            buildings[6] = new CityObject(100000, 900);
            buildings[7] = new CityObject(150000, 1200);
            buildings[8] = new CityObject(250000, 1600);
            buildings[9] = new CityObject(500000, 2500);
            buildings[10] = new CityObject(1000000, 4500);
            buildings[11] = new CityObject(5000000, 10000);
            buildings[12] = new CityObject(10000000, 15000);
            buildings[13] = new CityObject(50000000, 50000);
            buildings[14] = new CityObject(100000000, 100000);
            buildings[15] = new CityObject(1000000000, 2000000);
        }
    }
}
