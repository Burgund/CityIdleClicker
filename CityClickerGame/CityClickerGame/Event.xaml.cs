using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CityClickerGame
{
    public partial class Event : Window
    {
        private int index;
        public Event(string name, string description, int index)
        {
            InitializeComponent();

            this.eventName.Text = name;
            this.eventDescription.Text = description;
            this.index = index;
            SetImage();
        }

        //Closing this window
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SetImage()
        {
            switch (index)
            {
                case 0:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_00.PNG", UriKind.Relative));
                    break;
                case 1:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_01.PNG", UriKind.Relative));
                    break;
                case 2:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_02.PNG", UriKind.Relative));
                    break;
                case 3:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_03.PNG", UriKind.Relative));
                    break;
                case 4:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_04.PNG", UriKind.Relative));
                    break;
                case 5:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_05.PNG", UriKind.Relative));
                    break;
                case 6:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_06.PNG", UriKind.Relative));
                    break;
                case 7:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_07.PNG", UriKind.Relative));
                    break;
                case 8:
                    this.eventPicture.Source = new BitmapImage(new Uri("Resources/ev_08.PNG", UriKind.Relative));
                    break;
            }
        }
    }
}
