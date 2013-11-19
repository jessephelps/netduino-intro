using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Intro.FlashLED
{
    public class Flash
    {
        static public void Run()
        {
            Boolean state = false;
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, state);

            while (true)
            {
                state = !state;
                led.Write(state);

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
