using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClickerGame
{
    class RandomEventHandler
    {
        RandomEvent[] eventsArray = new RandomEvent[10];
        Random rand = new Random();

        public RandomEventHandler()
        {
            eventsArray[0] = new EventPeriodicEffect("People are playing SynthCity instead of working!", "-80% PPS and -80% PPC for 2 minutes", true, 0);
            eventsArray[1] = new EventPeriodicEffect("People are listening to Synthwave instead of working!", "-80% PPS and -80% PPC for 2 minutes", true, 1);
            eventsArray[2] = new EventNeutral("VHS has been screwed in", "Don't worry, nothing happend", true, 2);
            eventsArray[3] = new EventWalletIngerence("Overpopulation!", "-20% Palms in your wallet", true, -0.2, 3);
            //<TODO> The problem is with changing building price and amount textblock
            //eventsArray[4] = new EventBuildingsIngerence("Miami is falling apart!", "-1 random building", true); 
            eventsArray[4] = new EventPPSandPPCIngerence("16 bit colour", "+1% PPC forever", false, true, 0.01, 4);
            eventsArray[5] = new EventPPSandPPCIngerence("32 bit colour", "+2% PPC forever", false, true, 0.02, 5);
            eventsArray[6] = new EventPPSandPPCIngerence("64 bit colour", "+5% PPC forever", false, true, 0.05, 6);
            eventsArray[7] = new EventWalletIngerence("TOKYO '89", "+10% Palms in your wallet!", false, 0.1, 7);
            eventsArray[8] = new EventPPSandPPCIngerence("AESTHETIC", "+1% PPS forever", false, false, 0.01, 8);
        }

        public void ExecuteEvent(Technology hyperComputing, Technology verticalFarming)
        {
            int number = rand.Next(0, eventsArray.Length -1);
            
            if(eventsArray[number].IsNegative)
            {
                if(!hyperComputing.IsInvented)
                {
                    if (number == 3)
                    {
                        if (verticalFarming.IsInvented)
                        {
                            eventsArray[number].Happens();
                        }
                    }
                    else
                    {
                        eventsArray[number].Happens();
                    }
                }
                return;
            }
            else
            {
                if(hyperComputing.IsInvented)
                {
                    eventsArray[number].Happens();
                }
                return;
            }
        }
    }
}
