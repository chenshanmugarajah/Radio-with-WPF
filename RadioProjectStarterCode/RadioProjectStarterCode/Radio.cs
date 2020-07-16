using System;
using System.Net;
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

        public Radio(int channel = 1, bool isOn = false)
        {
            _channel = channel;
            _on = isOn;
        }

        public int Channel {
            get { return _channel; }
            set { if (value >= 1 && value <= 4 && _on) _channel = value; }
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