using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;

namespace RadioApp
{
    public class Radio
    {
        public static void Main(string[] args)
        {
        }

        private int _channel;
        private bool _on;
        private int _volume;

        public Radio(int channel = 1, bool isOn = false, int volume = 1)
        {
            _channel = channel;
            _on = isOn;
            _volume = volume;
        }

        public int Channel {
            get { return _channel; }
            set { if (value >= 1 && value <= 4 && _on) _channel = value; }
        }

        public int Volume
        {
            get { return _volume; }
            set { if (value >= 0 && value <= 10 && _on) _volume = value; }
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }

        public string Play()
        {
            return _on ? $"Playing channel {Channel}" : "Radio is off";
        }
        
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}