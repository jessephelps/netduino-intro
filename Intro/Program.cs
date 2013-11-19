using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Intro
{
    public class Program
    {
        public static void Main()
        {
            /*  Demo 1 - LED Flash
             *  Turn on for 1 second, Turn off for 1 second
             */
            //Intro.FlashLED.Flash.Run();

            /* Demo 2 - Button LED
             * Turn on when button is pressed, turn off when button is released
             */
            //var demo2 = new Intro.ButtonLED.Button();
            //demo2.Run();

            /* Demo 3 - XBee motion sensor
             */
            Intro.XBeeMotion.MotionSensor.Run();
        }
    }
}
