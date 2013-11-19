using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Intro.ButtonLED
{
    public class Button
    {
        InputPort button;
        OutputPort led;

        public void Run()
        {
            button = new InterruptPort(Pins.ONBOARD_BTN, true, Port.ResistorMode.Disabled, Port.InterruptMode.InterruptEdgeBoth);
            led = new OutputPort(Pins.ONBOARD_LED, false);

            button.OnInterrupt += button_OnInterrupt;
         
            while (true)
            {
                // spin
            }
        }

        private void button_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            led.Write(data2 == 1);
        }
    }
}
