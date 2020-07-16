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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioApp;

namespace RadioInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radio;

        public MainWindow()
        {
            InitializeComponent();
            radio = new Radio();
        }

        private void ButtonChannelUp_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel += 1;
            LabelChannel.Content = radio.Channel;
            LabelDisplay.Content = radio.Play();
        }

        private void ButtonChannelDown_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel -= 1;
            LabelChannel.Content = radio.Channel;
            LabelDisplay.Content = radio.Play();
        }

        private void ButtonMainSwitch_Click(object sender, RoutedEventArgs e)
        {
            string buttonContent = (string)ButtonMainSwitch.Content;
            if (buttonContent == "Off")
            {
                
                ButtonMainSwitch.Content = "On";

                ButtonMainSwitch.Background = Brushes.DimGray;
                LabelChannel.Background = Brushes.DimGray;
                LabelVolume.Background = Brushes.DimGray;
                ButtonChannelUp.Background = Brushes.DimGray;
                ButtonChannelDown.Background = Brushes.DimGray;
                LabelDisplay.Background = Brushes.DimGray;
                ButtonVolumeUp.Background = Brushes.DimGray;
                ButtonVolumeDown.Background = Brushes.DimGray;
                VoidChannel.Foreground = Brushes.DimGray;
                VoidVolume.Foreground = Brushes.DimGray;
                ButtonPlay.Background = Brushes.DimGray;
                LabelDisplay.Content = "";

                radio.Channel = 1;
                LabelChannel.Content = radio.Channel;#
                radio.TurnOff();

            } else
            {
                radio.TurnOn();
                ButtonMainSwitch.Content = "Off";
                ButtonMainSwitch.Background = Brushes.White;
                LabelChannel.Background = Brushes.White;
                LabelVolume.Background = Brushes.White;
                ButtonChannelUp.Background = Brushes.White;
                ButtonChannelDown.Background = Brushes.White;
                LabelDisplay.Background = Brushes.White;
                ButtonVolumeUp.Background = Brushes.White;
                ButtonVolumeDown.Background = Brushes.White;
                VoidChannel.Foreground = Brushes.White;
                VoidVolume.Foreground = Brushes.White;
                ButtonPlay.Background = Brushes.White;
            }
           
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content = radio.Play();
        }
    }
}
