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
        //Private variables and constructor ---------------------------------------------------------------
        Achivement[] achivements = new Achivement[28];

        public Achivements(Achivement[] achivements)
        {
            InitializeComponent();
            this.achivements = achivements;
            //setting achivement "Open achivements vindow" image as achived, it's always achived when this window is open
            this.achivement3.Source = new BitmapImage(new Uri("Resources/ach_02.PNG", UriKind.Relative));

            //When calling and initializing achivements window this loop checks which achivements images should be set as achived
            foreach (Achivement x in achivements)
            {
                if(x.IsAchived)
                {
                    SetAchived(x.Id);
                }
            }
        }

        //Buttons handlers ---------------------------------------------------------------------------------
        //Achivement number 22 (or index 21 in array) can only be achived by clicking it's image
        private void SecretTwentyTwoAchived(object sender, MouseEventArgs e)
        {
            ((MainWindow)this.Owner).CheckForAchivement(21);
            this.achivement22.Source = new BitmapImage(new Uri("Resources/ach_21.PNG", UriKind.Relative));
            ((MainWindow)this.Owner).SetTwentyTwo();
        }

        //Class logic --------------------------------------------------------------------------------------
        public void SetAchived(int number)
        {
            switch (number)
            {
                case 1:
                    this.achivement1.Source = new BitmapImage(new Uri("Resources/ach_00.png", UriKind.Relative));
                    break;
                case 2:
                    this.achivement2.Source = new BitmapImage(new Uri("Resources/ach_01.PNG", UriKind.Relative));
                    break;
                case 4:
                    this.achivement4.Source = new BitmapImage(new Uri("Resources/ach_03.PNG", UriKind.Relative));
                    break;
                case 5:
                    this.achivement5.Source = new BitmapImage(new Uri("Resources/ach_04.PNG", UriKind.Relative));
                    break;
                case 6:
                    this.achivement6.Source = new BitmapImage(new Uri("Resources/ach_05.PNG", UriKind.Relative));
                    break;
                case 7:
                    this.achivement7.Source = new BitmapImage(new Uri("Resources/ach_06.PNG", UriKind.Relative));
                    break;
                case 8:
                    this.achivement8.Source = new BitmapImage(new Uri("Resources/ach_07.PNG", UriKind.Relative));
                    break;
                case 9:
                    this.achivement9.Source = new BitmapImage(new Uri("Resources/ach_08.PNG", UriKind.Relative));
                    break;
                case 10:
                    this.achivement10.Source = new BitmapImage(new Uri("Resources/ach_09.PNG", UriKind.Relative));
                    break;
                case 11:
                    this.achivement11.Source = new BitmapImage(new Uri("Resources/ach_10.PNG", UriKind.Relative));
                    break;
                case 12:
                    this.achivement12.Source = new BitmapImage(new Uri("Resources/ach_11.PNG", UriKind.Relative));
                    break;
                case 13:
                    this.achivement13.Source = new BitmapImage(new Uri("Resources/ach_12.PNG", UriKind.Relative));
                    break;
                case 14:
                    this.achivement14.Source = new BitmapImage(new Uri("Resources/ach_13.PNG", UriKind.Relative));
                    break;
                case 15:
                    this.achivement15.Source = new BitmapImage(new Uri("Resources/ach_14.PNG", UriKind.Relative));
                    break;
                case 16:
                    this.achivement16.Source = new BitmapImage(new Uri("Resources/ach_15.PNG", UriKind.Relative));
                    break; 
                case 17:
                    this.achivement17.Source = new BitmapImage(new Uri("Resources/ach_16.PNG", UriKind.Relative));
                    break;
                case 18:
                    this.achivement18.Source = new BitmapImage(new Uri("Resources/ach_17.PNG", UriKind.Relative));
                    break;
                case 19:
                    this.achivement19.Source = new BitmapImage(new Uri("Resources/ach_18.PNG", UriKind.Relative));
                    break;
                case 20:
                    this.achivement20.Source = new BitmapImage(new Uri("Resources/ach_19.PNG", UriKind.Relative));
                    break;
                case 21:
                    this.achivement21.Source = new BitmapImage(new Uri("Resources/ach_20.PNG", UriKind.Relative));
                    break;
                case 22:
                    this.achivement22.Source = new BitmapImage(new Uri("Resources/ach_21.PNG", UriKind.Relative));
                    break;
                case 23:
                    this.achivement23.Source = new BitmapImage(new Uri("Resources/ach_22.PNG", UriKind.Relative));
                    break;
                case 24:
                    this.achivement24.Source = new BitmapImage(new Uri("Resources/ach_23.PNG", UriKind.Relative));
                    break;
                case 25:
                    this.achivement25.Source = new BitmapImage(new Uri("Resources/ach_24.PNG", UriKind.Relative));
                    break;
                case 26:
                    this.achivement26.Source = new BitmapImage(new Uri("Resources/ach_25.PNG", UriKind.Relative));
                    break;
                case 27:
                    this.achivement27.Source = new BitmapImage(new Uri("Resources/ach_26.PNG", UriKind.Relative));
                    break;
                case 28:
                    this.achivement28.Source = new BitmapImage(new Uri("Resources/ach_27.PNG", UriKind.Relative));
                    break;
            }
        }
    }
}
