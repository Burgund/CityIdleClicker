using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CityClickerGame
{
    class BackgroundImage
    {
        //Private Variables, getters and setters -----------------------------------------------
        private BitmapImage image;
        private bool wasActive = false;
        private ulong ppsNeededToUnlock;

        public BitmapImage Image { get => image; set => image = value; }
        public bool WasActive { get => wasActive; set => wasActive = value; }
        public ulong PpsNeededToUnlock { get => ppsNeededToUnlock; set => ppsNeededToUnlock = value; }

        //Constructor
        public BackgroundImage(BitmapImage image, ulong ppsNeededToUnlock)
        {
            this.image = image;
            this.ppsNeededToUnlock = ppsNeededToUnlock;
        }
    }
}
